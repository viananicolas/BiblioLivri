using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICLivro" in both code and config file together.
    [ServiceContract]
    public interface ICLivro
    {
        [OperationContract]
        void Incluir(TBLivro oLivro);
        [OperationContract]
        void Alterar(TBLivro oLivro);
        [OperationContract]
        void Excluir(TBLivro oLivro);
        [OperationContract]
        TBLivro SelecionaPK(string codigo);
        [OperationContract]
        List<TBLivro> SelecionaTodos();
        [OperationContract]
        bool ValidaISBN(string ISBN);
    }
}
