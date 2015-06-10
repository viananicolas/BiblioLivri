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
    public partial class FrmConsultaEmprestimo : Form
    {
        public FrmConsultaEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmConsultaEmprestimo_Load(object sender, EventArgs e)
        {
            CarregaEmprestimos();
            CarregaItensEmprestimos();
        }
        private void CarregaItensEmprestimos()
        {
            var oProxy = new CItemEmprestimo.CItemEmprestimoClient();
            dtgItensEmprestimos.DataSource = oProxy.SelecionaTodos();
        }
        private void CarregaItensEmprestimos(int codigo)
        {
            var oProxy = new CItemEmprestimo.CItemEmprestimoClient();
            dtgItensEmprestimos.DataSource = oProxy.SelecionaTodos();
        }

        private void CarregaEmprestimos()
        {
            var oProxy = new CEmprestimo.CEmprestimoClient();
            dtgEmprestimos.DataSource = oProxy.SelecionaTodos();
            dtgEmprestimos.ClearSelection();
        }

        private void dtgEmprestimos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgEmprestimos.SelectedRows.Count > 0)
            {
                var oItemEmprestimo = dtgEmprestimos.SelectedRows[0].DataBoundItem as CEmprestimo.TBEmprestimo;
                if (oItemEmprestimo != null)
                {
                    var oProxy = new CItemEmprestimo.CItemEmprestimoClient();
                    dtgItensEmprestimos.DataSource = oProxy.SelecionaTodosCriterio(oItemEmprestimo.EmpNumEmprestimo);
                }
            }

        }
    }
}
