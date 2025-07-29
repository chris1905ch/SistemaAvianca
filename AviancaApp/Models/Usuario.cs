using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviancaApp.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string UsuarioNombre { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
    }
}
