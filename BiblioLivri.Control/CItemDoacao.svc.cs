using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CItemDoacao" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CItemDoacao.svc or CItemDoacao.svc.cs at the Solution Explorer and start debugging.
    public class CItemDoacao : ICItemDoacao
    {
        public void Incluir(TBItemDoacao oDoacao)
        {
            Model.TBItemDoacao.Incluir(oDoacao);
        }

        public void IncluirTodos(List<TBItemDoacao> oDoacao)
        {
            Model.TBItemDoacao.IncluirTodos(oDoacao);
        }

        public TBItemDoacao SelecionaPK(int codigo)
        {
            return Model.TBItemDoacao.SelecionaPK(codigo);
        }

        public List<TBItemDoacao> SelecionaTodos()
        {
            return Model.TBItemDoacao.SelecionaTodos();
        }

        public List<TBItemDoacao> SelecionaTodosCriterio(int codigo)
        {
            return Model.TBItemDoacao.SelecionaTodosCriterio(codigo);
        }
    }
}
