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
        bool Incluir = true;
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaPaises();

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
            if (Incluir)
            {
                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                CAutor.TBAutor oAutor = new CAutor.TBAutor();
                oAutor.AuSobrenome = txtSobrenome.Text.ToUpper();
                oAutor.AuNome = txtNome.Text;
                oAutor.AuNacionalidade = cmbNacionalidade.SelectedItem.ToString();
                oProxy.Incluir(oAutor);
                MessageBox.Show("Autor inserido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            else
            {
                CAutor.CAutorClient oProxy = new CAutor.CAutorClient();
                CAutor.TBAutor oAutor = new CAutor.TBAutor();
                oAutor.id_autor = Convert.ToInt32(txtID.Text);
                oAutor.AuSobrenome = txtSobrenome.Text.ToUpper();
                oAutor.AuNome = txtNome.Text;
                oAutor.AuNacionalidade = cmbNacionalidade.SelectedItem.ToString();
                oProxy.Alterar(oAutor);
                MessageBox.Show("Autor alterado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            LimpaCampos();
            DesabilitaCampos();
            btnNovo.Enabled = true;
        }

        private void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            cmbNacionalidade.Enabled = false;
        }

        private void LimpaCampos()
        {
            txtSobrenome.Text = "";
            txtNome.Text = "";
            cmbNacionalidade.SelectedItem = null;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Incluir = true;
            LimpaCampos();
            HabilitaCampos();
            btnNovo.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            cmbNacionalidade.Enabled = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            var oProxy = new CAutor.CAutorClient();
            var oAutor = oProxy.SelecionaPK(Convert.ToInt32(txtID.Text));
            txtNome.Text = oAutor.AuNome;
            txtSobrenome.Text = oAutor.AuSobrenome;
            txtID.Enabled = false;
            cmbNacionalidade.SelectedItem = oAutor.AuNacionalidade.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Incluir = false;
            txtID.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            LimpaCampos();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
