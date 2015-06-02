using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICDoacao" in both code and config file together.
    [ServiceContract]
    public interface ICDoacao
    {
        [OperationContract]
        List<int> Incluir(TBDoacao oDoacao);
        [OperationContract]
        void Alterar(TBDoacao oDoacao);
        [OperationContract]
        void Excluir(TBDoacao oDoacao);
        [OperationContract]
        TBDoacao SelecionaPK(int codigo);
        [OperationContract]
        List<TBDoacao> SelecionaTodos();
        [OperationContract]
        List<TBDoacao> SelecionaTodosCriterio(string Criterio, int TipoPesquisa);
    }
}
