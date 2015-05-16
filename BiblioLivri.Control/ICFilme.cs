using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFilme" in both code and config file together.
    [ServiceContract]
    public interface ICFilme
    {
        [OperationContract]
        void Incluir(TBFilme oFilme);
        [OperationContract]
        void Alterar(TBFilme oFilme);
        [OperationContract]
        void Excluir(TBFilme oFilme);
        [OperationContract]
        TBFilme SelecionaPK(int codigo);
        [OperationContract]
        List<TBFilme> SelecionaTodos();
    }
}
