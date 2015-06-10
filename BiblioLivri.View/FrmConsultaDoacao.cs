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
    public partial class FrmConsultaDoacao : Form
    {
        public FrmConsultaDoacao()
        {
            InitializeComponent();
        }

        private void FrmConsultaDoacao_Load(object sender, EventArgs e)
        {

        }
        private void CarregaItensDoacao()
        {
            var oProxy = new CItemDoacao.CItemDoacaoClient();
            dtgItensDoados.DataSource = oProxy.SelecionaTodos();
        }
        /*  private void CarregaItensDoacao(int codigo)
          {
              var oProxy = new CItemEmprestimo.CItemEmprestimoClient();
              dtgItensEmprestimos.DataSource = oProxy.SelecionaTodos();
          }*/

        private void CarregaDoacoes()
        {
            var oProxy = new CDoacao.CDoacaoClient();
            dtgDoacoes.DataSource = oProxy.SelecionaTodos();
            dtgDoacoes.ClearSelection();
        }
    }
}
