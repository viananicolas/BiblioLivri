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
    public partial class FrmAutor : Form
    {
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaPaises();

        }
        private void CarregaGrid()
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
            oProxy.Open();
            CAutor.TBAutor[] testes = oProxy.SelecionaTodos();
            dtgAutores.DataSource = null;
            dtgAutores.DataSource = testes;
            dtgAutores.Refresh();
            oProxy.Close();
        }
        private void CarregaPaises()
        {
            foreach (var item in File.ReadLines(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.View\Information\ListaPaises.txt"))
            {
                cmbNacionalidade.Items.Add(item);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
            CAutor.TBAutor oAutor = new CAutor.TBAutor();
            oAutor.AuSobrenome = txtSobrenome.Text.ToUpper();
            oAutor.AuNome = txtNome.Text;
            oAutor.AuNacionalidade = cmbNacionalidade.SelectedItem.ToString();
            oProxy.Incluir(oAutor);
            LimpaCampos();
            CarregaGrid();
        }
        private void LimpaCampos()
        {
            txtSobrenome.Text = "";
            txtNome.Text = "";
            cmbNacionalidade.SelectedItem = null;
        }
    }
}
