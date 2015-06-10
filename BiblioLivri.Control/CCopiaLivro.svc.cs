using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CCopiaLivro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CCopiaLivro.svc or CCopiaLivro.svc.cs at the Solution Explorer and start debugging.
    public class CCopiaLivro : ICCopiaLivro
    {
        public void Alterar(TBCopiaLivro oCopiaLivro)
        {
            Model.TBCopiaLivro.Alterar(oCopiaLivro);
        }

        public void Excluir(TBCopiaLivro oCopiaLivro)
        {
            Model.TBCopiaLivro.Excluir(oCopiaLivro);
        }

        public void Incluir(TBCopiaLivro oCopiaLivro)
        {
            Model.TBCopiaLivro.Incluir(oCopiaLivro);
        }

        public TBCopiaLivro SelecionaPK(int codigo)
        {
            return Model.TBCopiaLivro.SelecionaPK(codigo);
        }

        public List<TBCopiaLivro> SelecionaTodos()
        {
            return Model.TBCopiaLivro.SelecionaTodos();
        }
        public List<TBCopiaLivro> SelecionaTodosCriterio(string Criterio)
        {
            return Model.TBCopiaLivro.SelecionaTodosCriterio(Criterio);
        }
    }
}
