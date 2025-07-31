using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Reserva
{
    public int ReservaID { get; set; }
    public int ClienteID { get; set; }
    public int VueloID { get; set; }
    public int TarifaID { get; set; }
    public DateTime FechaReserva { get; set; }
    public string EstadoReserva { get; set; }
    public string NombrePasajero { get; set; }
}
