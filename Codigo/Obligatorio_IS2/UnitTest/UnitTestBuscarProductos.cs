using BusinessLogic;
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
            Assert.AreEqual(p.Nombre, Data.GetInstance().GetProductByName(p.Nombre).Nombre);//CP1
            Assert.AreEqual(null, Data.GetInstance().GetProductByName("Manzanas Rojas"));//CP2
        }

        [TestMethod]
        public void TestBuscarProductosCodigo()
        {
            Assert.AreEqual(p.Codigo, Data.GetInstance().GetProductoByCode(p.Codigo).Codigo);//CP3
            Assert.AreEqual(null, Data.GetInstance().GetProductoByCode("ABC1"));//CP4
        }

        [TestMethod]
        public void TestBuscarProductosRubro()
        {
            Assert.IsTrue( Data.GetInstance().GetProductosByCategory(p.Rubro).Count()>0);//CP5
            Assert.IsTrue(Data.GetInstance().GetProductosByCategory("ELECTRODOMESTICOS").Count==0);//CP6
        }
        [TestMethod]
        public void TestBuscarProductosTipo()
        {
            Assert.IsTrue( Data.GetInstance().GetProductosByType(p.Tipo).Count()>0);//CP7
            Assert.IsTrue(Data.GetInstance().GetProductosByType("TIPO_1").Count==0);//CP8
        }
    }
}
