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
        public List<Producto> Products = new List<Producto>();
        private int position { get; set; }
        public ProductSearch()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchValue = this.txtSearchProducts.Text;
            string searchOption = string.Empty;
            Producto product = null;
            Products = new List<Producto>();

            BusinessLogic.Data info = new BusinessLogic.Data();
            if (searchValue != string.Empty)
            {
                if (rbtNombre.Checked)
                {
                    ShowProductByName(searchValue, ref searchOption, ref product, info);
                }
                if (rbtCodigo.Checked)
                {
                    ShowProductByCode(searchValue, ref searchOption, ref product, info);
                }
                if (rbtRubro.Checked)
                {
                    ShowProductByRubro(searchValue, ref searchOption, info);
                }
                if (rbtTipo.Checked)
                {
                    ShowProductByTipo(searchValue, ref searchOption, info);
                }
            }
            else
            {
                MessageBox.Show("Error: debe ingresar informacion de búsqueda");
            }

        }

        private void ShowProductByTipo(string searchValue, ref string searchOption, BusinessLogic.Data info)
        {
            searchOption = "TIPO";
            Products = info.ListarProductosOrdenados().Where(p => p.Tipo.ToUpper() == searchValue.ToUpper()).ToList();
            if (Products.Count == 0)
            {
                MessageBox.Show(String.Format("No se encuentran productos del tipo {0}", searchValue));
            }
            else
            {
                position = 0;
                Producto product = Products.ElementAt<Producto>(position);
                ObjectToForm(product);
                this.btnSiguiente.Visible = true;
            }
        }

        private void ShowProductByRubro(string searchValue, ref string searchOption, BusinessLogic.Data info)
        {
            searchOption = "RUBRO";
            Products = info.ListarProductosOrdenados().Where(p => p.Rubro.ToUpper() == searchValue.ToUpper()).ToList();
            if (Products.Count == 0)
            {
                MessageBox.Show(String.Format("No se encuentran productos del rubro {0}", searchValue));
            }
            else
            {
                position = 0;
                Producto product = Products.ElementAt<Producto>(position);
                ObjectToForm(product);
                this.btnSiguiente.Visible = true;
            }
        }

        private void ShowProductByCode(string searchValue, ref string searchOption, ref Producto product, BusinessLogic.Data info)
        {
            searchOption = "CODIGO";
            product = info.ListarProductosOrdenados().SingleOrDefault(p => p.Codigo == searchValue);
            if (product == null)
            {
                MessageBox.Show(String.Format("El producto con código {0} no se encuentra.", searchValue));
            }
            else
            {
                ObjectToForm(product);
            }
        }

        private void ShowProductByName(string searchValue, ref string searchOption, ref Producto product, BusinessLogic.Data info)
        {
            searchOption = "NOMBRE";
            product = info.ListarProductosOrdenados().SingleOrDefault(p => p.Nombre.ToUpper() == searchValue.ToUpper());
            if (product == null)
            {
                MessageBox.Show(String.Format("El producto de nombre {0} no se encuentra.", searchValue));
            }
            else
            {
                ObjectToForm(product);
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            position++;
            if (position < Products.Count)
            {
                ObjectToForm(Products.ElementAt(position));
            }
            else
            {
                position = 0;
                ObjectToForm(Products.ElementAt(position));
            }
        }
    }
}
