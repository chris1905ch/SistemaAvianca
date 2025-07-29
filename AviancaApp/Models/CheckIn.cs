using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class CheckIn
    {
        public int CheckInID { get; set; }
        public int ReservaID { get; set; }
        public DateTime FechaCheckIn { get; set; }
        public string NumeroAsientoAsignado { get; set; }
    }
}
