using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICGenero" in both code and config file together.
    [ServiceContract]
    public interface ICGenero
    {
        [OperationContract]
        void Incluir(TBGenero oGenero);
        [OperationContract]
        void Alterar(TBGenero oGenero);
        [OperationContract]
        void Excluir(TBGenero oGenero);
        [OperationContract]
        TBGenero SelecionaPK(int codigo);
        [OperationContract]
        List<TBGenero> SelecionaTodos();
    }
}
