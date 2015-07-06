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
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();

        }

        private void CarregaGrid()
        {
            dtgClientes.AutoGenerateColumns = false;
            var oProxy = new CCliente.CClienteClient();
            dtgClientes.DataSource = oProxy.SelecionaTodos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           // CCliente.CClienteClient oProxy = new CCliente.CClienteClient();
          if (cmbCriterio.SelectedIndex == 4)
            {
                CarregaGrid();
            }
            else
            {
                if (txtCriterio.Text != "")
                {
                    var oProxy = new CCliente.CClienteClient();
                    dtgClientes.DataSource = oProxy.SelecionaTodosConsulta(cmbCriterio.SelectedIndex, txtCriterio.Text);
                }
                else
                {
                    MessageBox.Show("Informe um critério de pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
