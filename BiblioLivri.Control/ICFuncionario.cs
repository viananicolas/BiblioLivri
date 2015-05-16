using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFuncionario" in both code and config file together.
    [ServiceContract]
    public interface ICFuncionario
    {
        [OperationContract]
        void Incluir(TBFuncionario oFuncionario);
        [OperationContract]
        void Alterar(TBFuncionario oFuncionario);
        [OperationContract]
        void Excluir(TBFuncionario oFuncionario);
        [OperationContract]
        TBFuncionario SelecionaPK(int codigo);
        [OperationContract]
        List<TBFuncionario> SelecionaTodos();
        [OperationContract]
        bool ValidaCPF(string CPF);
    }
}
