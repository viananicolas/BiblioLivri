using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICPeriodico" in both code and config file together.
    [ServiceContract]
    public interface ICPeriodico
    {
        [OperationContract]
        void Incluir(TBPeriodico oPeriodico);
        [OperationContract]
        void Alterar(TBPeriodico oPeriodico);
        [OperationContract]
        void Excluir(TBPeriodico oPeriodico);
        [OperationContract]
        TBPeriodico SelecionaPK(int codigo);
        [OperationContract]
        List<TBPeriodico> SelecionaTodos();
        [OperationContract]
        bool ValidaISSN(string ISSN);
    }
}
