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
    public partial class frmQuestao4 : Form
    {
        public frmQuestao4()
        {
            InitializeComponent();
        }

        private void frmQuestao4_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao3 frm3 = new frmQuestao3();
            frm3.Show();
            Variaveis.questao3 = 0;
        }

        private void btnCancelarProva_Click(object sender, EventArgs e)
        {
            Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            Variaveis.questao4 = 0;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao5 frm5 = new frmQuestao5();
            frm5.Show();

            if (rdbTrezeBilhoes.Checked == true)
            {
                Variaveis.questao4 = 2;
                Variaveis.Checked4 = 3;
            }
            else 
            {
                Variaveis.questao4 = 0;
            }

            if (rdbCincoMilhoes.Checked == true)
            {
                Variaveis.Checked4 = 1;
            }
            if (rdbTrezBilhoes.Checked == true)
            {
                Variaveis.Checked4 = 2;
            }
            if (rdbDezBilhoes.Checked == true)
            {
                Variaveis.Checked4 = 4;
            }
        }
    }
}
