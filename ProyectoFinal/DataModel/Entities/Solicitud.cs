using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel.Entities
{
    public class Solicitud : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Libro { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
    }
}
