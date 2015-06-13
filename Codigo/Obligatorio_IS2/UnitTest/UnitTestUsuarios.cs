using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace UnitTest
{
    [TestClass]
    public class UnitTestUsuarios
    {

        private Usuario user = new Usuario()
        {
            Apellido = "Sanguinet",
            Contrasenia = "Megustaelkiwi1",
            Direccion = "Uruguay 1275",
            Email = "psanguinet@gmail.com",
            Nombre = "Pablo",
            Telefono_Celular = "094000444"
        };

        [TestMethod]
        public void TestAltaUsuario()
        {
           
        }

        [TestMethod]
        public void TestModificacionUsuario()
        {
        }

        [TestMethod]
        public void TestBajaUsuario()
        {
        }
    }
}
