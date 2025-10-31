using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadParcial2MAS;

namespace ClnParcial2MAS
{
    public class CanalCln
    {
        public static int insertar(Canal canal)
        {
            using (var context = new Parcial2MASEntities())
            {
                context.Canal.Add(canal);
                context.SaveChanges();
                return canal.id;
            }
        }

        public static int actualizar(Canal canal)
        {
            using (var context = new Parcial2MASEntities())
            {
                var existente = context.Canal.Find(canal.id);
                existente.nombre = canal.nombre;
                existente.frecuencia = canal.frecuencia;
                existente.estado = canal.estado;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                var canal = context.Canal.Find(id);
                canal.estado = -1;
                return context.SaveChanges();
            }
        }

        public static Canal obtenerUno(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.Canal.Find(id);
            }
        }

        public static List<Canal> listar()
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.Canal.Where(c => c.estado != -1).ToList();
            }
        }
    }
}
