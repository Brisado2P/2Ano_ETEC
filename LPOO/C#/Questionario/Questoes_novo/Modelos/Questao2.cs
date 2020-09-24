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
    public partial class frmQuestao2 : Form
    {
        public frmQuestao2()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao3 frm3 = new frmQuestao3();
            frm3.Show();

            Console.WriteLine(Variaveis.SubTotal);

            if (rdbSol.Checked == true)
            {
                Variaveis.questao2 = 2;
                Variaveis.Checked2 = 2;
            }
            else 
            {
                Variaveis.questao2 = 0;
            }

            if (rdbSirius.Checked == true)
            {
                Variaveis.Checked2 = 1;
            }
            if (rdbAlphaCentauri.Checked == true)
            {
                Variaveis.Checked2 = 3;
            }
            if (rdbActuro .Checked == true)
            {
                Variaveis.Checked2 = 4;
            }
        }

        private void btnCancelarProva_Click(object sender, EventArgs e)
        {
            Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
            Variaveis.SubTotal = 0;
            Variaveis.ValorTotal = 0;
            Variaveis.questao2 = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
            frmQuestao1 frm1 = new frmQuestao1();
            frm1.Show();
            Variaveis.questao1 = 0;

        }
    }
}

