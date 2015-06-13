using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net.Mail;

namespace BusinessLogic
{
    public class Data
    {
        private static List<Producto> productos;
        private static List<Usuario> usuarios;
        private static Data instance;

        public static Data GetInstance()
        {
            if (instance == null) instance = new Data();
            return instance;
        }
        private Data()
        {
            productos = CargarProductos();
            usuarios = CargarUsuarios();
        }

        private List<Usuario> CargarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            Usuario u1= new Usuario()
            {
                 Apellido = "Sanguinet",
                 Contrasenia = "Pablo1234",
                 Direccion = "Uruguay 1275",
                 Email = "psanguinet@gmail.com",
                 Nombre = "Pablo",
                 Telefono_Celular = "094000444"
            };
            Usuario u2 = new Usuario()
            {
                Apellido = "Canabarro",
                Contrasenia = "andresito",
                Direccion = "Bulevar Espania 2873",
                Email = "andrescanabarro@gmail.com",
                Nombre = "Andres",
                Telefono_Celular = "098657882"
            };
            lista.Add(u1);
            lista.Add(u2);
            return lista;
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

        public List<Usuario> DevolverUsuarios()
        {
            return usuarios;
        }

        public void BorrarUsuario(Usuario u)
        {
            usuarios.Remove(u);
        }

        public List<Producto> ListarProductosOrdenados()
        {
             return productos.OrderBy(n=>n.Nombre).ToList<Producto>();
             
        }

        public bool LongitudContraseniaValida(string pass)
        {
            return pass.Length >= 8 && pass.Length <= 14;
        }

        public bool MinimosContraseniaMayus(string pass)
        {
            char[] letras = new char[26];
            string todosLetras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            letras = todosLetras.ToCharArray();
            return pass.IndexOfAny(letras, 0)>=0;
        }
        public bool MinimosContraseniaNum(string pass)
        {
            char[] numeros = new char[10];
            string todos = "0123456789";
            numeros = todos.ToCharArray();
            return pass.IndexOfAny(numeros, 0) >= 0;
        }
        public bool TelefonoValido(string tel)
        {
            return tel.Length == 9;
        }
        public bool FormatoMailAdecuado(string mail)
        {
            try
            {
                if (mail.Equals("")) return false;
            MailAddress m = new MailAddress(mail);
            return true;
            }
            catch (FormatException)
            {
            return false;
            }
        }

        public string AgregarUsuario(string nombre, string apellido, string contrasenia, string confContrasenia, string direccion, string telefonoCelular, string email)
        {
            if (nombre.Equals(""))return "El nombre no puede ser vacio";
            if (apellido.Equals("")) return "El apellido no puede ser vacio";
            if (contrasenia.Equals("")) return "La contraseña no puede ser vacía";
            if (!contrasenia.Equals(confContrasenia)) return "Las contraseñas no coinciden";
            if (!LongitudContraseniaValida(contrasenia)) return "La contraseña es inválida, debe tener entre 8 y 14 caracteres";
            if (!MinimosContraseniaMayus(contrasenia)) return "La contraseña es inválida, debe tener al menos 1 mayúscula";
            if (!MinimosContraseniaNum(contrasenia)) return "La contraseña es inválida, debe tener al menos 1 número";
            if (direccion.Equals("")) return "La dirección no puede ser vacía";
            if (telefonoCelular.Equals("")) return "El teléfono celular no puede ser vacio";
            if (!TelefonoValido(telefonoCelular)) return "El telefono debe tener 9 dígitos";
            if (FormatoMailAdecuado(email)) return "El mail es inválido";

            Usuario usu = new Usuario()
            {
              Nombre = nombre,
              Apellido = apellido,
              Contrasenia = contrasenia,
              Telefono_Celular = telefonoCelular,
              Direccion = direccion,
              Email = email
            };
            usuarios.Add(usu);
            return "";
        }

        public string ModificarUsuario(string nombre, string apellido, string contrasenia, string confContrasenia, string direccion, string telefonoCelular, string email)
        {
            if (nombre.Equals("")) return "El nombre no puede ser vacio";
            if (apellido.Equals("")) return "El apellido no puede ser vacio";
            if (contrasenia.Equals("")) return "La contraseña no puede ser vacía";
            if (!contrasenia.Equals(confContrasenia)) return "Las contraseñas no coinciden";
            if (!LongitudContraseniaValida(contrasenia)) return "La contraseña es inválida, debe tener entre 8 y 14 caracteres";
            if (!MinimosContraseniaMayus(contrasenia)) return "La contraseña es inválida, debe tener al menos 1 mayúscula";
            if (!MinimosContraseniaNum(contrasenia)) return "La contraseña es inválida, debe tener al menos 1 número";
            if (direccion.Equals("")) return "La dirección no puede ser vacía";
            if (telefonoCelular.Equals("")) return "El teléfono celular no puede ser vacio";
            if (!TelefonoValido(telefonoCelular)) return "El telefono debe tener 9 dígitos";
            if (!FormatoMailAdecuado(email)) return "El mail es inválido";

            Usuario usu = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Contrasenia = contrasenia,
                Telefono_Celular = telefonoCelular,
                Direccion = direccion,
                Email = email
            };
            usuarios.Remove(usu);
            usuarios.Add(usu);
            return "";
        
        }
    }
}
