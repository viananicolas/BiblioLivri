using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
  public partial class TBCopiaLivro
    {
        public static void Incluir(TBCopiaLivro oCopiaLivro)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBCopiaLivros.InsertOnSubmit(oCopiaLivro);
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
        public static void Alterar(TBCopiaLivro oCopiaLivro)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBCopiaLivros.Attach(oCopiaLivro, true);
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
        public static void Excluir(TBCopiaLivro oCopiaLivro)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBCopiaLivros.Attach(oCopiaLivro);
                    odb.TBCopiaLivros.DeleteOnSubmit(oCopiaLivro);
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
        public static TBCopiaLivro SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBCopiaLivros where p.CoNumCopia == codigo select p;
                    TBCopiaLivro oRetorno = Elem.First() ?? null;
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
        public static List<TBCopiaLivro> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBCopiaLivros select p;
                    List<TBCopiaLivro> oRetorno = Elem.ToList();
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
        public static List<TBCopiaLivro> SelecionaTodosCriterio(string Criterio)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBCopiaLivros where p.CoISBN == Criterio select p).ToList();
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
