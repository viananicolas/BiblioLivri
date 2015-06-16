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
    public partial class FrmConsultaLivro : Form
    {
        // private List<CGenero.CGeneroClient> Generos = new List<CGenero.CGeneroClient>();
        private List<string> GeneroDes = new List<string>();
        private List<string> Autours = new List<string>();
       
        public FrmConsultaLivro()
        {
            InitializeComponent();
            dtgLivros.AutoGenerateColumns = false;
        }

        private void FrmConsultaLivro_Load(object sender, EventArgs e)
        {
            CarregaLivros();
        }
        private void CarregaLivros()
        {
            CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
            var oLivros = oProxy.SelecionaTodos().ToList();
           
            dtgLivros.DataSource = oLivros;
           /* var Livros = new DataTable();
            Livros.Columns.AddRange(new DataColumn[] {
            new DataColumn("LiTitulo", typeof(string)),
            new DataColumn("LiISBN", typeof(string)),
            new DataColumn("LiCDU", typeof(string)),
            new DataColumn("LiPais", typeof(string)),
            new DataColumn("LiAutor", typeof(string)),
            });8*/
           // dtgLivros.DataSource = 
        }

        private void dtgLivros_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgLivros.SelectedRows.Count > 0)
            {
                var oLivro = dtgLivros.SelectedRows[0].DataBoundItem as CLivro.TBLivro;
                var oProxy = new CCopiaLivro.CCopiaLivroClient();
              dtgCopiaLivro.DataSource = oProxy.SelecionaTodosCriterio(oLivro.LiISBN);
                dtgCopiaLivro.Refresh();
            }
        }

        private void dtgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex == 3)
            {
                CarregaLivros();
            }
            else
            {
                if (txtPesquisa.Text != "")
                {
                    var oProxy = new CLivro.CLivroClient();
                    dtgLivros.DataSource = oProxy.SelecionaTodosCriterio(txtPesquisa.Text, cmbPesquisa.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Informe um critério de pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
