using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc1_pararaios
{
    public partial class frmParaRaios : Form
    {
        public frmParaRaios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ParaRaios pr = new ParaRaios();

            pr.cargaEletrica = Convert.ToDouble(txtCarga.Text);

            pr.tempo = Convert.ToDouble(txtTempo.Text);

            lblValor.Text = Convert.ToString(pr.corrente());

            lblResultado.Text = " " + pr.resultado();
                      
        }
    }
}
