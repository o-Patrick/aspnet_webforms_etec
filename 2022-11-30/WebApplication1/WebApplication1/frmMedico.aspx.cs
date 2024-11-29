using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// adicionado depois
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class frmMedico : System.Web.UI.Page
    {
        StringBuilder StrSql = new StringBuilder();
        SqlConnection Conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alunoinfo\source\repos\WebApplication1\WebApplication1\App_Data\hospital.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGeral_Click(object sender, EventArgs e)
        {
            StrSql.Append("SELECT * ");
            StrSql.Append("FROM Hospital ");
            StrSql.Append("ORDER BY Cliente");

            Conexao.Open();

            // responsável pelo comando
            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);
            // responsável por pegar as informações (?)
            SqlDataAdapter SDA = new SqlDataAdapter(StrSql.ToString(), Conexao);
            // conjunto de tabelas
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            gridConsulta.DataSource = DS;
            gridConsulta.DataBind();

            Conexao.Close();
        }

        protected void btnEsp_Click(object sender, EventArgs e)
        {
            StrSql.Append("SELECT * ");
            StrSql.Append("FROM Hospital ");
            StrSql.Append("WHERE especialidade = '"+ ddlEsp.Text +"' ");
            StrSql.Append("ORDER BY especialidade");

            Conexao.Open();

            // responsável pelo comando
            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);
            // responsável por pegar as informações (?)
            SqlDataAdapter SDA = new SqlDataAdapter(StrSql.ToString(), Conexao);
            // conjunto de tabelas
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            gridConsulta.DataSource = DS;
            gridConsulta.DataBind();

            Conexao.Close();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            StrSql.Remove(0, StrSql.Length);
            StrSql.Append("delete from HOSPITAL ");
            StrSql.Append("where CLIENTE = @CLIENTE");

            Conexao.Open();

            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);

            Cmd.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);

            if (Cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script> alert('Cliente excluído com sucesso!') </script>");
            }
            else
            {
                Response.Write("<script> alert('Não foi possível excluir cliente') </script>");
            }

            Conexao.Close();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            StrSql.Remove(0, StrSql.Length);
            StrSql.Append("INSERT INTO HOSPITAL ");
            StrSql.Append("(CLIENTE, DATA_ATENDIMENTO, VALOR_CONSULTA, MEDICO, ESPECIALIDADE) ");
            StrSql.Append("VALUES ");
            StrSql.Append("(@CLIENTE, @DATA_ATENDIMENTO, @VALOR_CONSULTA, @MEDICO, @ESPECIALIDADE)");

            Conexao.Open();

            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);

            Cmd.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);
            Cmd.Parameters.AddWithValue("@DATA_ATENDIMENTO", txtAtend.Text);
            Cmd.Parameters.AddWithValue("@VALOR_CONSULTA", txtValor.Text);
            Cmd.Parameters.AddWithValue("@MEDICO", ddlMedico.Text);
            Cmd.Parameters.AddWithValue("@ESPECIALIDADE", ddlEsp.Text);

            if (Cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script> alert('Cliente inserido com sucesso!') </script>");
            }
            else
            {
                Response.Write("<script> alert('Não foi possível inserir cliente') </script>");
            }

            Conexao.Close();
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            StrSql.Remove(0, StrSql.Length);
            StrSql.Append("UPDATE HOSPITAL ");
            StrSql.Append("SET DATA_ATENDIMENTO = @DATA_ATENDIMENTO, ");
            StrSql.Append("VALOR_CONSULTA = @VALOR_CONSULTA, ");
            StrSql.Append("MEDICO = @MEDICO, ");
            StrSql.Append("ESPECIALIDADE = @ESPECIALIDADE ");
            StrSql.Append("WHERE CLIENTE = @CLIENTE");

            Conexao.Open();

            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);

            Cmd.Parameters.AddWithValue("@DATA_ATENDIMENTO", txtAtend.Text);
            Cmd.Parameters.AddWithValue("@VALOR_CONSULTA", txtValor.Text);
            Cmd.Parameters.AddWithValue("@MEDICO", ddlMedico.Text);
            Cmd.Parameters.AddWithValue("@ESPECIALIDADE", ddlEsp.Text);
            Cmd.Parameters.AddWithValue("@CLIENTE", txtCliente.Text);

            if (Cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script> alert('Cliente atualizado com sucesso!') </script>");
            }
            else
            {
                Response.Write("<script> alert('Não foi possível atualizar cliente') </script>");
            }

            Conexao.Close();
        }
    }
}
