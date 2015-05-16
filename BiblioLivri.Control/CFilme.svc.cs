using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFilme" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CFilme.svc or CFilme.svc.cs at the Solution Explorer and start debugging.
    public class CFilme : ICFilme
    {
        public void Alterar(TBFilme oFilme)
        {
            Model.TBFilme.Alterar(oFilme);
        }

        public void Excluir(TBFilme oFilme)
        {
            Model.TBFilme.Excluir(oFilme);
        }

        public void Incluir(TBFilme oFilme)
        {
            Model.TBFilme.Incluir(oFilme);
        }

        public TBFilme SelecionaPK(int codigo)
        {
           return Model.TBFilme.SelecionaPK(codigo);
        }

        public List<TBFilme> SelecionaTodos()
        {
           return Model.TBFilme.SelecionaTodos();
        }
    }
}
