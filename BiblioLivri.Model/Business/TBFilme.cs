using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBFilme
    {
        public static void Incluir(TBFilme oFilme)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBFilmes.InsertOnSubmit(oFilme);
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
        public static void Alterar(TBFilme oFilme)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBFilmes.Attach(oFilme, true);
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
        public static void Excluir(TBFilme oFilme)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBFilmes.Attach(oFilme);
                    odb.TBFilmes.DeleteOnSubmit(oFilme);
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
        public static TBFilme SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBFilmes where p.id_Filme == codigo select p;
                    TBFilme oRetorno = Elem.First() ?? null;
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
        public static List<TBFilme> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBFilmes select p;
                    List<TBFilme> oRetorno = Elem.ToList();
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
    }
}
