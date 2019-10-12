using Asistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencia.BLL
{
    public class AsistenciaRepositorio : RepositorioBase<Asistencias> 
    {
        public override bool Modificar(Asistencias asistencia)
        {
            var Anterior = base._contexto.Asistencia.Find(asistencia.AsistenciaId);

            foreach(var item in Anterior.Estudiantes)
            {
                if (!asistencia.Estudiantes.Exists(d => d.EstudianteDetalleId == item.EstudianteDetalleId))
                    base._contexto.Entry(item).State = EntityState.Deleted;
            }

            bool paso = base.Modificar(asistencia);

            return paso;
        }

        public override Asistencias Buscar(int id)
        {
            Asistencias asistencia = new Asistencias();

            asistencia = base.Buscar(id);

            if (asistencia != null)//Para que solo se ejecute el Lazyloading cuando se encuentre un Registro de Asistencia
                asistencia.Estudiantes.Count();

            return asistencia;
        }
    }
}
