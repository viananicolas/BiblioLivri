using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CAutor" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CAutor.svc or CAutor.svc.cs at the Solution Explorer and start debugging.
    public class CAutor : ICAutor
    {
        public void Alterar(TBAutor oAutor)
        {
            Model.TBAutor.Alterar(oAutor);
        }

        public void Excluir(TBAutor oAutor)
        {
            Model.TBAutor.Excluir(oAutor);
        }

        public void Incluir(TBAutor oAutor)
        {
            Model.TBAutor.Incluir(oAutor);
        }

        public TBAutor SelecionaPK(int codigo)
        {
            return Model.TBAutor.SelecionaPK(codigo);
        }

        public List<TBAutor> SelecionaTodos()
        {
            return Model.TBAutor.SelecionaTodos();
        }
    }
}
