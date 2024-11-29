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
    public partial class frmCliente : System.Web.UI.Page
    {
        StringBuilder StrSql = new StringBuilder();
        SqlConnection Conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alunoinfo\source\repos\WebApplication1\WebApplication1\App_Data\dbLoja.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            StrSql.Append("SELECT * ");
            StrSql.Append("FROM TB_CLIENTE ");
            StrSql.Append("ORDER BY NOME_CLIENTE");

            Conexao.Open();

            // responsável pelo comando
            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);
            // responsável por pegar as informações (?)
            SqlDataAdapter SDA = new SqlDataAdapter(StrSql.ToString(), Conexao);
            // conjunto de tabelas
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            gridCliente.DataSource = DS;
            gridCliente.DataBind();

            Conexao.Close();
        }
    }
}