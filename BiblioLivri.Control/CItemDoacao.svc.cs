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
            throw new NotImplementedException();
        }

        public void IncluirTodos(List<TBItemDoacao> oDoacao)
        {
            throw new NotImplementedException();
        }

        public TBItemDoacao SelecionaPK(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<TBItemDoacao> SelecionaTodos()
        {
            throw new NotImplementedException();
        }

        public List<TBItemDoacao> SelecionaTodosCriterio(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
