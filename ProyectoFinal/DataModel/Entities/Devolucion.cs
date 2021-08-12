using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel.Entities
{
    public class Devolucion:BaseEntity
    {
        public int PrestamoId { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Prestamo prestamo { get; set; }
    }
}
