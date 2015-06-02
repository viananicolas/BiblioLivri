using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;
namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICEmprestimo" in both code and config file together.
    [ServiceContract]
    public interface ICEmprestimo
    {
        [OperationContract]
        List<int> Incluir(TBEmprestimo oEmprestimo);
        [OperationContract]
        void Alterar(TBEmprestimo oEmprestimo);
        [OperationContract]
        void Excluir(TBEmprestimo oEmprestimo);
        [OperationContract]
        TBEmprestimo SelecionaPK(int codigo);
        [OperationContract]
        List<TBEmprestimo> SelecionaTodos();
        [OperationContract]
        List<TBEmprestimo> SelecionaTodosCriterio(string Criterio, int TipoPesquisa);
    }
}
