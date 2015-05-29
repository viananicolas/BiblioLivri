using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICItemEmprestimo" in both code and config file together.
    [ServiceContract]
    public interface ICItemEmprestimo
    {

        [OperationContract]
        void Incluir(TBItemEmprestimo oItemEmprestimo);

        [OperationContract]
        void IncluirTodos(List<TBItemEmprestimo> oItemEmprestimo);
        [OperationContract]

        TBItemEmprestimo SelecionaPK(int codigo);
        [OperationContract]
        List<TBItemEmprestimo> SelecionaTodos();
        [OperationContract]
        List<TBItemEmprestimo> SelecionaTodosCriterio(int codigo);
    }
}
