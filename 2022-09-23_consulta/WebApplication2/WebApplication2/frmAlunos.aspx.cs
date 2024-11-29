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

namespace WebApplication2
{
    public partial class frmAlunos : System.Web.UI.Page
    {
        StringBuilder StrSql = new StringBuilder();
        SqlConnection Conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alunoinfo\source\repos\WebApplication2\WebApplication2\App_Data\Etec.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // estrutura condicional para consulta
            // responsável pela estrutura do comando
            StrSql.Remove(0, StrSql.Length);
            if (DdlTipo.Text == "Chamada")
            {
                StrSql.Append("SELECT Matricula, Nome ");
            }
            else if (DdlTipo.Text == "Geral")
            {
                StrSql.Append("SELECT * ");
            }
            StrSql.Append("FROM Alunos ");
            StrSql.Append("ORDER BY Nome");

            Conexao.Open();

            // responsável pelo comando
            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);
            // responsável por pegar as informações (?)
            SqlDataAdapter SDA = new SqlDataAdapter(StrSql.ToString(), Conexao);
            // conjunto de tabelas
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            GridAlunos.DataSource = DS;
            GridAlunos.DataBind();

            Conexao.Close();
        }
    }
}