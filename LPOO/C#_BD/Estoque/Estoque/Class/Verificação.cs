using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Estoque
{
    class Verificação
    {
        public void SoNumeros(KeyPressEventArgs e)// usar para numeros e controles(todos) sem virgula e sem espaço
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void SoNumerosV(KeyPressEventArgs e)// so numeros com virgura 
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

        public void Data(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (!Char.IsDigit(e.KeyChar) && (e.KeyChar == '/'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void SoLetra(KeyPressEventArgs e)// so letras 
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
