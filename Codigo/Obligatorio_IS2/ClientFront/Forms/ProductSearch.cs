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
            List<Producto> products = new List<Producto>();

            if (searchValue != string.Empty)
            {
                if (rbtNombre.Checked)
                {
                    searchOption = "NOMBRE";
                    product = Data.GetInstance().ListarProductosOrdenados().SingleOrDefault(p => p.Nombre == searchValue);
                    if (product == null)
                    {
                        DialogConfirm dialog = new DialogConfirm(String.Format("El producto de nombre {0}", searchValue, " no se encuentra."));
                    }
                    else
                    {
                        ObjectToForm(product);
                    }
                }
                if (rbtCodigo.Checked)
                {
                    searchOption = "CODIGO";
                    product = Data.GetInstance().ListarProductosOrdenados().SingleOrDefault(p => p.Codigo == searchValue);
                    if (product == null)
                    {
                        DialogConfirm dialog = new DialogConfirm(String.Format("El producto con código {0}", searchValue, " no se encuentra."));
                    }
                    else
                    {
                        ObjectToForm(product);
                    }
                }
                if (rbtRubro.Checked)
                {
                    searchOption = "RUBRO";
                    products = Data.GetInstance().ListarProductosOrdenados().Where(p => p.Rubro == searchValue).ToList();
                    if (product == null)
                    {
                        DialogConfirm dialog = new DialogConfirm(String.Format("No se encuentran productos del rubro {0}", searchValue));
                    }
                }
                if (rbtTipo.Checked)
                {
                    searchOption = "TIPO";
                    products = Data.GetInstance().ListarProductosOrdenados().Where(p => p.Tipo == searchValue).ToList();
                    if (product == null)
                    {
                        DialogConfirm dialog = new DialogConfirm(String.Format("No se encuentran productos del tipo {0}", searchValue));
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: debe ingresar informacion de búsqueda");
            }

        }

        private void ObjectToForm(Producto product)
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
    }
}
