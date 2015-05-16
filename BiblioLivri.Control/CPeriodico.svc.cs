using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CPeriodico" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CPeriodico.svc or CPeriodico.svc.cs at the Solution Explorer and start debugging.
    public class CPeriodico : ICPeriodico
    {
        public void Alterar(TBPeriodico oPeriodico)
        {
            Model.TBPeriodico.Alterar(oPeriodico);
        }

        public void Excluir(TBPeriodico oPeriodico)
        {
            Model.TBPeriodico.Excluir(oPeriodico);
        }

        public void Incluir(TBPeriodico oPeriodico)
        {
            Model.TBPeriodico.Incluir(oPeriodico);
        }

        public TBPeriodico SelecionaPK(int codigo)
        {
            return Model.TBPeriodico.SelecionaPK(codigo);
        }

        public List<TBPeriodico> SelecionaTodos()
        {
           return Model.TBPeriodico.SelecionaTodos();
        }

        public bool ValidaISSN(string ISSN)
        {
           return Model.TBPeriodico.ValidaISSN(ISSN);
        }
    }
}
