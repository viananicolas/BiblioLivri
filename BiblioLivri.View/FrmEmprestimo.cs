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
    public partial class FrmEmprestimo : Form
    {
        private string ISBN=null;
        private int NumCartao=0;
        private List<CItemEmprestimo.TBItemEmprestimo> ListaItens = new List<CItemEmprestimo.TBItemEmprestimo>();
        private List<Tuple<int, string>> Testando = new List<Tuple<int, string>>();
        private Tuple<int, string> Books;
        private List<CCopiaLivro.TBCopiaLivro> ListaCopiaLivro;
        private List<CCopiaLivro.TBCopiaLivro> LivrosEscolhidos = new List<CCopiaLivro.TBCopiaLivro>();
        
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            CarregaEmprestimos();
            CarregaItensEmprestimos();
            CarregaClientes();
            CarregaLivros();
            dtpDataDevolucao.Value = DateTime.Now.AddDays(7);
        }

        private void CarregaLivros()
        {
            var oProxy = new CLivro.CLivroClient();
            var aProxy = new CCopiaLivro.CCopiaLivroClient();
            ListaCopiaLivro = aProxy.SelecionaTodos().ToList();
            foreach (var item in oProxy.SelecionaTodos())
            {
                foreach (var item2 in ListaCopiaLivro)
                {
                    if (item.LiISBN == item2.CoISBN)
                    {
                        cmbLivros.Items.Add(item.LiTitulo);
                        Testando.Add(Tuple.Create(item2.CoNumCopia, item.LiTitulo));
                    }
                        
                }

            }
        }

        private void CarregaClientes()
        {
           var oProxy = new CCliente.CClienteClient();

            foreach (var item in oProxy.SelecionaTodos())
            {
                cmbCliente.Items.Add(item.CliNumCartao + " - " + item.CliNome + " " + item.CliSobrenome);
            }
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
        }

        private void cmbLivros_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbLivros.Items != null)
            {
                var oProxy = new CLivro.CLivroClient();
                foreach (var item in oProxy.SelecionaTodos())
                {
                    if (cmbLivros.SelectedItem.ToString() == item.LiTitulo)
                    {
                        ISBN = item.LiISBN;
                    }
                }
            }
          
        }

        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            var oProxy = new CCliente.CClienteClient();
            foreach (var item in oProxy.SelecionaTodos())
            {
                if (cmbCliente.SelectedItem.ToString() == item.CliNumCartao + " - " + item.CliNome + " " + item.CliSobrenome)
                {
                    NumCartao = item.CliNumCartao;
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            lsBLivrosSelecionados.Items.Add(cmbLivros.SelectedItem.ToString());
            var oProxy = new CLivro.CLivroClient();
            var oProxy2 = new CCopiaLivro.CCopiaLivroClient();

            foreach (var item in Testando)
            {
                if (cmbLivros.SelectedItem.ToString() == item.Item2)
                {
                    LivrosEscolhidos.Add(oProxy2.SelecionaPK(item.Item1));
                    break;
                }
            }

        }

        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            var oProxyEmprestimo = new CEmprestimo.CEmprestimoClient();
            var oProxyItemEmprestimo = new CItemEmprestimo.CItemEmprestimoClient();
            var oEmprestimo = new CEmprestimo.TBEmprestimo();
            var oItemEmprestimo = new CItemEmprestimo.TBItemEmprestimo();
            oEmprestimo.EmpDataDevolucao = dtpDataDevolucao.Value;
            oEmprestimo.EmpNumCartao = NumCartao;
            oItemEmprestimo.ItemDataEmprestimo = DateTime.Now;
            var teste = oProxyEmprestimo.Incluir(oEmprestimo).ToList();
            oItemEmprestimo.ItemNumEmprestimo = teste.LastOrDefault();
            foreach (var item in LivrosEscolhidos)
            {
                oItemEmprestimo.ItemNumCopia = item.CoNumCopia;
                ListaItens.Add(oItemEmprestimo);
            }
            oProxyItemEmprestimo.IncluirTodos(ListaItens.ToArray());   
        }
    }
}
