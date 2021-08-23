using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel.Entities
{
    public class Prestamo:BaseEntity
    {
        public int EstudianteId { get; set; }
        public int LibroId { get; set; }

        public virtual Estudiante estudiante { get; set; }
        public virtual Libro libro { get; set; }
    }
}
