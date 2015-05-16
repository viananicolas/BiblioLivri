using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBFuncionario
    {
        public static void Incluir(TBFuncionario oFuncionario)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBFuncionarios.InsertOnSubmit(oFuncionario);
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
        public static void Alterar(TBFuncionario oFuncionario)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBFuncionarios.Attach(oFuncionario, true);
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
        public static void Excluir(TBFuncionario oFuncionario)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBFuncionarios.Attach(oFuncionario);
                    odb.TBFuncionarios.DeleteOnSubmit(oFuncionario);
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
        public static TBFuncionario SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBFuncionarios where p.id_funcionario == codigo select p).FirstOrDefault();
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
        public static List<TBFuncionario> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBFuncionarios select p).ToList();
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
        public static bool ValidaCPF(string CPF)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    var Elem = (from p in odb.TBFuncionarios where CPF == p.FunCPF select p).FirstOrDefault();
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
