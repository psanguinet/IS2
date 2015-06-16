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
    public partial class ModificarUsuario : MetroFramework.Forms.MetroForm
    {
        private Usuario user;
        public ModificarUsuario(Usuario u)
        {
            InitializeComponent();
            user = u;
            CargarCampos(user);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string resultado = Data.GetInstance().ModificarUsuario(nombre.Text, apellido.Text, contrasenia.Text, confContrasenia.Text, direccion.Text, telefonoCelular.Text, email.Text);
            if (!resultado.Equals(""))
                MessageBox.Show(resultado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Usuario modificado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CargarCampos(Usuario u)
        {
             nombre.Text = u.Nombre;
             apellido.Text = u.Apellido;
             contrasenia.Text = u.Contrasenia;
             confContrasenia.Text = u.Contrasenia;
             telefonoCelular.Text = u.Telefono_Celular;
             direccion.Text = u.Direccion;
             email.Text = u.Email;            
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
