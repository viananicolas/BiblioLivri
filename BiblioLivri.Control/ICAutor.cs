using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICAutor" in both code and config file together.
    [ServiceContract]
    public interface ICAutor
    {
        [OperationContract]
        void Incluir(TBAutor oAutor);
        [OperationContract]
        void Alterar(TBAutor oAutor);
        [OperationContract]
        void Excluir(TBAutor oAutor);
        [OperationContract]
        TBAutor SelecionaPK(int codigo);
        [OperationContract]
        List<TBAutor> SelecionaTodos();
        [OperationContract]
        List<TBAutor> SelecionaTodosCriterio(string Criterio, int TipoPesquisa);
    }
}
