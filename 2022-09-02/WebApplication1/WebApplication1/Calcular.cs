using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Calcular
    {

        private double _Nota1, _Nota2, _Nota3;

        public double Nota1
        {
            get { return _Nota1; }
            set { _Nota1 = value; }
        }

        public double Nota2
        {
            get { return _Nota2; }
            set { _Nota2 = value; }
        }

        public double Nota3
        {
            get { return _Nota3; }
            set { _Nota3 = value; }
        }

        public string CalcMedia()
        {
            // média final
            double Mf = (_Nota1 + _Nota2 + _Nota3) / 3;
            string Retorno = "";

            if (Mf >= 7)
            {
                Retorno = "Aprovado";
            }
            else
            {
                Retorno = "Reprovado";
            }

            return Retorno;
        }
    }
}