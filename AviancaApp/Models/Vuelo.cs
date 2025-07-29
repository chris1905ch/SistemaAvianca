using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vuelo
{
    public int VueloID { get; set; }
    public string NumeroVuelo { get; set; }
    public int RutaID { get; set; }
    public int AvionID { get; set; }
    public DateTime FechaSalida { get; set; }
    public DateTime FechaLlegada { get; set; }
    public string EstadoVuelo { get; set; }
}
