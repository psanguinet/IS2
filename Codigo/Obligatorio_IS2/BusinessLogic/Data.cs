using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
                Descripcion = "Manzanas rojas de calidad superior",
                Precio = 30,
                Marca = "Gelen",
                Rubro = "Frutas",
                Tipo = "1",
                Imagen = Image.FromFile(Environment.CurrentDirectory + @"\Resources\manzanas.jpg")
            };
            Producto p2 = new Producto()
           {
               Codigo = "2",
               Nombre = "Naranjas",
               Descripcion = "Super jugosas provenientes de Salto - Uruguay.",
               Precio = 35,
               Marca = "Guarino",
               Rubro = "Frutas",
               Tipo = "3",
               Imagen = Image.FromFile(Environment.CurrentDirectory + @"\Resources\naranjas.jpg")
           };
            Producto p3 = new Producto()
           {
               Codigo = "3",
               Nombre = "Kiwy",
               Descripcion = "Importados. Calidad superior.",
               Precio = 89,
               Marca = "SolNegro",
               Rubro = "Frutas",
               Tipo = "1",
               Imagen = Image.FromFile(Environment.CurrentDirectory + @"\Resources\kiwy.jpg")

           };
            Producto p4 = new Producto()
            {
                Codigo = "4",
                Nombre = "Peras",
                Descripcion = "Importadas. Calidad superior.",
                Precio = 40,
                Marca = "Rio",
                Rubro = "Frutas",
                Tipo = "1",
                Imagen = Image.FromFile(Environment.CurrentDirectory + @"\Resources\peras.jpg")
            };
            Producto p5 = new Producto()
            {
                Codigo = "5",
                Nombre = "Arroz",
                Descripcion= "Blue. Calidad superior.",
                Precio = 38,
                Marca = "Saman",
                Rubro = "Comestibles",
                Tipo = "1",
                Imagen = Image.FromFile(Environment.CurrentDirectory + @"\Resources\arroz.jpg")
            };
            Producto p6 = new Producto()
            {
                Codigo = "6",
                Nombre = "Aceite",
                Descripcion = "Oliva. Importado. Calidad superior.",
                Precio = 38,
                Marca = "Saman",
                Rubro = "Comestibles",
                Tipo = "1",
                Imagen = Image.FromFile(Environment.CurrentDirectory + @"\Resources\aceite.jpg")
            };
            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);
            return lista;
        }

        public List<Producto> ListarProductosOrdenados()
        {
             return productos.OrderBy(n=>n.Nombre).ToList<Producto>();
             
        }
    }
}
