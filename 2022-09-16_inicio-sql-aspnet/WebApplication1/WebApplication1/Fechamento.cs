using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Fechamento
    {

        private string _genero;
        private double _salgado, _bebidas, _outros;

        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public double salgado
        {
            get { return _salgado; }
            set { _salgado = value; }
        }

        public double bebidas
        {
            get { return _bebidas; }
            set { _bebidas = value; }
        }

        public double outros
        {
            get { return _outros; }
            set { _outros = value; }
        }

        public double CalcFechamento()
        {
            double FechamentoFinal = (5 * _salgado) + (5 * _bebidas) + (5 * _outros);

            if (_genero == "Feminino")
            {
                FechamentoFinal -= FechamentoFinal * 0.05;
            }

            return FechamentoFinal;
        }
    }
}