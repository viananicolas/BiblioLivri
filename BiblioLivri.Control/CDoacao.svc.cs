using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CDoacao" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CDoacao.svc or CDoacao.svc.cs at the Solution Explorer and start debugging.
    public class CDoacao : ICDoacao
    {
        public void Alterar(TBDoacao oDoacao)
        {
            Model.TBDoacao.Alterar(oDoacao);
        }


        public void Excluir(TBDoacao oDoacao)
        {
            Model.TBDoacao.Excluir(oDoacao);
        }

        public List<int> Incluir(TBDoacao oDoacao)
        {
            return Model.TBDoacao.Incluir(oDoacao);
        }

        public TBDoacao SelecionaPK(int codigo)
        {
            return Model.TBDoacao.SelecionaPK(codigo);
        }

        public List<TBDoacao> SelecionaTodos()
        {
            return Model.TBDoacao.SelecionaTodos();
        }

        public List<TBDoacao> SelecionaTodosCriterio(string Criterio, int TipoPesquisa)
        {
            return Model.TBDoacao.SelecionaTodosCriterio(Criterio, TipoPesquisa);
        }
    }
}
