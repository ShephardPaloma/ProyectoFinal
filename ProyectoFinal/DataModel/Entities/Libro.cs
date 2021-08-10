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

        public Autor autor { get; set; }
        public Editorial editorial { get; set; }
    }
}
