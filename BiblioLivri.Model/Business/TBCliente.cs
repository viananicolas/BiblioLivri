using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioLivri.Model
{
    public partial class TBCliente
    {
        public static void Incluir(TBCliente oCliente)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBClientes.InsertOnSubmit(oCliente);
/*#if DEBUG
                    odb.Log = new System.IO.StreamWriter(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.Model\Logs\linq-to-sql-insert.log") { AutoFlush = true };
#endif*/
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
        public static void Alterar(TBCliente oCliente)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                  odb.TBClientes.Attach(oCliente, true);
                   /* #if DEBUG
                    odb.Log = new System.IO.StreamWriter(@"D:\Faculdade\3º Ano\Desenvolvimento de Sistemas Desktop\2º BI\BiblioLivri\BiblioLivri.Model\Logs\linq-to-sql-update.log") { AutoFlush = true };
#endif*/
                    odb.SubmitChanges();


                }
                catch(Exception ex)
                {
                
                    throw ex;
                }
                finally
                {
                odb.Dispose();
                }
            }
        }
        public static void Excluir(TBCliente oCliente)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    odb.TBClientes.Attach(oCliente);
                    odb.TBClientes.DeleteOnSubmit(oCliente);
                    odb.SubmitChanges();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    odb.Dispose();
                }
            }
        }
        public static TBCliente SelecionaPK(int codigo)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBClientes where p.CliNumCartao == codigo select p).FirstOrDefault();
                    /*TBCliente oRetorno = Elem.First() ?? null;
                    return oRetorno;*/
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    odb.Dispose();
                }
            }
        }
        public static List<TBCliente> SelecionaTodos()
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    return (from p in odb.TBClientes select p).ToList();
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
        public static List<TBCliente> SelecionaTodosConsulta(int Criteria, string Criterio)
        {
            using (DataContext odb = new DataContext())
            {
                try
                {
                    switch (Criteria)
                    {
                        /*Cidade
CPF
Nome
Sobrenome
Todos*/
                        case (0): return (from p in odb.TBClientes where p.CliCidade == Criterio select p).ToList();
                        case (1): return (from p in odb.TBClientes where p.CliCPF == Criterio select p).ToList();
                        case (2): return (from p in odb.TBClientes where p.CliNome == Criterio select p).ToList();
                        case (3): return (from p in odb.TBClientes where p.CliSobrenome == Criterio select p).ToList();
                        default:  return (from p in odb.TBClientes select p).ToList(); ;
                    }
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
                  var Elem = (from p in odb.TBClientes where CPF == p.CliCPF select p).FirstOrDefault();
                  return (Elem == null);
                }
                catch(Exception ex)
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
