using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class Equipaje
    {
        public int EquipajeID { get; set; }
        public int ReservaID { get; set; }
        public string TipoEquipaje { get; set; } 
        public decimal Peso { get; set; }
    }
}
