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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string resultado = Data.GetInstance().AgregarUsuario(nombre.Text, apellido.Text, contrasenia.Text, confContrasenia.Text, direccion.Text, telefonoCelular.Text, email.Text);
           if (!resultado.Equals(""))
            MessageBox.Show(resultado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           else
               MessageBox.Show("Usuario agregado correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
