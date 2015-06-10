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
    public partial class FrmDoacao : Form
    {
        private string ISBN = null;
        private int NumCartao = 0;
        private List<CItemDoacao.TBItemDoacao> ListaItens = new List<CItemDoacao.TBItemDoacao>();
        private List<Tuple<int, string>> Testando = new List<Tuple<int, string>>();
        private List<CCopiaLivro.TBCopiaLivro> ListaCopiaLivro;
        private List<CCopiaLivro.TBCopiaLivro> LivrosEscolhidos = new List<CCopiaLivro.TBCopiaLivro>();
        public FrmDoacao()
        {
            InitializeComponent();
        }

        private void FrmDoacao_Load(object sender, EventArgs e)
        {

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

      /*  private void CarregaItensDoacao()
        {
            var oProxy = new CItemDoacao.CItemDoacaoClient();
            dtgItensDoados.DataSource = oProxy.SelecionaTodos();
        }*/
      /*  private void CarregaItensDoacao(int codigo)
        {
            var oProxy = new CItemEmprestimo.CItemEmprestimoClient();
            dtgItensEmprestimos.DataSource = oProxy.SelecionaTodos();
        }*/

       /* private void CarregaDoacoes()
        {
            var oProxy = new CDoacao.CDoacaoClient();
            dtgDoacoes.DataSource = oProxy.SelecionaTodos();
            dtgDoacoes.ClearSelection();
        }*/

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

        private void btnDoar_Click(object sender, EventArgs e)
        {
            var oProxyDoacao = new CDoacao.CDoacaoClient();
            var oProxyItemDoacao = new CItemDoacao.CItemDoacaoClient();
            var oDoacao = new CDoacao.TBDoacao();
            var oItemDoacao = new CItemDoacao.TBItemDoacao();
            oDoacao.DoNumClienteDoador = NumCartao;
            oItemDoacao.ItemDataDoacao = DateTime.Now;
            var teste = oProxyDoacao.Incluir(oDoacao).ToList();
            oItemDoacao.ItemNumDoacao = teste.LastOrDefault();
            foreach (var item in LivrosEscolhidos)
            {
                oItemDoacao.ItemNumCopia = item.CoNumCopia;
                ListaItens.Add(oItemDoacao);
                oProxyItemDoacao.Incluir(oItemDoacao);
            }
        }
    }
}

