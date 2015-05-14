using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICCliente" in both code and config file together.
    [ServiceContract]
    public interface ICCliente
    {
        [OperationContract]
        void Incluir(TBCliente oCliente);
        [OperationContract]
        void Alterar(TBCliente oCliente);
        [OperationContract]
        void Excluir(TBCliente oCliente);
        [OperationContract]
        TBCliente SelecionaPK(int codigo);
        [OperationContract]
        List<TBCliente> SelecionaTodos();
        [OperationContract]
        bool ValidaCPF(string CPF);
    }
}
