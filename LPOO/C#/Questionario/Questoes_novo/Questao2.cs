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

        private void btnProximo2_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo2_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmQuestao3 frm3 = new frmQuestao3();
            frm3.Show();
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            Hide();
            frmQuestao1 frm1 = new frmQuestao1();
            frm1.Show();
        }
    }
}
