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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text=="admin" && txtUsuario.Text=="admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();  
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            /*if (sender != null)
            {

                if (string.Equals((sender as Button).Name, @"CloseButton"))
                    Application.Exit();
                else
                    e.Cancel = true;
            }*/
           

        }
    }
}
