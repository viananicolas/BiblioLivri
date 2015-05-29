using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBItemEmprestimo
    {
        public static void Incluir(TBItemEmprestimo oItemEmprestimo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBItemEmprestimos.InsertOnSubmit(oItemEmprestimo);
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
        public static void IncluirTodos(List<TBItemEmprestimo> oItemEmprestimo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBItemEmprestimos.InsertAllOnSubmit(oItemEmprestimo);
                  //  #if DEBUG
                   // odb.Log = new System.IO.StreamWriter(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.Model\Logs\linq-to-sql-insert-itens-livro.log",true) { AutoFlush = true };
//#endif

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
        public static TBItemEmprestimo SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBItemEmprestimos where p.ItemNumEmprestimo == codigo select p).FirstOrDefault();
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
        public static List<TBItemEmprestimo> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBItemEmprestimos select p).ToList();
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
        public static List<TBItemEmprestimo> SelecionaTodosCriterio(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBItemEmprestimos where p.ItemNumEmprestimo == codigo select p).ToList();
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
