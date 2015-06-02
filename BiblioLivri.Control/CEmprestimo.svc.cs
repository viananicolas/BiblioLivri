using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CEmprestimo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CEmprestimo.svc or CEmprestimo.svc.cs at the Solution Explorer and start debugging.
    public class CEmprestimo : ICEmprestimo
    {
        public void Alterar(TBEmprestimo oEmprestimo)
        {
            Model.TBEmprestimo.Alterar(oEmprestimo);
        }

      

        public void Excluir(TBEmprestimo oEmprestimo)
        {
            Model.TBEmprestimo.Excluir(oEmprestimo);
        }

        public List<int> Incluir(TBEmprestimo oEmprestimo)
        {
            return Model.TBEmprestimo.Incluir(oEmprestimo);
        }

        public TBEmprestimo SelecionaPK(int codigo)
        {
            return Model.TBEmprestimo.SelecionaPK(codigo);

        }

        public List<TBEmprestimo> SelecionaTodos()
        {
            return Model.TBEmprestimo.SelecionaTodos();

        }

        public List<TBEmprestimo> SelecionaTodosCriterio(string Criterio, int TipoPesquisa)
        {
            return Model.TBEmprestimo.SelecionaTodosCriterio(Criterio, TipoPesquisa);
        }
    }
}
