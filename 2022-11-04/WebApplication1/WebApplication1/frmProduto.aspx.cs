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
    public partial class frmProduto : System.Web.UI.Page
    {
        StringBuilder StrSql = new StringBuilder();
        SqlConnection Conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alunoinfo\source\repos\WebApplication1\WebApplication1\App_Data\dbLoja.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultaProd_Click(object sender, EventArgs e)
        {
            StrSql.Append("SELECT * ");
            StrSql.Append("FROM TB_PRODUTO ");
            StrSql.Append("ORDER BY DESC_PRODUTO");

            Conexao.Open();

            // responsável pelo comando
            SqlCommand Cmd = new SqlCommand(StrSql.ToString(), Conexao);
            // responsável por pegar as informações (?)
            SqlDataAdapter SDA = new SqlDataAdapter(StrSql.ToString(), Conexao);
            // conjunto de tabelas
            DataSet DS = new DataSet();
            SDA.Fill(DS);

            gridProduto.DataSource = DS;
            gridProduto.DataBind();

            Conexao.Close();
        }
    }
}