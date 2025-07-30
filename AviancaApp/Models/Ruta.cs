using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class Ruta
    {
        public int RutaID { get; set; }
        public int AeropuertoOrigenID { get; set; }
        public int AeropuertoDestinoID { get; set; }
        public string Origen { get; internal set; }
        public string Destino { get; internal set; }
        public string Duracion { get; internal set; }
    }
}
