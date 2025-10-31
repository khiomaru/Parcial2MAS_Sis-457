using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadParcial2MAS;

namespace ClnParcial2MAS
{
    public class ProgramaCln
    {
        public static int insertar(Programa programa)
        {
            using (var context = new Parcial2MASEntities())
            {
                context.Programa.Add(programa);
                context.SaveChanges();
                return programa.id;
            }
        }

        public static int actualizar(Programa programa)
        {
            using (var context = new Parcial2MASEntities())
            {
                var existente = context.Programa.Find(programa.id);
                existente.idCanal = programa.idCanal;
                existente.titulo = programa.titulo;
                existente.descripcion = programa.descripcion;
                existente.duracion = programa.duracion;
                existente.productor = programa.productor;
                existente.fechaEstreno = programa.fechaEstreno;
                existente.estado = programa.estado;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                var programa = context.Programa.Find(id);
                programa.estado = -1;
                return context.SaveChanges();
            }
        }

        public static Programa obtenerUno(int id)
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.Programa.Find(id);
            }
        }

        public static List<paProgramaListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2MASEntities())
            {
                return context.paProgramaListar(parametro).ToList();
            }
        }
    }
}
