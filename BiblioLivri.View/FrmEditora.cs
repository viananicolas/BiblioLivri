﻿using System;
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
    public partial class FrmEditora : Form
    {
        bool inserir = true;
        public FrmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            CEditora.CEditoraClient oProxy = new CEditora.CEditoraClient();
            CEditora.TBEditora oEditora = new CEditora.TBEditora();
            oEditora.EdNome = txtNome.Text;
            oEditora.EdTelefone = txtTelefone.Text;
            oEditora.EdEmail = txtEmail.Text;
            oEditora.EdCidade = txtCidade.Text;
            if (inserir)
            {
                oProxy.Incluir(oEditora);
                MessageBox.Show("Editora cadastrada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                oEditora.id_editora = Convert.ToInt32(txtID.Text);
                oProxy.Alterar(oEditora);
                MessageBox.Show("Editora alterada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            LimpaCampos();
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                var oProxy = new CEditora.CEditoraClient();
                var oEditora = oProxy.SelecionaPK(Convert.ToInt32(txtID.Text));
                oProxy.Excluir(oEditora);
            }
            MessageBox.Show("Editora excluída com sucesso", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserir = true;
            LimpaCampos();
            HabilitaCampos();
            btnNovo.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            //txtID.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
        }

        private void LimpaCampos()
        {
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            inserir = false;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Editar();
            }
        }

        private void Editar()
        {
            if (txtID.Text!="")
            {
                var oProxy = new CEditora.CEditoraClient();
                var oEditora = oProxy.SelecionaPK(Convert.ToInt32(txtID.Text));
                if (oEditora!=null)
                {
                    txtCidade.Text = oEditora.EdCidade;
                    txtEmail.Text = oEditora.EdEmail;
                    txtNome.Text = oEditora.EdNome;
                    txtTelefone.Text = oEditora.EdTelefone;
                    HabilitaCampos();
                    txtID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Editora não cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }

            }
            else
            {
                MessageBox.Show("Informe um número de ID", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            Editar();
        }
    }
}
