using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// novos
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WebApplication1
{
    public partial class frmLanchonete : System.Web.UI.Page
    {
        StringBuilder CmdSql = new StringBuilder();
        SqlConnection Conexao = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\alunoinfo\source\repos\WebApplication1\WebApplication1\App_Data\Etec.mdf;Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFechamento_Click(object sender, EventArgs e)
        {
            CmdSql.Remove(0, CmdSql.Length);
            // repare nos espaços depois de NOME e ALUNOS
            CmdSql.Append("SELECT MATRICULA AS Matricula, NOME ");
            CmdSql.Append("FROM ALUNOS ");
            CmdSql.Append("ORDER BY MATRICULA");

            Fechamento Fc = new Fechamento();
            Fc.genero = rdbFeminino.Text;
            Fc.salgado = Convert.ToDouble(txtQuantidadeSalgado.Text);
            Fc.bebidas = Convert.ToDouble(txtQuantidadeBebidas.Text);
            Fc.outros = Convert.ToDouble(txtQuantidadeOutros.Text);

            txtResultado.Text = Fc.CalcFechamento();
        }
    }
}
