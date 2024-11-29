using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Alunos
{
    public partial class frmAlunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double Bim1, Bim2, Media;
            Bim1  = Convert.ToDouble(txtBim1.Text);
            Bim2  = Convert.ToDouble(txtBim2.Text);

            Media = (Bim1 + Bim2) / 2;

            lblResultado.Text = Convert.ToString(Media);

            if (Media >= 5)
            {
                lblResultadoFinal.Text = "Aprovado.";
            }
            else
            {
                lblResultadoFinal.Text = "Reprovado.";
            }

        }
    }
}