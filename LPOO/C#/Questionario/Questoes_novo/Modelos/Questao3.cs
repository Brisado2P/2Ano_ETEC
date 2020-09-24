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
    public partial class frmQuestao3 : Form
    {
        public frmQuestao3()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao2 frm2 = new frmQuestao2();
            frm2.Show();
            Variaveis.questao2 = 0;
        }

        private void btnCancelarProva_Click(object sender, EventArgs e)
        {
            Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            Variaveis.SubTotal = 0;
            Variaveis.ValorTotal = 0;
            Variaveis.questao3 = 0;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao4 frm4 = new frmQuestao4();
            frm4.Show();

            if (rdbEclipse.Checked == true)
            {
                Variaveis.questao3 = 2;
                Variaveis.Checked3 = 3;
            }
            else 
            {
                Variaveis.questao3 = 0;
            }

            if (rdbChuvaDeMeteoros.Checked == true)
            {
                Variaveis.Checked3 = 1;
            }
            if (rdbErupçãoRaioGama.Checked == true)
            {
                Variaveis.Checked3 = 2;
            }
            if (rdbSuperLua.Checked == true)
            {
                Variaveis.Checked3 = 4;
            }
        }
    }
}
