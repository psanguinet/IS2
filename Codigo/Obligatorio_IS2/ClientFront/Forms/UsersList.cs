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
                var usuario = (Model.Usuario)gridUsers.SelectedRows[0].DataBoundItem;
                ModificarUsuario modifUser = new ModificarUsuario(usuario);
                modifUser.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario " + ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (Data.GetInstance().DevolverUsuarios().Count > 0)
            {
                var usuario = (Model.Usuario)gridUsers.SelectedRows[0].DataBoundItem;

                DialogResult dialogResult = MessageBox.Show(string.Format("Realmente desea borrar a {0} {1}", usuario.Nombre, usuario.Apellido), "Atención", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    BusinessLogic.Data.GetInstance().BorrarUsuario(usuario);
                    this.Close();
                    MessageBox.Show(string.Format("El usuario {0} {1} se borró correctamente", usuario.Nombre, usuario.Apellido));
                    //UsersList users = new UsersList();
                    //users.Show();
                }
               
            }
            else
            {
                MessageBox.Show("No hay usuarios en el sistema");
            }

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
