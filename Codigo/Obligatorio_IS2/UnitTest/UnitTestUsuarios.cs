using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BusinessLogic;

namespace UnitTest
{
    [TestClass]
    public class UnitTestUsuarios
    {

       private Usuario u1 = new Usuario()
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
            int lengthBefore = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().BorrarUsuario(u1);
            int lengthAfter = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(lengthBefore, lengthAfter+1);
            //hay problemas con la baja de usuarios o con la obtencion de la lista de usuarios
        }
    }
}
