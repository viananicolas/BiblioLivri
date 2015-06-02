using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBEmprestimo
    {
        public static List<int> Incluir(TBEmprestimo oEmprestimo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBEmprestimos.InsertOnSubmit(oEmprestimo);
                    odb.SubmitChanges();
                    return (from p in odb.TBEmprestimos select p.EmpNumEmprestimo).ToList();
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
        public static void Alterar(TBEmprestimo oEmprestimo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBEmprestimos.Attach(oEmprestimo, true);
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
        public static void Excluir(TBEmprestimo oEmprestimo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBEmprestimos.Attach(oEmprestimo);
                    odb.TBEmprestimos.DeleteOnSubmit(oEmprestimo);
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
        public static TBEmprestimo SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBEmprestimos where p.EmpNumEmprestimo == codigo select p).FirstOrDefault();
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
        public static List<TBEmprestimo> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBEmprestimos select p).ToList();
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
        public static List<TBEmprestimo> SelecionaTodosCriterio(string Criterio, int TipoPesquisa)
        {
            return null;
        }
    }
}
