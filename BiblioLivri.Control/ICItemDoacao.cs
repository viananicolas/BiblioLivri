using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICItemDoacao" in both code and config file together.
    [ServiceContract]
    public interface ICItemDoacao
    {
        [OperationContract]
        void Incluir(TBItemDoacao oDoacao);

        [OperationContract]
        void IncluirTodos(List<TBItemDoacao> oDoacao);
        [OperationContract]

        TBItemDoacao SelecionaPK(int codigo);
        [OperationContract]
        List<TBItemDoacao> SelecionaTodos();
        [OperationContract]
        List<TBItemDoacao> SelecionaTodosCriterio(int codigo);
    }
}
