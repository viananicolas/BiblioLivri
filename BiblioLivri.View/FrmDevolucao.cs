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
    public partial class FrmDevolucao : Form
    {
        private List<CCopiaLivro.TBCopiaLivro> Livros = new List<CCopiaLivro.TBCopiaLivro>();
        public FrmDevolucao()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var oProxy = new CCopiaLivro.CCopiaLivroClient();
            var aProxy = new CLivro.CLivroClient();
            var oCopiaLivro = oProxy.SelecionaPK(Convert.ToInt32(txtCopiaLivro.Text));
            Livros.Add(oCopiaLivro);
            var aLivro = aProxy.SelecionaPK(oCopiaLivro.CoISBN);
            if(oCopiaLivro.CoEmprestado)
            {
                lstLivros.Items.Add(oCopiaLivro.CoNumCopia.ToString() +" - " + aLivro.LiTitulo);
            }
            else
            {
                MessageBox.Show("O livro não está emprestado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            using (var oProxy = new CCopiaLivro.CCopiaLivroClient())
            {
                foreach (var item in Livros)
                {
                    item.CoEmprestado = false; 
                    oProxy.Alterar(item);
                }
            }
            MessageBox.Show("Os livros foram devolvidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            lstLivros.Items.Clear();
            txtCopiaLivro.Text = "";
        }

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
