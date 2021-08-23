using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel.Entities
{
    public class Libro:BaseEntity
    {
        public int AutorId { get; set; }
        public int EditorialId { get; set; }
        public string Nombre { get; set; }

        public virtual Autor autor { get; set; }
        public virtual Editorial editorial { get; set; }
    }
}
