using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBDoacao
    {
        public static List<int> Incluir(TBDoacao oDoacao)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBDoacaos.InsertOnSubmit(oDoacao);
                    odb.SubmitChanges();
                    return (from p in odb.TBDoacaos select p.DoNumDoacao).ToList();
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
        public static void Alterar(TBDoacao oDoacao)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBDoacaos.Attach(oDoacao, true);
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
        public static void Excluir(TBDoacao oDoacao)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBDoacaos.Attach(oDoacao);
                    odb.TBDoacaos.DeleteOnSubmit(oDoacao);
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
        public static TBDoacao SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBDoacaos where p.DoNumDoacao == codigo select p).FirstOrDefault();
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
        public static List<TBDoacao> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBDoacaos select p).ToList();
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
        public static List<TBDoacao> SelecionaTodosCriterio(string Criterio, int TipoPesquisa)
        {
            return null;
        }
    }
}
