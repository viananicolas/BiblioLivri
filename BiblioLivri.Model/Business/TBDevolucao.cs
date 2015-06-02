using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBDevolucao
    {
        public static void Incluir(TBDevolucao oDevolucao)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBDevolucaos.InsertOnSubmit(oDevolucao);
                    odb.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    odb.Dispose();
                }
            }
        }
    }
}
