using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_1.Models
{
    internal class Reservas
    {
        public int huespedes_id { get; set; }
        public int reserva_id { get; set; }
        public int habitacion_id { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }


    }
}
