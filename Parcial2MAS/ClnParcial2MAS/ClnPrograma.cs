using CadParcial2MAS; // Referencia al proyecto CAD
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClnParcial2MAS
{
    public class ClnPrograma
    {
        // Listar programas activos usando el procedimiento almacenado
        public static List<Programa> Listar(string parametro = "")
        {
            using (var context = new Parcial2MASEntities())
            {
                // Usamos LINQ normal si no queremos SP:
                // return context.Programa.Where(p => p.estado == 1).ToList();

                // Usar procedimiento almacenado
                var sqlParam = new SqlParameter("@parametro", parametro ?? "");
                return context.Database.SqlQuery<Programa>(
                    "EXEC paProgramaListar @parametro", sqlParam
                ).ToList();
            }
        }

        // Insertar un nuevo programa
        public static void Insertar(Programa programa)
        {
            using (var context = new Parcial2MASEntities())
            {
                context.Programa.Add(programa);
                context.SaveChanges();
            }
        }

        // Actualizar un programa existente
        public static void Actualizar(Programa programa)
        {
            using (var context = new Parcial2MASEntities())
            {
                var existente = context.Programa.Find(programa.id);
                if (existente != null)
                {
                    existente.titulo = programa.titulo;
                    existente.descripcion = programa.descripcion;
                    existente.duracion = programa.duracion;
                    existente.productor = programa.productor;
                    existente.fechaEstreno = programa.fechaEstreno;
                    existente.idCanal = programa.idCanal;
                    context.SaveChanges();
                }
            }
        }

        // Eliminación lógica (marcar como inactivo)
        public static void Eliminar(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                var programa = context.Programa.Find(id);
                if (programa != null)
                {
                    programa.estado = 0; // eliminación lógica
                    context.SaveChanges();
                }
            }
        }

        // Obtener un programa por ID
        public static Programa ObtenerPorId(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.Programa.Find(id);
            }
        }
    }
}
