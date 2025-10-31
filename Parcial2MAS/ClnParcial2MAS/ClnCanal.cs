using CadParcial2MAS; // Referencia al proyecto CAD
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2MAS
{
    public class ClnCanal
    {
        // Listar todos los canales activos
        public static List<Canal> Listar()
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.Canal
                              .Where(c => c.estado == 1)
                              .OrderBy(c => c.nombre)
                              .ToList();
            }
        }

        // Insertar un nuevo canal
        public static void Insertar(Canal canal)
        {
            using (var context = new Parcial2MASEntities())
            {
                context.Canal.Add(canal);
                context.SaveChanges();
            }
        }

        // Actualizar un canal existente
        public static void Actualizar(Canal canal)
        {
            using (var context = new Parcial2MASEntities())
            {
                var existente = context.Canal.Find(canal.id);
                if (existente != null)
                {
                    existente.nombre = canal.nombre;
                    existente.frecuencia = canal.frecuencia;
                    context.SaveChanges();
                }
            }
        }

        // Eliminación lógica (marcar como inactivo)
        public static void Eliminar(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                var canal = context.Canal.Find(id);
                if (canal != null)
                {
                    canal.estado = 0; // cambio de estado
                    context.SaveChanges();
                }
            }
        }

        // Obtener un canal por ID
        public static Canal ObtenerPorId(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.Canal.Find(id);
            }
        }
    }
}
