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
    public partial class FrmEditora : Form
    {
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
            oProxy.Incluir(oEditora);
        }
    }
}
