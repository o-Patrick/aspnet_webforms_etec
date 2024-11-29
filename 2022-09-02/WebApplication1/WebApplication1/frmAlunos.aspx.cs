using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class frmAlunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular Cl = new Calcular();
            Cl.Nota1 = Convert.ToDouble(txtNota1.Text);
            Cl.Nota2 = Convert.ToDouble(txtNota2.Text);
            Cl.Nota3 = Convert.ToDouble(txtNota3.Text);

            txtResultado.Text = Cl.CalcMedia();
        }
    }
}