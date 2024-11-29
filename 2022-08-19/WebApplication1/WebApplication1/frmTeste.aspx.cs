using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class frmTeste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DDLProduto.Items.Clear();
            DDLProduto.Items.Add("Mesa");
            DDLProduto.Items.Add("Sofá");
            DDLProduto.Items.Add("Armário");
        }

        protected void DDLProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DDLProduto.Text == "Mesa")
            {
                DDLTipo.Items.Clear();
                DDLTipo.Items.Add("Redonda");
                DDLTipo.Items.Add("Quadrada");

                DDLCor.Items.Clear();
                DDLCor.Items.Add("Marfim");
                DDLCor.Items.Add("Branca");
            } else if(DDLProduto.Text == "Sofá")
            {
                DDLTipo.Items.Clear();
                DDLTipo.Items.Add("2 lugares");
                DDLTipo.Items.Add("3 lugares");

                DDLCor.Items.Clear();
                DDLCor.Items.Add("Bege");
                DDLCor.Items.Add("Preto");
            } else if(DDLProduto.Text == "Armário")
            {
                DDLTipo.Items.Clear();
                DDLTipo.Items.Add("2 portas");
                DDLTipo.Items.Add("3 portas");

                DDLCor.Items.Clear();
                DDLCor.Items.Add("Branco");
                DDLCor.Items.Add("Vermelho");
            }
        }
    }
}