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
    public partial class FrmConsultaAutor : Form
    {
        public FrmConsultaAutor()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmConsultaAutor_Load(object sender, EventArgs e)
        {
            var oProxy = new CAutor.CAutorClient();
            dtgAutores.DataSource = oProxy.SelecionaTodos();
            CarregaGrid();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex==3)
            {
                CarregaGrid();
            }
            else
            {
                if(txtPesquisa.Text!="")
                {
                    var oProxy = new CAutor.CAutorClient();
                    dtgAutores.DataSource = oProxy.SelecionaTodosCriterio(txtPesquisa.Text, cmbPesquisa.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Informe um critério de pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
           
        }
    }
}
