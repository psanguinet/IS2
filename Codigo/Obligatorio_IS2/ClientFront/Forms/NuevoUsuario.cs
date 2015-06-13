using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Model;

namespace ClientFront.Forms
{
    public partial class NuevoUsuario : MetroFramework.Forms.MetroForm
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private bool LongitudContraseniaValida(string pass)
        {
            return pass.Length >= 8 && pass.Length <= 14;
        }

        private bool MinimosContraseniaMayus(string pass)
        {
            char[] letras = new char[26];
            string todosLetras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            letras = todosLetras.ToCharArray();
            return pass.IndexOfAny(letras, 0)>=0;
        }
        private bool MinimosContraseniaNum(string pass)
        {
            char[] numeros = new char[10];
            string todos = "0123456789";
            numeros = todos.ToCharArray();
            return pass.IndexOfAny(numeros, 0) >= 0;
        }
        private bool TelefonoValido(string tel)
        {
            return tel.Length == 9;
        }
        private bool FormatoMailAdecuado(string mail)
        {
            try
            {
            MailAddress m = new MailAddress(mail);

            return true;
            }
            catch (Exception)
            {
            return false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (nombre.Text.Equals("")) MessageBox.Show("El nombre no puede ser vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (apellido.Text.Equals("")) MessageBox.Show("El apellido no puede ser vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (contrasenia.Text.Equals("")) MessageBox.Show("La contraseña no puede ser vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!contrasenia.Text.Equals(confContrasenia.Text)) MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!LongitudContraseniaValida(contrasenia.Text)) MessageBox.Show("La contraseña es inválida, debe tener entre 8 y 14 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!MinimosContraseniaMayus(contrasenia.Text)) MessageBox.Show("La contraseña es inválida, debe tener al menos 1 mayúscula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!MinimosContraseniaNum(contrasenia.Text)) MessageBox.Show("La contraseña es inválida, debe tener al menos 1 número", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (direccion.Text.Equals("")) MessageBox.Show("La dirección no puede ser vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (telefonoCelular.Text.Equals("")) MessageBox.Show("El teléfono celular no puede ser vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!TelefonoValido(telefonoCelular.Text)) MessageBox.Show("El telefono debe tener 9 dígitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (FormatoMailAdecuado(email.Text)) MessageBox.Show("El mail es inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Usuario usu = new Usuario()
            {
              Nombre = nombre.Text,
              Apellido = apellido.Text,
              Contrasenia = contrasenia.Text,
              Telefono_Celular = telefonoCelular.Text,
              Direccion = direccion.Text,
              Email = email.Text
            };
            Data.GetInstance().AgregarUsuario(usu);
        }
        
    }
}
