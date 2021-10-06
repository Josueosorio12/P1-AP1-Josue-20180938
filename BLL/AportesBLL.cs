using Microsoft.EntityFrameworkCore;
using P1_ap1_josueosorio_20180938.DAL;
using P1_ap1_josueosorio_20180938.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ap1_josueosorio_20180938.BLL
{
    public class AportesBLL
    {
        public static bool Guardar(AportesEntidades aporte)
        {
            if (!Existe(aporte.AporteID))
                return Insertar(aporte);
            else
                return Modificar(aporte);
        }

        private static bool Insertar(AportesEntidades aporte)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.AportesEntidades.Add(aporte);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        private static bool Modificar(AportesEntidades aporte)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(aporte).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var Aporte = contexto.AportesEntidades.Find(id);
                if (Aporte != null)
                {
                    contexto.AportesEntidades.Remove(Aporte);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static AportesEntidades Buscar(int id)
        {
            Contexto contexto = new Contexto();
            AportesEntidades aporte;

            try
            {
                aporte = contexto.AportesEntidades.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return aporte;
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.AportesEntidades.Any(e => e.AporteID == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<AportesEntidades> GetList()
        {
            List<AportesEntidades> lista = new List<AportesEntidades>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.AportesEntidades.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

    }
}
