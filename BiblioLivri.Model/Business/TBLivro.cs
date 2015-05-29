using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBLivro
    {
        public static void Incluir(TBLivro oLivro)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBLivros.InsertOnSubmit(oLivro);
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
        public static void Alterar(TBLivro oLivro)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBLivros.Attach(oLivro, true);
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
        public static void Excluir(TBLivro oLivro)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBLivros.Attach(oLivro);
                    odb.TBLivros.DeleteOnSubmit(oLivro);
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
        public static TBLivro SelecionaPK(string codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBLivros where p.LiISBN == codigo select p;
                    TBLivro oRetorno = Elem.First() ?? null;
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
        public static List<TBLivro> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = from p in odb.TBLivros select p;
                    List<TBLivro> oRetorno = Elem.ToList();
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
        public static bool ValidaISBN(string ISBN)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = (from p in odb.TBLivros where ISBN == p.LiISBN select p).FirstOrDefault();
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
