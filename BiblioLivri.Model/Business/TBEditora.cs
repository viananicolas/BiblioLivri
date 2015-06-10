using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBEditora
    {
        public static void Incluir(TBEditora oEditora)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBEditoras.InsertOnSubmit(oEditora);
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
        public static void Alterar(TBEditora oEditora)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBEditoras.Attach(oEditora, true);
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
        public static void Excluir(TBEditora oEditora)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBEditoras.Attach(oEditora);
                    odb.TBEditoras.DeleteOnSubmit(oEditora);
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
        public static TBEditora SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBEditoras where p.id_editora == codigo select p).FirstOrDefault();
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
        public static List<TBEditora> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBEditoras select p).ToList();
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
        public static List<TBEditora> SelecionaTodosCriterio(string Criterio, int TipoPesquisa)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    switch (TipoPesquisa)
                    {
                        case (0): return (from p in odb.TBEditoras where p.EdNome == Criterio select p).ToList();
                        case (1): return (from p in odb.TBEditoras where p.EdCidade == Criterio select p).ToList();
                        default:
                            break;
                    }
                    var Elem = from p in odb.TBEditoras select p;
                    List<TBEditora> oRetorno = Elem.ToList();
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
