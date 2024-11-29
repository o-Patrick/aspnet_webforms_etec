using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class frmPets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEspecie.Items.Clear();
                ddlEspecie.Items.Add("Gato");
                ddlEspecie.Items.Add("Cachorro");
                ddlEspecie.Items.Add("Pássaro");
            }
        }

        protected void ddlEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEspecie.Text == "Gato")
            {
                ddlRaca.Items.Clear();
                ddlRaca.Items.Add("Siamês");
                ddlRaca.Items.Add("Persa");
                ddlRaca.Items.Add("SRD");
            } else if (ddlEspecie.Text == "Cachorro")
            {
                ddlRaca.Items.Clear();
                ddlRaca.Items.Add("Pug");
                ddlRaca.Items.Add("Shih Tzu");
                ddlRaca.Items.Add("Husky");
            } else if (ddlEspecie.Text == "Pássaro")
            {
                ddlRaca.Items.Clear();
                ddlRaca.Items.Add("Calopsita");
                ddlRaca.Items.Add("Trinca-ferro");
                ddlRaca.Items.Add("Papagaio");
            }
        }

        protected void btnRecibo_Click(object sender, EventArgs e)
        {
            double valorTotal;

            valorTotal = 0;

            if (chkCastracao.Checked)
            {
                if (rdbFemea.Checked)
                {
                    valorTotal += 200;
                }
                else if (rdbMacho.Checked)
                {
                    valorTotal += 150;
                }
            }

            if (chkBanho.Checked) {
                valorTotal += 75;
            }

            if (chkTosa.Checked)
            {
                valorTotal += 95;
            }

            lblValorTotal.Text = Convert.ToString(valorTotal);
        }
    }
}