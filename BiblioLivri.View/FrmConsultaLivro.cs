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
        public FrmConsultaLivro()
        {
            InitializeComponent();
        }

        private void FrmConsultaLivro_Load(object sender, EventArgs e)
        {
            CarregaLivros();
        }
        private void CarregaLivros()
        {
            CLivro.CLivroClient oProxy = new CLivro.CLivroClient();
            dtgLivros.DataSource = oProxy.SelecionaTodos();
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
    }
}
