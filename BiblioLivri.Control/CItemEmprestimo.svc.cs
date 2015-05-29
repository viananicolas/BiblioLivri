using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CItemEmprestimo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CItemEmprestimo.svc or CItemEmprestimo.svc.cs at the Solution Explorer and start debugging.
    public class CItemEmprestimo : ICItemEmprestimo
    {

        public void Incluir(TBItemEmprestimo oItemEmprestimo)
        {
            Model.TBItemEmprestimo.Incluir(oItemEmprestimo);
        }
        public void IncluirTodos(List<TBItemEmprestimo> oItemEmprestimo)
        {
            Model.TBItemEmprestimo.IncluirTodos(oItemEmprestimo);
        }
        public TBItemEmprestimo SelecionaPK(int codigo)
        {
            return Model.TBItemEmprestimo.SelecionaPK(codigo);
        }

        public List<TBItemEmprestimo> SelecionaTodos()
        {
            return Model.TBItemEmprestimo.SelecionaTodos();
        }
        public List<TBItemEmprestimo> SelecionaTodosCriterio(int codigo)
        {
            return Model.TBItemEmprestimo.SelecionaTodosCriterio(codigo);
        }
    }
}
