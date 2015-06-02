using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;
namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICCopiaLivro" in both code and config file together.
    [ServiceContract]
    public interface ICCopiaLivro
    {
        [OperationContract]
        void Incluir(TBCopiaLivro oCopiaLivro);
        [OperationContract]
        void Alterar(TBCopiaLivro oCopiaLivro);
        [OperationContract]
        void Excluir(TBCopiaLivro oCopiaLivro);
        [OperationContract]
        TBCopiaLivro SelecionaPK(int codigo);
        [OperationContract]
        List<TBCopiaLivro> SelecionaTodos();
        [OperationContract]
        List<TBCopiaLivro> SelecionaTodosCriterio(string Criterio, int TipoPesquisa);
    }
}
