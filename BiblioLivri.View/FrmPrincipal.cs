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
          //  frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void empréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmprestimo frmemprestimo = new FrmEmprestimo();
            //frmemprestimo.MdiParent = this;
            frmemprestimo.Show();
        }

        private void autorDiretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor frmautor = new FrmAutor();
           // frmautor.MdiParent = this;
            frmautor.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro frmlivro = new FrmLivro();
          //  frmlivro.MdiParent = this;
            frmlivro.Show();
        }

        private void editorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora frmeditora = new FrmEditora();
           // frmeditora.MdiParent = this;
            frmeditora.Show();
        }

        private void gênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero frmgenero = new FrmGenero();
           // frmgenero.MdiParent = this;
            frmgenero.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoacao frmdoacao = new FrmDoacao();
          //  frmdoacao.MdiParent = this;
            frmdoacao.Show();
        }

        private void cópiaDeLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcopialivro = new FrmCopiaLivro();
           // frmcopialivro.MdiParent = this;
            frmcopialivro.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmdevolucao = new FrmDevolucao();
           // frmdevolucao.MdiParent = this;
            frmdevolucao.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmconsultaautor = new FrmConsultaAutor();
           // frmconsultaautor.MdiParent = this;
            frmconsultaautor.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmconsultaclientes = new FrmConsultaCliente();
           // frmconsultaclientes.MdiParent = this;
            frmconsultaclientes.Show();
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmconsultalivro = new FrmConsultaLivro();
          //  frmconsultalivro.MdiParent = this;
            frmconsultalivro.Show();
        }

        private void editorasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmconsultaeditora = new FrmConsultaEditora();
          //  frmconsultaeditora.MdiParent = this;
            frmconsultaeditora.Show();
        }

        private void gênerosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmconsultagenero = new FrmConsultaGenero();
          //  frmconsultagenero.MdiParent = this;
            frmconsultagenero.Show();
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmconsultaemprestimo = new FrmConsultaEmprestimo();
           // frmconsultaemprestimo.MdiParent = this;
            frmconsultaemprestimo.Show();
        }

        private void doaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmconsultadoacao = new FrmConsultaDoacao();
         //   frmconsultadoacao.MdiParent = this;
            frmconsultadoacao.Show();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin NewLogin = new FrmLogin();
            DialogResult hey = NewLogin.ShowDialog();
            switch (hey)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK: this.Show();
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
           // frmcliente.MdiParent = this;
            frmcliente.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            FrmLivro frmlivro = new FrmLivro();
            //  frmlivro.MdiParent = this;
            frmlivro.Show();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            var frmcopialivro = new FrmCopiaLivro();
            // frmcopialivro.MdiParent = this;
            frmcopialivro.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            var frmconsultaemprestimo = new FrmConsultaEmprestimo();
            // frmconsultaemprestimo.MdiParent = this;
            frmconsultaemprestimo.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var frmconsultadoacao = new FrmConsultaDoacao();
            //   frmconsultadoacao.MdiParent = this;
            frmconsultadoacao.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var frmconsultaclientes = new FrmConsultaCliente();
            // frmconsultaclientes.MdiParent = this;
            frmconsultaclientes.Show();
        }
    }
}
