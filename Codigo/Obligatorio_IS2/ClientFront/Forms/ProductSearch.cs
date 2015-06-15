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
using BusinessLogic;

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

           
            if (searchValue != string.Empty)
            {
                if (rbtNombre.Checked)
                {
                    ShowProductByName(searchValue, ref product);
                }
                if (rbtCodigo.Checked)
                {
                    ShowProductByCode(searchValue, ref product);
                }
                if (rbtRubro.Checked)
                {
                    ShowProductByRubro(searchValue);
                }
                if (rbtTipo.Checked)
                {
                    ShowProductByType(searchValue);
                }
            }
            else
            {
                MessageBox.Show("Error: debe ingresar informacion de búsqueda");
            }

        }

        private void ShowProductByType(string searchValue)
        {
            Products = Data.GetInstance().GetProductosByType(searchValue);
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

        private void ShowProductByRubro(string searchValue)
        {
            Products = Data.GetInstance().GetProductosByCategory(searchValue);
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

        private void ShowProductByCode(string searchValue, ref Producto product)
        {
            product = Data.GetInstance().GetProductoByCode(searchValue);
            if (product == null)
            {
                MessageBox.Show(String.Format("El producto con código {0} no se encuentra.", searchValue));
            }
            else
            {
                ObjectToForm(product);
            }
        }

        private void ShowProductByName(string searchValue, ref Producto product)
        {
            product = Data.GetInstance().GetProductByName(searchValue);
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

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSiguiente.Visible = false;
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSiguiente.Visible = false;
        }

        private void rbtRubro_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSiguiente.Visible = false;
        }

        private void rbtTipo_CheckedChanged(object sender, EventArgs e)
        {
            this.btnSiguiente.Visible = false;
        }
    }
}
