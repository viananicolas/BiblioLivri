using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICEditora" in both code and config file together.
    [ServiceContract]
    public interface ICEditora
    {
        [OperationContract]
        void Incluir(TBEditora oEditora);
        [OperationContract]
        void Alterar(TBEditora oEditora);
        [OperationContract]
        void Excluir(TBEditora oEditora);
        [OperationContract]
        TBEditora SelecionaPK(int codigo);
        [OperationContract]
        List<TBEditora> SelecionaTodos();
    }
}
