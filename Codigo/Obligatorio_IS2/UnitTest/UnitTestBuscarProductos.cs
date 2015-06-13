using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTestBuscarProductos
    {
        
        private Producto p = new Producto()
        {
            Codigo = "1",
            Nombre = "Manzanas",
            Descripcion = "Manzanas rojas de calidad superior",
            Precio = 30,
            Marca = "Gelen",
            Rubro = "Frutas",
            Tipo = "1",
            Imagen = null
        };

        [TestMethod]
        public void TestBuscarProductosNombre()
        {
            Assert.AreEqual(p.Nombre, null);//en lugar de null hay que poner el metodo que busca el producto
            Assert.AreEqual(p.Nombre.ToUpper(), null);//en lugar de null hay que poner el metodo que busca el producto
        }

        [TestMethod]
        public void TestBuscarProductosCodigo()
        {
            Assert.AreEqual(p.Codigo, null);//en lugar de null hay que poner el metodo que busca el producto
            Assert.AreEqual(p.Codigo.ToUpper(), null);//en lugar de null hay que poner el metodo que busca el producto
        }

        [TestMethod]
        public void TestBuscarProductosRubro()
        {
            Assert.AreEqual(p.Rubro, null);//en lugar de null hay que poner el metodo que busca el producto
            Assert.AreEqual(p.Rubro.ToUpper(), null);//en lugar de null hay que poner el metodo que busca el producto
        }
        [TestMethod]
        public void TestBuscarProductosTipo()
        {
            Assert.AreEqual(p.Tipo, null);//en lugar de null hay que poner el metodo que busca el producto
            Assert.AreEqual(p.Tipo.ToUpper(), null);//en lugar de null hay que poner el metodo que busca el producto
        }
    }
}
