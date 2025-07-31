using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class Tarifa
    {
        public int TarifaID { get; set; }
        public int VueloID { get; set; }
        public string ClaseAsiento { get; set; }
        public decimal Precio { get; set; }
        public int AsientosDisponibles { get; set; }
    }
}
