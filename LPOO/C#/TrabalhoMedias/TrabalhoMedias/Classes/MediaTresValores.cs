using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMedias
{
    class MediaTresValores
    {
        public static double Verifica;

        public double DescartarNotaMenor(double Valor1, double Valor2, double Valor3)
        {

            if (Valor1 <= Valor2 && Valor1 <= Valor3)
            {
                Verifica = 1;
                return Verifica;
            }
            else if (Valor2 <= Valor1 && Valor2 <= Valor3)
            {
                Verifica = 2;
                return Verifica;
            }
            else
            {
                Verifica = 3;
                return Verifica;
            }
        }

        public double CalcularMediaDoisValores(double Val1, double Val2)
        {
            return (Val1 + Val2)/2;
        }
    }
}
