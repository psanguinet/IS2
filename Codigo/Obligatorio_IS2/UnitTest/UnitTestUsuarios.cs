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

       private Usuario u2 = new Usuario()
       {
           Apellido = "Canabarro",
           Contrasenia = "Nano1001",
           Direccion = "Bulevar 2873",
           Email = "andrescanabarro@gmail.com",
           Nombre = "Andres",
           Telefono_Celular = "098657882"
       };

        [TestMethod]
        public void TestAltaUsuario()
        {
            int cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            int cantidadPosterior;
            Data.GetInstance().AgregarUsuario("", u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP2

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, "", u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP3

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, "", u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP4

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, "nano1001", "nano1001", u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP5

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, "NanoNano", "NanoNano", u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP6

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, "Nano1", "Nano1", u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP7

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, "NanoCanabarro1001", "NanoCanabarro1001", u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP8

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, "Nano1001", "Pablo1001", u2.Direccion, u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP9

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, "", u2.Telefono_Celular, u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP10

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, "", u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP11

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, "098", u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP12

            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, "andrescanabarro.gmail.com");
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
          Assert.AreEqual(cantidadAnterior, cantidadPosterior); //CP13

            Data.GetInstance().BorrarUsuario(u2);
            cantidadAnterior = Data.GetInstance().DevolverUsuarios().Count;
            Data.GetInstance().AgregarUsuario(u2.Nombre,u2.Apellido,u2.Contrasenia,u2.Contrasenia,u2.Direccion,u2.Telefono_Celular,u2.Email);
            cantidadPosterior = Data.GetInstance().DevolverUsuarios().Count;
            Assert.AreEqual(cantidadAnterior + 1, cantidadPosterior);//CP1
        }

        [TestMethod]
        public void TestModificacionUsuario()
        {
            Data.GetInstance().AgregarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            string nombreAnterior = u2.Nombre;
            Data.GetInstance().ModificarUsuario("", u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(nombreAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Nombre); //CP2

            string apellidoAnterior = u2.Apellido;
            Data.GetInstance().ModificarUsuario(u2.Nombre, "", u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(apellidoAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Apellido); //CP3

            string contraAnterior = u2.Contrasenia;
            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, "", u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(contraAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Contrasenia); //CP4

            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, "nano1001", "nano1001", u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(contraAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Contrasenia); //CP5

            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, "NanoNano", "NanoNano", u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(contraAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Contrasenia); //CP6

            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, "Nano1", "Nano1", u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(contraAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Contrasenia); //CP7

            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, "NanoCanabarro1001", "NanoCanabarro1001", u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(contraAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Contrasenia); //CP8

            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, "Nano1001", "Pablo1001", u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(contraAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Contrasenia); //CP9

            string direccionAnterior = u2.Direccion;
            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, "", u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(direccionAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Direccion); //CP10

            string celAnterior = u2.Telefono_Celular;
            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, "", u2.Email);
            Assert.AreEqual(celAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Telefono_Celular); //CP11

            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, "098", u2.Email);
            Assert.AreEqual(celAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Telefono_Celular); //CP12

            string mailAnterior = u2.Email;
            Data.GetInstance().ModificarUsuario(u2.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, "andrescanabarro.gmail.com");
            Assert.AreEqual(mailAnterior, Data.GetInstance().DevolverUsuario(u2.Email).Email); //CP13

            Data.GetInstance().ModificarUsuario(u1.Nombre, u2.Apellido, u2.Contrasenia, u2.Contrasenia, u2.Direccion, u2.Telefono_Celular, u2.Email);
            Assert.AreEqual(u1.Nombre, Data.GetInstance().DevolverUsuario(u2.Email).Nombre);//CP1
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
