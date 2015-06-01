using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasenia { get; set; }
        public string Direccion { get; set; }
        public string Telefono_Celular { get; set; }
        public string Email { get; set; }

        public Usuario()
        { 
        
        }
    }
}
