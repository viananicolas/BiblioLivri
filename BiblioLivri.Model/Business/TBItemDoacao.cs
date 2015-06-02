using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
   public partial class TBItemDoacao
    {
        public static void Incluir(TBItemDoacao oItemDoacao)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBItemDoacaos.InsertOnSubmit(oItemDoacao);
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
        public static void IncluirTodos(List<TBItemDoacao> oItemDoacao)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBItemDoacaos.InsertAllOnSubmit(oItemDoacao);
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
        public static TBItemDoacao SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBItemDoacaos where p.ItemNumDoacao == codigo select p).FirstOrDefault();
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
        public static List<TBItemDoacao> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBItemDoacaos select p).ToList();
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
        public static List<TBItemDoacao> SelecionaTodosCriterio(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBItemDoacaos where p.ItemNumDoacao == codigo select p).ToList();
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
