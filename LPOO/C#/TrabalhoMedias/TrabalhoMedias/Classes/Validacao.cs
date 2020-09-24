using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMedias
{
    class Validacao
    {
        public void SoNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (!Char.IsDigit(e.KeyChar) && (e.KeyChar == ','))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /*public double Vazio(double Val1, double Val2 , double Val3)
        {
            if (Val1 == "")
            {

            }
        }*/
    }
}
