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
                    var Elem = from p in odb.TBClientes where p.id_cliente == codigo select p;
                    TBCliente oRetorno = Elem.First() ?? null;
                    return oRetorno;
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
                    var Elem = from p in odb.TBClientes select p;
                    List<TBCliente> oRetorno = Elem.ToList();
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
