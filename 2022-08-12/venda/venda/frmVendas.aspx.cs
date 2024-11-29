using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venda
{
    public partial class frmVendas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // função de cálculo para a venda
        double CalcVendas(double Val, double Qtd)
        {
            double ValorTotal;

            ValorTotal = Val * Qtd;

            // verifica se à vista ou à prazo
            if (rdbVista.Checked)
            {
                ValorTotal += ValorTotal * 0.05;
            }
            else if (rdbPrazo.Checked)
            {
                ValorTotal += ValorTotal * 0.075;
            }

            return ValorTotal;
        } // calcVendas()

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            // variáveis que receberão o valor de frmVendas
            double Valor, Quantidade;

            // valor do produto
            Valor = Convert.ToDouble(txtValor.Text);
            // quantidade do produto
            Quantidade = Convert.ToDouble(txtQuantidade.Text);

            // valor final, já mostra na tela
            lblValorTotal.Text = Convert.ToString(CalcVendas(Valor, Quantidade));

        } // btnCalcular_Click
    } // Page_Load
} // namespace venda
