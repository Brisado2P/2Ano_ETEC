using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public partial class frmBemVindo1 : Form
    {
        public frmBemVindo1()
        {
            InitializeComponent();
            timer1.Interval = 1500; //Definir o intervalo em 2 segundos
            timer1.Tick += timer_Tick; // Inscrever o evento tick
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmBemVindo bemv = new frmBemVindo();
            bemv.Show();
            timer1.Enabled = false;
        }
    }
}
