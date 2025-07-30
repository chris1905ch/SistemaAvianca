using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class Avion
    {
        public int AvionID { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public string Matricula { get; set; }
        public string Estado { get; set; }
    }
}

