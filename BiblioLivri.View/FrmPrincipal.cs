using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioLivri.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmprestimo frmemprestimo = new FrmEmprestimo();
            frmemprestimo.MdiParent = this;
            frmemprestimo.Show();
        }
    }
}
