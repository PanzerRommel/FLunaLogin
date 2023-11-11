using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Usuarios
    {
        public int IDUsuario { get; set; }
        public string? NombreUsuario { get; set; }
        public string? HashContraseña { get; set; }
        public string? Email { get; set; }

        public List<object> Usuario { get; set; }
    }
}
