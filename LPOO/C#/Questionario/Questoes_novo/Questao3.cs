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

        private void btnProximo3_Click(object sender, EventArgs e)
        {
            Hide();
            frmQuestao4 frm4 = new frmQuestao4();
            frm4.Show();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            Hide();
            frmQuestao2 frm2 = new frmQuestao2();
            frm2.Show();
        }
    }
}
