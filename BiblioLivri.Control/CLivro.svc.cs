using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CLivro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CLivro.svc or CLivro.svc.cs at the Solution Explorer and start debugging.
    public class CLivro : ICLivro
    {
        public void Alterar(TBLivro oLivro)
        {
            Model.TBLivro.Alterar(oLivro);
        }


        public void Excluir(TBLivro oLivro)
        {
            Model.TBLivro.Excluir(oLivro);
        }

        public void Incluir(TBLivro oLivro)
        {
            Model.TBLivro.Incluir(oLivro);
        }

        public TBLivro SelecionaPK(int codigo)
        {
            return Model.TBLivro.SelecionaPK(codigo);
        }

        public List<TBLivro> SelecionaTodos()
        {
            return Model.TBLivro.SelecionaTodos();
        }

        public bool ValidaISBN(string ISBN)
        {
            return Model.TBLivro.ValidaISBN(ISBN);
        }   
    }
}
