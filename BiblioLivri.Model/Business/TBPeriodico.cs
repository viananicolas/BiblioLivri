using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBPeriodico
    {
        public static void Incluir(TBPeriodico oPeriodico)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBPeriodicos.InsertOnSubmit(oPeriodico);
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
        public static void Alterar(TBPeriodico oPeriodico)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBPeriodicos.Attach(oPeriodico, true);
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
        public static void Excluir(TBPeriodico oPeriodico)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBPeriodicos.Attach(oPeriodico);
                    odb.TBPeriodicos.DeleteOnSubmit(oPeriodico);
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
        public static TBPeriodico SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBPeriodicos where p.id_revista == codigo select p;
                    TBPeriodico oRetorno = Elem.First() ?? null;
                    return oRetorno;
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
        public static List<TBPeriodico> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBPeriodicos select p;
                    List<TBPeriodico> oRetorno = Elem.ToList();
                    return oRetorno;
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
        public static bool ValidaISSN(string ISSN)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = (from p in odb.TBPeriodicos where ISSN == p.ReISSN select p).FirstOrDefault();
                    return (Elem == null);
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
