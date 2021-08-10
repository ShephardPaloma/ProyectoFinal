using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Borrado { get; set; }
        public string Estatus { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
