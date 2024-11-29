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
    }
}