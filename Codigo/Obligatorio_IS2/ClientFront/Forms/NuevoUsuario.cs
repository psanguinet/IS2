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

        private bool MinimosContraseniaMayusNum(string pass)
        {
            char[] numeros = new char[10];
            char[] letras = new char[26];
            string todos = "0123456789";
            string todosLetras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            numeros=todos.ToCharArray();
            letras = todosLetras.ToCharArray();
            return pass.IndexOfAny(numeros, 0)>=0 && pass.IndexOfAny(letras, 0)>=0;
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
            if (!contrasenia.Text.Equals(confContrasenia.Text)) MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!LongitudContraseniaValida(contrasenia.Text)) MessageBox.Show("La contraseña debe tener entre 8 y 14 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!MinimosContraseniaMayusNum(contrasenia.Text)) MessageBox.Show("La contraseña debe contener al menos 1 numero y 1 mayuscula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!TelefonoValido(telefonoCelular.Text)) MessageBox.Show("El telefono debe contener 9 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (FormatoMailAdecuado(email.Text)) MessageBox.Show("El formato del mail no es adecuado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
