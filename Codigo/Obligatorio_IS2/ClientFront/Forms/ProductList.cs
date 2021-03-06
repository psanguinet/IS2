﻿using System;
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
    public partial class ProductList : MetroFramework.Forms.MetroForm
    {
        public ProductList()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                this.gridProducts.DataSource = Data.GetInstance().ListarProductosOrdenados();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
