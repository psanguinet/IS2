using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace ClientFront.Forms
{
    public partial class UsersList : MetroFramework.Forms.MetroForm
    {
        public UsersList()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            try
            {
                this.gridUsers.DataSource = Data.GetInstance().DevolverUsuarios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoUsuario newUser = new NuevoUsuario();
                newUser.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar nuevo usuario " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioAModif = 0;
                ModificarUsuario modifUser = new ModificarUsuario(Data.GetInstance().DevolverUsuarios().ElementAt(usuarioAModif));
                modifUser.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario " + ex.Message);
            }
        }
    }
}
