using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CEditora" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CEditora.svc or CEditora.svc.cs at the Solution Explorer and start debugging.
    public class CEditora : ICEditora
    {
        public void Alterar(TBEditora oEditora)
        {
            Model.TBEditora.Alterar(oEditora);
        }
        public void Excluir(TBEditora oEditora)
        {
            Model.TBEditora.Excluir(oEditora);
        }

        public void Incluir(TBEditora oEditora)
        {
            Model.TBEditora.Incluir(oEditora);
        }

        public TBEditora SelecionaPK(int codigo)
        {
            return Model.TBEditora.SelecionaPK(codigo);
        }

        public List<TBEditora> SelecionaTodos()
        {
            return Model.TBEditora.SelecionaTodos();
        }
        public List<TBEditora> SelecionaTodosCriterio(string Criterio, int TipoPesquisa)
        {
            return Model.TBEditora.SelecionaTodosCriterio(Criterio, TipoPesquisa);
        }

    }
}
