using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFuncionario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CFuncionario.svc or CFuncionario.svc.cs at the Solution Explorer and start debugging.
    public class CFuncionario : ICFuncionario
    {
        public void Alterar(TBFuncionario oFuncionario)
        {
            Model.TBFuncionario.Alterar(oFuncionario);
        }
        public void Excluir(TBFuncionario oFuncionario)
        {
            Model.TBFuncionario.Excluir(oFuncionario);
        }
        public void Incluir(TBFuncionario oFuncionario)
        {
            Model.TBFuncionario.Incluir(oFuncionario);
        }
        public TBFuncionario SelecionaPK(int codigo)
        {
            return Model.TBFuncionario.SelecionaPK(codigo);
        }
        public List<TBFuncionario> SelecionaTodos()
        {
            return Model.TBFuncionario.SelecionaTodos();
        }
        public bool ValidaCPF(string CPF)
        {
            return Model.TBFuncionario.ValidaCPF(CPF);
        }
    }
}
