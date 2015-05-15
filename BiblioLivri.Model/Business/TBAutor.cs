using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBAutor
    {
        public static void Incluir(TBAutor oAutor)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBAutors.InsertOnSubmit(oAutor);
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
        public static void Alterar(TBAutor oAutor)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBAutors.Attach(oAutor, true);
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
        public static void Excluir(TBAutor oAutor)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBAutors.Attach(oAutor);
                    odb.TBAutors.DeleteOnSubmit(oAutor);
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
        public static TBAutor SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBAutors where p.id_Autor == codigo select p).FirstOrDefault();
                    /*TBCliente oRetorno = Elem.First() ?? null;
                    return oRetorno;*/
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
        public static List<TBAutor> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBAutors select p).ToList();
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
