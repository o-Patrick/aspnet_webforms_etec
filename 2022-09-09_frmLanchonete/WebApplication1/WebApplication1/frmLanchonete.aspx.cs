using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class frmLanchonete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFechamento_Click(object sender, EventArgs e)
        {
            Fechamento Fc = new Fechamento();
            Fc.genero = rdbFeminino.Text;
            Fc.salgado = Convert.ToDouble(txtQuantidadeSalgado.Text);
            Fc.bebidas = Convert.ToDouble(txtQuantidadeBebidas.Text);
            Fc.outros = Convert.ToDouble(txtQuantidadeOutros.Text);

            txtResultado.Text = Fc.CalcFechamento();
        }
    }
}