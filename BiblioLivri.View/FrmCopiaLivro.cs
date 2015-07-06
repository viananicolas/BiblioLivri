using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioLivri.View
{
    public partial class FrmCopiaLivro : Form
    {
        bool inserir = true;
        private string ISBN;
        public FrmCopiaLivro()
        {
            InitializeComponent();
        }

        private void FrmCopiaLivro_Load(object sender, EventArgs e)
        {
            CarregaLivros();
            CarregaIdiomas();
        }

        private void CarregaLivros()
        {
            var oProxy = new CLivro.CLivroClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbLivro.Items.Add(item.LiTitulo);
            }
        }
        private void CarregaLivros(string codigo)
        {
            var oProxy = new CLivro.CLivroClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbLivro.Items.Add(item.LiTitulo);
                if (item.LiISBN == codigo)
                    cmbLivro.SelectedItem = item.LiTitulo;
            }
        }
        private void CarregaIdiomas()
        {
            foreach (var item in File.ReadLines(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.View\Information\ListaIdioma.txt"))
            {
                cmbIdioma.Items.Add(item);
            }
        }

        private void cmbLivro_SelectedValueChanged(object sender, EventArgs e)
        {
            var oProxy = new CLivro.CLivroClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                if (cmbLivro.SelectedItem.ToString() == item.LiTitulo)
                    ISBN = item.LiISBN;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            var oProxy = new CCopiaLivro.CCopiaLivroClient();
            var oCopiaLivro = new CCopiaLivro.TBCopiaLivro();
            oCopiaLivro.CoAno = txtAno.Text;
            oCopiaLivro.CoEdicao = txtEdicao.Text;
            oCopiaLivro.CoIdioma = cmbIdioma.SelectedItem.ToString();
            oCopiaLivro.CoISBN = ISBN;
            oCopiaLivro.CoEmprestado = chkEmprestado.Checked;
            if (inserir)
            {
                oCopiaLivro.DataAquisicao = DateTime.Now;
                oProxy.IncluirAsync(oCopiaLivro);
                MessageBox.Show("Cópia do livro "+cmbLivro.SelectedItem.ToString()+" inserido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }

            else
            {
                oCopiaLivro.CoNumCopia = Convert.ToInt32(txtNumCopia.Text);
                oProxy.Alterar(oCopiaLivro);
                MessageBox.Show("Cópia do livro " + cmbLivro.SelectedItem.ToString() + " alterada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            LimpaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserir = true;
            HabilitaCampos();
            LimpaCampos();
            txtNumCopia.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtAno.Enabled = true;
            txtEdicao.Enabled = true;
            //chkEmprestado.Enabled = true;
            cmbIdioma.Enabled = true;
            cmbLivro.Enabled = true;
            txtNumCopia.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inserir = false;
            txtNumCopia.Enabled = true;
        }

        private void txtNumCopia_Leave(object sender, EventArgs e)
        {
            Editar();
        }

        private void txtNumCopia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Editar();
            }
        }
        private void LimpaCampos()
        {
            txtAno.Text = "";
            txtEdicao.Text = "";
            txtNumCopia.Text = "";
            cmbIdioma.SelectedText= "";
            cmbLivro.SelectedText = "";
            chkEmprestado.Checked = false;
        }
        private void Editar()
        {
            if (txtNumCopia.Text!="")
            {
                var oProxy = new CCopiaLivro.CCopiaLivroClient();
                var oCopiaLivro = oProxy.SelecionaPK(Convert.ToInt32(txtNumCopia.Text));
                if (oCopiaLivro != null)
                {
                    txtAno.Text = oCopiaLivro.CoAno;
                    txtEdicao.Text = oCopiaLivro.CoEdicao;
                    cmbIdioma.SelectedItem = oCopiaLivro.CoIdioma;
                    cmbLivro.Items.Clear();
                    CarregaLivros(oCopiaLivro.CoISBN);
                    ISBN = oCopiaLivro.CoISBN;
                    chkEmprestado.Checked = oCopiaLivro.CoEmprestado;
                    HabilitaCampos();
                    txtNumCopia.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cópia não consta no acervo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Informe um número de cópia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                var oProxy = new CCopiaLivro.CCopiaLivroClient();

                var oCopiaLivro = oProxy.SelecionaPK(Convert.ToInt32(txtNumCopia.Text));
                oProxy.Excluir(oCopiaLivro);
            }
            MessageBox.Show("Cópia excluída com sucesso", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }
    }
}
