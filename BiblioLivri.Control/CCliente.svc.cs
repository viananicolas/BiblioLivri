using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CCliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CCliente.svc or CCliente.svc.cs at the Solution Explorer and start debugging.
    public class CCliente : ICCliente
    {
        public void Alterar(TBCliente oCliente)
        {
            Model.TBCliente.Alterar(oCliente);
        }
        public void Excluir(TBCliente oCliente)
        {
            Model.TBCliente.Excluir(oCliente);
        }
        public void Incluir(TBCliente oCliente)
        {
            Model.TBCliente.Incluir(oCliente);

        }
        public TBCliente SelecionaPK(int codigo)
        {
            return Model.TBCliente.SelecionaPK(codigo);
        }

        public List<TBCliente> SelecionaTodos()
        {

            return Model.TBCliente.SelecionaTodos();
        }
        public bool ValidaCPF(string CPF)
        {
            return Model.TBCliente.ValidaCPF(CPF);
        }
    }
}
