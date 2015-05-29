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
        private string ISBN;
        public FrmCopiaLivro()
        {
            InitializeComponent();
        }

        private void FrmCopiaLivro_Load(object sender, EventArgs e)
        {
            CarregaLivros();
            CarregaIdiomas();
            CarregaCopiaLivros();
        }

        private void CarregaCopiaLivros()
        {
            var oProxy = new CCopiaLivro.CCopiaLivroClient();
            dtgCopiaLivro.DataSource = oProxy.SelecionaTodos();
        }

        private void CarregaLivros()
        {
            var oProxy = new CLivro.CLivroClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbLivro.Items.Add(item.LiTitulo);
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
            oCopiaLivro.DataAquisicao = DateTime.Now;
            oCopiaLivro.CoEmprestado = chkEmprestado.Checked;
            oProxy.IncluirAsync(oCopiaLivro);
            CarregaCopiaLivros();
        }
    }
}
