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
            CarregaDoacoes();
        }
        private void CarregaItensDoacao()
        {
            dtgItensDoados.AutoGenerateColumns = false;
            var oProxy = new CItemDoacao.CItemDoacaoClient();
            dtgItensDoados.DataSource = oProxy.SelecionaTodos();
        }
       

        private void CarregaDoacoes()
        {
            dtgDoacoes.AutoGenerateColumns = false;
            var oProxy = new CDoacao.CDoacaoClient();
            dtgDoacoes.DataSource = oProxy.SelecionaTodos();
            dtgDoacoes.ClearSelection();
        }

        private void dtgDoacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgDoacoes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dtgDoacoes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDoacoes.SelectedRows.Count > 0)
            {
                var oItemDoacao = dtgDoacoes.SelectedRows[0].DataBoundItem as CDoacao.TBDoacao;
                if (oItemDoacao != null)
                {
                    var oProxy = new CItemDoacao.CItemDoacaoClient();
                    dtgItensDoados.DataSource = oProxy.SelecionaTodosCriterio(oItemDoacao.DoNumDoacao);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbPesquisa.SelectedIndex==3)
            {
                CarregaDoacoes();
            }
            else
            {
                if (txtPesquisa.Text!="")
                {
                    var oProxy = new CDoacao.CDoacaoClient();
                    dtgDoacoes.DataSource = oProxy.SelecionaTodosCriterio(txtPesquisa.Text, cmbPesquisa.SelectedIndex);
                }
            }
        }
    }
}
