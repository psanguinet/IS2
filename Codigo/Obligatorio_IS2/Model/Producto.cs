using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Rubro { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }

        public Producto()
        { 
        
        }
    }
}
