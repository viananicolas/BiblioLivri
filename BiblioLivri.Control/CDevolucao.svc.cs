using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BiblioLivri.Model;

namespace BiblioLivri.Control
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CDevolucao" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CDevolucao.svc or CDevolucao.svc.cs at the Solution Explorer and start debugging.
    public class CDevolucao : ICDevolucao
    {
        public void Incluir(TBDevolucao oDevolucao)
        {
            Model.TBDevolucao.Incluir(oDevolucao);
        }
    }
}
