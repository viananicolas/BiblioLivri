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

        private void autorDiretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor frmautor = new FrmAutor();
            frmautor.MdiParent = this;
            frmautor.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro frmlivro = new FrmLivro();
            frmlivro.MdiParent = this;
            frmlivro.Show();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora frmeditora = new FrmEditora();
            frmeditora.MdiParent = this;
            frmeditora.Show();
        }

        private void gênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero frmgenero = new FrmGenero();
            frmgenero.MdiParent = this;
            frmgenero.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cópiaDeLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcopialivro = new FrmCopiaLivro();
            frmcopialivro.MdiParent = this;
            frmcopialivro.Show();
        }
    }
}
