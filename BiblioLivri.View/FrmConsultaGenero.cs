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
    public partial class FrmConsultaGenero : Form
    {
        public FrmConsultaGenero()
        {
            InitializeComponent();
        }

        private void FrmConsultaGenero_Load(object sender, EventArgs e)
        {
            CarregaGeneros();
        }

        private void CarregaGeneros()
        {
            CGenero.CGeneroClient oProxy = new CGenero.CGeneroClient();
            dtgGeneros.DataSource = oProxy.SelecionaTodos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
