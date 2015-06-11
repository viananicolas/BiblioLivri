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
    public partial class FrmCliente : Form
    {
     private bool IsInsercao=true;
        public FrmCliente()
        {
            InitializeComponent();
           
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
          
            CarregaPaises();
            CarregaEstados();
           
        }

        private void CarregaEstados()
        {
            foreach (var item in File.ReadLines(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.View\Information\ListaEstado.txt"))
            {
                cmbEstado.Items.Add(item);
            }
        }

        private void CarregaPaises()
         {
            foreach (var item in File.ReadLines(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.View\Information\ListaPaises.txt"))
             {
                 cmbPais.Items.Add(item);
             }
         }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
                {
                CCliente.CClienteClient oProxy = new CCliente.CClienteClient();
                CCliente.TBCliente oCliente = new CCliente.TBCliente();
                oCliente.CliCelular = txtCelular.Text.Trim();
                oCliente.CliCEP = txtCEP.Text.Trim();
                oCliente.CliCidade = txtCidade.Text;
                oCliente.CliEndereco = txtEndereco.Text;
                oCliente.CliCPF = txtCPF.Text.Trim();
                oCliente.CliEstado = cmbEstado.SelectedItem.ToString();
                oCliente.CliPais = cmbPais.SelectedItem.ToString();
                oCliente.CliEmail = txtEmail.Text.Trim();
                oCliente.CliNome = txtNome.Text;
                oCliente.CliSobrenome = txtSobrenome.Text.Trim();
                oCliente.CliTelefone = txtTelefone.Text.Trim();
                if (IsInsercao)
                {
                    //if (oProxy.ValidaCPF(txtCPF.Text) == false)
                    //{
                    //    MessageBox.Show("CPF já consta no Banco de Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    //}
                    //else
                   // {
                        oProxy.Incluir(oCliente);
                        MessageBox.Show("Cliente inserido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    //}
                }
                else
                {
                    oCliente.CliNumCartao = Convert.ToInt32(txtID.Text);
                    oProxy.Alterar(oCliente);
                    MessageBox.Show("Cliente alterado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                }
                LimpaCampos();
               

            }
           
        }
        public void LimpaCampos()
        {
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtTelefone.Text = "";
            cmbEstado.SelectedValue = null;
            cmbPais.SelectedValue = null;   
        }
        public bool ValidaCampos()
        {
            var oProxy = new CCliente.CClienteClient();
           if (oProxy.ValidaCPF(txtCPF.Text)==false)
            {
                MessageBox.Show("CPF já consta no Banco de Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            
            if (txtCelular.Text=="")
            {
                MessageBox.Show("O Campo Celular é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtCEP.Text == "")
            {
                MessageBox.Show("O Campo CEP é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("O Campo Cidade é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtCPF.Text == "")
            {
                MessageBox.Show("O Campo CPF é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("O Campo Email é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("O Campo Nome é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtSobrenome.Text == "")
            {
                MessageBox.Show("O Campo Sobrenome é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtTelefone.Text == "")
            {
                MessageBox.Show("O Campo Telefone é de preenchimento obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }

            return true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       /* private void Editar()
        {
            IsInsercao = false;
            if (dtgClientes.SelectedRows.Count > 0)
            {
                CCliente.TBCliente oCliente = dtgClientes.SelectedRows[0].DataBoundItem as CCliente.TBCliente;
                txtCelular.Text = oCliente.CliCelular;

                txtID.Text = oCliente.CliNumCartao.ToString();
                txtCEP.Text = oCliente.CliCEP;
                txtCidade.Text = oCliente.CliCidade;
                txtCPF.Text = oCliente.CliCPF;
                txtEmail.Text = oCliente.CliEmail;
                txtNome.Text = oCliente.CliNome;
                txtSobrenome.Text = oCliente.CliSobrenome;
                txtTelefone.Text = oCliente.CliTelefone;
                cmbEstado.SelectedItem = oCliente.CliEstado;
                cmbPais.SelectedItem = oCliente.CliPais;
            }
        }*/

        private void btnExcluir_Click(object sender, EventArgs e)
        {
          
        }

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsInsercao = true;
            HabilitaCampos();
            txtID.Enabled = false;
            LimpaCampos();
        }

        private void HabilitaCampos()
        {
            txtCelular.Enabled = true;
            txtCEP.Enabled = true;
            txtCidade.Enabled = true;
            txtCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtTelefone.Enabled = true;
            cmbEstado.Enabled = true;
            cmbPais.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsInsercao = false;
            txtID.Enabled = true;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            var oProxy = new CCliente.CClienteClient();
            var oCliente = oProxy.SelecionaPK(Convert.ToInt32(txtID.Text));
            txtCelular.Text = oCliente.CliCelular;
            txtCEP.Text = oCliente.CliCEP;
            txtCidade.Text = oCliente.CliCidade;
            txtCPF.Text = oCliente.CliCPF;
            txtEmail.Text = oCliente.CliEmail;
            txtNome.Text = oCliente.CliNome;
            txtSobrenome.Text = oCliente.CliSobrenome;
            txtTelefone.Text = oCliente.CliTelefone;
            txtEndereco.Text = oCliente.CliEndereco;
            cmbEstado.SelectedItem = oCliente.CliEstado;
            cmbPais.SelectedItem = oCliente.CliPais;
            HabilitaCampos();
            txtID.Enabled = false;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Editar();
            }
        }
    }
}
