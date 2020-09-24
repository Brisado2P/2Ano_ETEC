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

        private void btnProximo4_Click(object sender, EventArgs e)
        {
            Hide();
            frmQuestao5 frm5 = new frmQuestao5();
            frm5.Show();
        }

        private void btnVoltar3_Click(object sender, EventArgs e)
        {
            Hide();
            frmQuestao3 frm3 = new frmQuestao3();
            frm3.Show();
        }
    }
}
