using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerConsola.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nombre { get; set; }

        public string apellido { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public DateTime fecha_nacimiento { get; set; }

        public Boolean estado { get; set; }
    }
}
