using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRPF.Models
{
    public class Irpf
    {
        public double Valor { get; set; }

        public double Imposto { get; set; }

        public int Dependente { get; set; }

        public double CalcularValorIrpf()
        {
            if (Valor == 5000)
            {
                Imposto = 300.00;
                if (Dependente == 1)
                    Imposto = 200.00;
                if (Dependente == 2)
                    Imposto = 100.00;
            }
            else
            {
                if (Valor == 6000)
                    Imposto = 150;
            }
            return Imposto;
        }

    }
}