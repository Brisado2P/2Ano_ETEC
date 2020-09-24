using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questoes_novo
{
    public partial class frmQuestao1 : Form
    {

        public frmQuestao1()
        {
            InitializeComponent();
        }

        private void btnCancelarProva_Click(object sender, EventArgs e)
        {
            Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            Variaveis.SubTotal = 0;
            Variaveis.ValorTotal = 0;
            Variaveis.questao1 = 0;
        }

        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            Close();
            frmQuestao2 frm2 = new frmQuestao2();
            frm2.Show();

            if (rdbAndromeda.Checked == true)
            {
                Variaveis.questao1 = 2;
                Variaveis.Checked1 = 1;
            }
            else 
            {
                Variaveis.questao1 = 0;
            }

            if (rdbGalaxiaOlhoNegro.Checked == true)
            {
                Variaveis.Checked1 = 2;
            }
            if (rdbGalaxiaTriangulo.Checked == true)
            {
                Variaveis.Checked1 = 3;
            }
            if (rdbGalaxiaBode.Checked == true)
            {
                Variaveis.Checked1 = 4;
            }
            

        }
    }
}
