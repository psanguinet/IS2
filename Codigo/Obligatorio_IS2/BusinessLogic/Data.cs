using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Data
    {
        private List<Producto> productos;

        public Data()
        {
            productos = CargarProductos();
        }

        private List<Producto> CargarProductos()
        {
            List<Producto> lista = new List<Producto>();
            Producto p1 = new Producto()
            {
                Codigo = "1",
                Nombre = "Manzanas",
                Precio = 30,
                Marca = "Gelen",
                Rubro = "Frutas",
                Tipo = "1",
            };
            Producto p2 = new Producto()
           {
               Codigo = "2",
               Nombre = "Naranjas",
               Precio = 35,
               Marca = "Guarino",
               Rubro = "Frutas",
               Tipo = "3",
           };
            Producto p3 = new Producto()
           {
               Codigo = "3",
               Nombre = "Kiwy",
               Precio = 89,
               Marca = "SolNegro",
               Rubro = "Frutas",
               Tipo = "1",
           };
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            return lista;
        }

        public List<Producto> ListarProductosOrdenados()
        {
             return productos.OrderBy(n=>n.Nombre).ToList<Producto>();
             
        }
    }
}
