using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Propiedades
{
    internal class Resta
    {
        double v1, v2;

        public double V1 { get => v1; set => v1 = value; }
        public double V2 { get => v2; set => v2 = value; }

        public double Restar()
        {
            return V1 - V2;
        }
    }
}
