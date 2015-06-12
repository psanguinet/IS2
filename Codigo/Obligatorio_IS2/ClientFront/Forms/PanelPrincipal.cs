using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFront.Forms
{
    public partial class PanelPrincipal : MetroFramework.Forms.MetroForm
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void btnListUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                UsersList users = new UsersList();
                users.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el listado de productos " + ex.Message);
            }
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            try
            {
                ProductList products = new ProductList();
                products.Show();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show("Error al mostrar el listado de productos " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)

        {
            try
            {
                DialogConfirm dialog = new DialogConfirm("Desea salir del Sitema?");
                dialog.ShowDialog();
                            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al salir del sitema " + ex.Message);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductSearch productsSearch = new ProductSearch();
                productsSearch.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar productos " + ex.Message);
            }
        }
    }
}
