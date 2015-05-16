using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CGenero" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CGenero.svc or CGenero.svc.cs at the Solution Explorer and start debugging.
    public class CGenero : ICGenero
    {
        public void Alterar(TBGenero oGenero)
        {
            Model.TBGenero.Alterar(oGenero);
        }

        public void Excluir(TBGenero oGenero)
        {
            Model.TBGenero.Excluir(oGenero);
        }

        public void Incluir(TBGenero oGenero)
        {
            Model.TBGenero.Incluir(oGenero);
        }

        public TBGenero SelecionaPK(int codigo)
        {
            return Model.TBGenero.SelecionaPK(codigo);
        }

        public List<TBGenero> SelecionaTodos()
        {
            return Model.TBGenero.SelecionaTodos();
        }
    }
}
