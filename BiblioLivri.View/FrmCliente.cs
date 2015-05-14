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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
                {
                CCliente.CClienteClient oProxy = new CCliente.CClienteClient();
                CCliente.TBCliente oCliente = new CCliente.TBCliente();
                oCliente.CliCelular = txtCelular.Text.Trim();
                // oCliente.id_cliente = Convert.ToInt32(txtID.Text.Trim());
                oCliente.CliCEP = txtCEP.Text.Trim();
                oCliente.CliCidade = txtCidade.Text;
                oCliente.CliComplemento = txtComplemento.Text.Trim();
                oCliente.CliCPF = txtCPF.Text.Trim();
                oCliente.CliEmail = txtEmail.Text.Trim();
                oCliente.CliEstado = cmbEstado.SelectedItem.ToString();
                oCliente.CliNome = txtNome.Text;
                oCliente.CliNumero = txtNumero.Text.Trim();
                oCliente.CliPais = cmbPais.SelectedItem.ToString();
                oCliente.CliSobrenome = txtSobrenome.Text.Trim();
                oCliente.CliTelefone = txtTelefone.Text.Trim();
                oProxy.Incluir(oCliente);
                MessageBox.Show("Cliente inserido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                LimpaCampos();
            }
           
        }
        public void LimpaCampos()
        {
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtSobrenome.Text = "";
            txtTelefone.Text = "";
            cmbEstado.SelectedValue = null;
            cmbPais.SelectedValue = null;   
        }
        public bool ValidaCampos()
        {
            CCliente.CClienteClient oProxy = new CCliente.CClienteClient();
           // var ValidacaoCPF = oProxy.ValidaCPFAsync(txtCPF.Text);
           if (oProxy.ValidaCPF(txtCPF.Text)==false)
            {
                MessageBox.Show("CPF já consta no Banco de Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }
    }
}
