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
    public partial class frmQuestao5 : Form
    {
        public frmQuestao5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar4_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao4 frm4 = new frmQuestao4();
            frm4.Show();
            Variaveis.questao4 = 0;
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (rdbOitoPlanetas.Checked == true)
            {
                Variaveis.questao5 = 2;
                Variaveis.Checked5 = 3;
            }
            else
            {
                Variaveis.questao5 = 0;
            }

            if (rdbCincoPlanetas.Checked == true)
            {
                Variaveis.Checked5 = 1;
            }
            if (rdbSetePlanetas.Checked == true)
            {
                Variaveis.Checked5 = 2;
            }
            if (rdbTrezePlanetas.Checked == true)
            {
                Variaveis.Checked5 = 4;
            }
            Close();
            frmResultado frm6 = new frmResultado();
            frm6.Show();
        }
    }
}
