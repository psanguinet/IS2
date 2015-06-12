using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace ClientFront.Forms
{
    public partial class ProductSearch : MetroFramework.Forms.MetroForm
    {
        public ProductSearch()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = this.txtSearchProducts.Text;
            string searchOption = string.Empty;
            Producto product = null;
            BusinessLogic.Data info = new BusinessLogic.Data();
            if (searchValue != string.Empty)
            {
                if (rbtNombre.Checked)
                {
                    searchOption = "NOMBRE";
                    product = info.ListarProductosOrdenados().SingleOrDefault(p => p.Nombre == searchValue);
                }
                if (rbtCodigo.Checked)
                {
                    searchOption = "CODIGO";
                    product = info.ListarProductosOrdenados().SingleOrDefault(p => p.Codigo == searchValue);
                }
                if (rbtRubro.Checked)
                {
                    searchOption = "RUBRO";
                    product = info.ListarProductosOrdenados().SingleOrDefault(p => p.Rubro == searchValue);
                }
                if (rbtTipo.Checked)
                {
                    searchOption = "TIPO";
                    product = info.ListarProductosOrdenados().SingleOrDefault(p => p.Tipo == searchValue);
                }
                if (product != null)
                {
                    lblCodigoValue.Text = product.Codigo;
                    lblNombreValue.Text = product.Nombre;
                    lblRubroValue.Text = product.Rubro;
                    lblTipoValue.Text = product.Tipo;
                    lblPrecioValue.Text = "$ " + product.Precio;
                    lblDescripcionValue.Text = product.Descripcion;
                    pictureBox.Image = product.Imagen;
                    panelProduct.Visible = true;
                }
                else
                {
                    MessageBox.Show("No existe ningun producto");
                }
                
            }
            else
            {
                MessageBox.Show("Error: debe ingresar informacion de búsqueda");
            }
           




        }
    }
}
