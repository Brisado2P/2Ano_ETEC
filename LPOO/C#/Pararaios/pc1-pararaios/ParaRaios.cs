using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc1_pararaios
{
    class ParaRaios
    {
        public double cargaEletrica;
        public double tempo;



        public double corrente()
        {
            return this.cargaEletrica / tempo;
        }

        public String resultado()
        {
            if (corrente() < 25)
            {
                return "Seguro";
            }
            else
            {
                return "Perigo";
            }
        }
    }
}
