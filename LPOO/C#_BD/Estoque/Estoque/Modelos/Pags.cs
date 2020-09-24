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
    public partial class Pags : Form
    {
        public Pags()
        {
            InitializeComponent();
        }

        private void btnSair_Deslogar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente Deslogar?","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
                frmBemVindo home = new frmBemVindo();
                home.Show();
            }         
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRelatorio rel = new frmRelatorio();
            rel.Show();
        }

        private void pcbClientes_MouseHover(object sender, EventArgs e)
        {
            pcbClientes.BackColor = Color.DarkSlateBlue;
        }

        private void pcbClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            frmClientes clie = new frmClientes();
            clie.Show();
        }

        private void llblCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmClientes clie = new frmClientes();
            clie.Show();
        }

        private void llblVendedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmVendedor_com vend = new frmVendedor_com();
            vend.Show();
        }

        private void pcbVendedores_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVendedor_com vend = new frmVendedor_com();
            vend.Show();
        }

        private void llblEstoque_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmEstoque esto = new frmEstoque();
            esto.Show();
        }

        private void pcbEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEstoque esto = new frmEstoque();
            esto.Show();
        }

        private void llblProduto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmProdutos prod = new frmProdutos();
            prod.Show();
        }

        private void pcbProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProdutos prod = new frmProdutos();
            prod.Show();
        }

        private void llblRelatorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmRelatorio rel = new frmRelatorio();
            rel.Show();
        }

        private void llblPedido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            frmPedidos pedi = new frmPedidos();
            pedi.Show();
        }

        private void pcbPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPedidos pedi = new frmPedidos();
            pedi.Show();
        }

        public LinkBehavior Underline { get; set; }

        //Cliente

        private void pcbClientes_MouseLeave(object sender, EventArgs e)
        {
            llblCliente.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            pcbClientes.BackColor = Color.Indigo;
            llblCliente.BackColor = Color.Indigo;
        }

        private void pcbClientes_MouseHover_1(object sender, EventArgs e)
        {
            llblCliente.LinkBehavior = Underline;
            pcbClientes.BackColor = Color.MediumVioletRed;
            llblCliente.BackColor = Color.MediumVioletRed;
        }

        private void llblCliente_MouseHover(object sender, EventArgs e)
        {
            llblCliente.BackColor = Color.MediumVioletRed;
            pcbClientes.BackColor = Color.MediumVioletRed;
        }

        private void llblCliente_MouseLeave(object sender, EventArgs e)
        {
            llblCliente.BackColor = Color.Indigo;
            pcbClientes.BackColor = Color.Indigo;
        }

        //Estoque

        private void pcbEstoque_MouseHover(object sender, EventArgs e)
        {
            llblEstoque.LinkBehavior = Underline;
            llblEstoque.BackColor = Color.MediumVioletRed;
            pcbEstoque.BackColor = Color.MediumVioletRed;
        }

        private void pcbEstoque_MouseLeave(object sender, EventArgs e)
        {
            llblEstoque.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            pcbEstoque.BackColor = Color.DarkOrchid;
            llblEstoque.BackColor = Color.DarkOrchid;
        }
        private void llblEstoque_MouseHover(object sender, EventArgs e)
        {
            llblEstoque.BackColor = Color.MediumVioletRed;
            pcbEstoque.BackColor = Color.MediumVioletRed;
        }

        private void llblEstoque_MouseLeave(object sender, EventArgs e)
        {
            pcbEstoque.BackColor = Color.DarkOrchid;
            llblEstoque.BackColor = Color.DarkOrchid;
        }

        //Pedido

        private void pcbPedidos_MouseHover(object sender, EventArgs e)
        {
            llblPedido.LinkBehavior = Underline;
            llblPedido.BackColor = Color.MediumVioletRed;
            pcbPedidos.BackColor = Color.MediumVioletRed;
        }

        private void pcbPedidos_MouseLeave(object sender, EventArgs e)
        {
            llblPedido.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            llblPedido.BackColor = Color.MediumSlateBlue;
            pcbPedidos.BackColor = Color.MediumSlateBlue;
        }
        private void llblPedido_MouseHover(object sender, EventArgs e)
        {
            llblPedido.BackColor = Color.MediumVioletRed;
            pcbPedidos.BackColor = Color.MediumVioletRed;
        }

        private void llblPedido_MouseLeave(object sender, EventArgs e)
        {
            llblPedido.BackColor = Color.MediumSlateBlue;
            pcbPedidos.BackColor = Color.MediumSlateBlue;
        }

        //Vendedores

        private void pcbVendedores_MouseHover(object sender, EventArgs e)
        {
            llblVendedor.LinkBehavior = Underline;
            llblVendedor.BackColor = Color.MediumVioletRed;
            pcbVendedores.BackColor = Color.MediumVioletRed;
        }

        private void pcbVendedores_MouseLeave(object sender, EventArgs e)
        {
            llblVendedor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            llblVendedor.BackColor = Color.MediumOrchid;
            pcbVendedores.BackColor = Color.MediumOrchid;
        }
        private void llblVendedor_MouseHover(object sender, EventArgs e)
        {
            llblVendedor.BackColor = Color.MediumVioletRed;
            pcbVendedores.BackColor = Color.MediumVioletRed;
        }

        private void llblVendedor_MouseLeave(object sender, EventArgs e)
        {
            llblVendedor.BackColor = Color.MediumOrchid;
            pcbVendedores.BackColor = Color.MediumOrchid;
        }

        //Produtos

        private void pcbProdutos_MouseHover(object sender, EventArgs e)
        {
            llblProduto.LinkBehavior = Underline;
            llblProduto.BackColor = Color.MediumVioletRed;
            pcbProdutos.BackColor = Color.MediumVioletRed;
        }

        private void pcbProdutos_MouseLeave(object sender, EventArgs e)
        {
            llblProduto.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            llblProduto.BackColor = Color.DarkMagenta;
            pcbProdutos.BackColor = Color.DarkMagenta;
        }
        private void llblProduto_MouseHover(object sender, EventArgs e)
        {
            llblProduto.BackColor = Color.MediumVioletRed;
            pcbProdutos.BackColor = Color.MediumVioletRed;
        }

        private void llblProduto_MouseLeave(object sender, EventArgs e)
        {
            llblProduto.BackColor = Color.DarkMagenta;
            pcbProdutos.BackColor = Color.DarkMagenta;
        }

        //Relatorios

        private void pcbRelatorios_MouseHover(object sender, EventArgs e)
        {
            llblRelatorio.LinkBehavior = Underline;
            llblRelatorio.BackColor = Color.MediumVioletRed;
            pcbRelatorios.BackColor = Color.MediumVioletRed;
        }

        private void pcbRelatorios_MouseLeave(object sender, EventArgs e)
        {
            llblRelatorio.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            llblRelatorio.BackColor = Color.DarkSlateBlue;
            pcbRelatorios.BackColor = Color.DarkSlateBlue;
        }

        private void llblRelatorio_MouseHover(object sender, EventArgs e)
        {
            llblRelatorio.BackColor = Color.MediumVioletRed;
            pcbRelatorios.BackColor = Color.MediumVioletRed;
        }

        private void llblRelatorio_MouseLeave(object sender, EventArgs e)
        {
            llblRelatorio.BackColor = Color.DarkSlateBlue;
            pcbRelatorios.BackColor = Color.DarkSlateBlue;
        }
    }
}
