using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class Aeropuerto
    {
        public int AeropuertoID { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string CodigoIATA { get; set; }
    }
}