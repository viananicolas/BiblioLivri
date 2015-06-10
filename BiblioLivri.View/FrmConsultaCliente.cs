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
            var oProxy = new CCliente.CClienteClient();
            dtgClientes.DataSource = oProxy.SelecionaTodos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CCliente.CClienteClient oProxy = new CCliente.CClienteClient();
            oProxy.Open();
            switch (cmbCriterio.SelectedIndex)
            {
                case (0): dtgClientes.DataSource = oProxy.SelecionaTodosConsulta(1, txtCriterio.Text); dtgClientes.Refresh(); break;
                case (1): dtgClientes.DataSource = oProxy.SelecionaTodosConsulta(2, txtCriterio.Text); dtgClientes.Refresh(); break;
                case (2): dtgClientes.DataSource = oProxy.SelecionaTodosConsulta(0, txtCriterio.Text); dtgClientes.Refresh(); break;
                case (3): dtgClientes.DataSource = oProxy.SelecionaTodosConsulta(3, txtCriterio.Text); dtgClientes.Refresh(); break;
                case (4): dtgClientes.DataSource = oProxy.SelecionaTodos(); dtgClientes.Refresh(); break;
                default: MessageBox.Show("Selecione um critério de pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); break;

            }
            oProxy.Close();
        }
    }
}
