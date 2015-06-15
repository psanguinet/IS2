namespace ClientFront.Forms
{
    partial class ProductSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSearch));
            this.txtSearchProducts = new MetroFramework.Controls.MetroTextBox();
            this.rbtNombre = new MetroFramework.Controls.MetroRadioButton();
            this.rbtCodigo = new MetroFramework.Controls.MetroRadioButton();
            this.rbtTipo = new MetroFramework.Controls.MetroRadioButton();
            this.rbtRubro = new MetroFramework.Controls.MetroRadioButton();
            this.btnBuscar = new MetroFramework.Controls.MetroTile();
            this.panelProduct = new MetroFramework.Controls.MetroPanel();
            this.btnSiguiente = new MetroFramework.Controls.MetroTile();
            this.lblPrecioValue = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lblTipoValue = new MetroFramework.Controls.MetroLabel();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.lblRubroValue = new MetroFramework.Controls.MetroLabel();
            this.lblRubro = new MetroFramework.Controls.MetroLabel();
            this.lblNombreValue = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcionValue = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.lblCodigoValue = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Lines = new string[0];
            this.txtSearchProducts.Location = new System.Drawing.Point(23, 74);
            this.txtSearchProducts.MaxLength = 32767;
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.PasswordChar = '\0';
            this.txtSearchProducts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProducts.SelectedText = "";
            this.txtSearchProducts.Size = new System.Drawing.Size(245, 35);
            this.txtSearchProducts.TabIndex = 0;
            this.txtSearchProducts.UseSelectable = true;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Checked = true;
            this.rbtNombre.Location = new System.Drawing.Point(23, 132);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(67, 15);
            this.rbtNombre.TabIndex = 1;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseSelectable = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtNombre_CheckedChanged);
            // 
            // rbtCodigo
            // 
            this.rbtCodigo.AutoSize = true;
            this.rbtCodigo.Location = new System.Drawing.Point(23, 167);
            this.rbtCodigo.Name = "rbtCodigo";
            this.rbtCodigo.Size = new System.Drawing.Size(62, 15);
            this.rbtCodigo.TabIndex = 2;
            this.rbtCodigo.Text = "Código";
            this.rbtCodigo.UseSelectable = true;
            this.rbtCodigo.CheckedChanged += new System.EventHandler(this.rbtCodigo_CheckedChanged);
            // 
            // rbtTipo
            // 
            this.rbtTipo.AutoSize = true;
            this.rbtTipo.Location = new System.Drawing.Point(23, 246);
            this.rbtTipo.Name = "rbtTipo";
            this.rbtTipo.Size = new System.Drawing.Size(47, 15);
            this.rbtTipo.TabIndex = 3;
            this.rbtTipo.Text = "Tipo";
            this.rbtTipo.UseSelectable = true;
            this.rbtTipo.CheckedChanged += new System.EventHandler(this.rbtTipo_CheckedChanged);
            // 
            // rbtRubro
            // 
            this.rbtRubro.AutoSize = true;
            this.rbtRubro.Location = new System.Drawing.Point(23, 206);
            this.rbtRubro.Name = "rbtRubro";
            this.rbtRubro.Size = new System.Drawing.Size(55, 15);
            this.rbtRubro.TabIndex = 4;
            this.rbtRubro.Text = "Rubro";
            this.rbtRubro.UseSelectable = true;
            this.rbtRubro.CheckedChanged += new System.EventHandler(this.rbtRubro_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveControl = null;
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(353, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.TileImage")));
            this.btnBuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.UseTileImage = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.Controls.Add(this.btnSiguiente);
            this.panelProduct.Controls.Add(this.lblPrecioValue);
            this.panelProduct.Controls.Add(this.lblTipoValue);
            this.panelProduct.Controls.Add(this.lblTipo);
            this.panelProduct.Controls.Add(this.lblRubroValue);
            this.panelProduct.Controls.Add(this.lblRubro);
            this.panelProduct.Controls.Add(this.lblNombreValue);
            this.panelProduct.Controls.Add(this.lblNombre);
            this.panelProduct.Controls.Add(this.lblDescripcionValue);
            this.panelProduct.Controls.Add(this.lblDescripcion);
            this.panelProduct.Controls.Add(this.lblCodigoValue);
            this.panelProduct.Controls.Add(this.lblCodigo);
            this.panelProduct.Controls.Add(this.pictureBox);
            this.panelProduct.HorizontalScrollbarBarColor = true;
            this.panelProduct.HorizontalScrollbarHighlightOnWheel = false;
            this.panelProduct.HorizontalScrollbarSize = 10;
            this.panelProduct.Location = new System.Drawing.Point(152, 142);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(613, 435);
            this.panelProduct.TabIndex = 6;
            this.panelProduct.VerticalScrollbarBarColor = true;
            this.panelProduct.VerticalScrollbarHighlightOnWheel = false;
            this.panelProduct.VerticalScrollbarSize = 10;
            this.panelProduct.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.ActiveControl = null;
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.Location = new System.Drawing.Point(438, 386);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(149, 35);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente >>";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.UseSelectable = true;
            this.btnSiguiente.UseTileImage = true;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPrecioValue
            // 
            this.lblPrecioValue.AutoScroll = true;
            this.lblPrecioValue.AutoScrollMinSize = new System.Drawing.Size(104, 48);
            this.lblPrecioValue.AutoSize = false;
            this.lblPrecioValue.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrecioValue.Location = new System.Drawing.Point(31, 171);
            this.lblPrecioValue.Name = "lblPrecioValue";
            this.lblPrecioValue.Size = new System.Drawing.Size(187, 51);
            this.lblPrecioValue.TabIndex = 13;
            this.lblPrecioValue.Text = "Precio";
            // 
            // lblTipoValue
            // 
            this.lblTipoValue.AutoSize = true;
            this.lblTipoValue.Location = new System.Drawing.Point(99, 133);
            this.lblTipoValue.Name = "lblTipoValue";
            this.lblTipoValue.Size = new System.Drawing.Size(81, 19);
            this.lblTipoValue.TabIndex = 12;
            this.lblTipoValue.Text = "lblTipoValue";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(55, 133);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 19);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblRubroValue
            // 
            this.lblRubroValue.AutoSize = true;
            this.lblRubroValue.Location = new System.Drawing.Point(99, 100);
            this.lblRubroValue.Name = "lblRubroValue";
            this.lblRubroValue.Size = new System.Drawing.Size(91, 19);
            this.lblRubroValue.TabIndex = 10;
            this.lblRubroValue.Text = "lblRubroValue";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(45, 100);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(48, 19);
            this.lblRubro.TabIndex = 9;
            this.lblRubro.Text = "Rubro:";
            // 
            // lblNombreValue
            // 
            this.lblNombreValue.AutoSize = true;
            this.lblNombreValue.Location = new System.Drawing.Point(99, 64);
            this.lblNombreValue.Name = "lblNombreValue";
            this.lblNombreValue.Size = new System.Drawing.Size(105, 19);
            this.lblNombreValue.TabIndex = 8;
            this.lblNombreValue.Text = "lblNombreValue";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcionValue
            // 
            this.lblDescripcionValue.AutoSize = true;
            this.lblDescripcionValue.Location = new System.Drawing.Point(8, 269);
            this.lblDescripcionValue.Name = "lblDescripcionValue";
            this.lblDescripcionValue.Size = new System.Drawing.Size(108, 19);
            this.lblDescripcionValue.TabIndex = 6;
            this.lblDescripcionValue.Text = "DescripciónValue";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 234);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCodigoValue
            // 
            this.lblCodigoValue.AutoSize = true;
            this.lblCodigoValue.Location = new System.Drawing.Point(99, 35);
            this.lblCodigoValue.Name = "lblCodigoValue";
            this.lblCodigoValue.Size = new System.Drawing.Size(99, 19);
            this.lblCodigoValue.TabIndex = 4;
            this.lblCodigoValue.Text = "lblCodigoValue";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(37, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(247, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(340, 342);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // ProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rbtRubro);
            this.Controls.Add(this.rbtTipo);
            this.Controls.Add(this.rbtCodigo);
            this.Controls.Add(this.rbtNombre);
            this.Controls.Add(this.txtSearchProducts);
            this.Name = "ProductSearch";
            this.Text = "Búsqueda de productos";
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtSearchProducts;
        private MetroFramework.Controls.MetroRadioButton rbtNombre;
        private MetroFramework.Controls.MetroRadioButton rbtCodigo;
        private MetroFramework.Controls.MetroRadioButton rbtTipo;
        private MetroFramework.Controls.MetroRadioButton rbtRubro;
        private MetroFramework.Controls.MetroTile btnBuscar;
        private MetroFramework.Controls.MetroPanel panelProduct;
        private MetroFramework.Controls.MetroLabel lblDescripcionValue;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroLabel lblCodigoValue;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel lblTipoValue;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private MetroFramework.Controls.MetroLabel lblRubroValue;
        private MetroFramework.Controls.MetroLabel lblRubro;
        private MetroFramework.Controls.MetroLabel lblNombreValue;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Drawing.Html.HtmlLabel lblPrecioValue;
        private MetroFramework.Controls.MetroTile btnSiguiente;
    }
}