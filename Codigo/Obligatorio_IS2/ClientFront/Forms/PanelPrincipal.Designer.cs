﻿namespace ClientFront.Forms
{
    partial class PanelPrincipal
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
            this.btnListUsuarios = new MetroFramework.Controls.MetroTile();
            this.btnProductList = new MetroFramework.Controls.MetroTile();
            this.btnExit = new MetroFramework.Controls.MetroTile();
            this.btnBuscarProducto = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnListUsuarios
            // 
            this.btnListUsuarios.ActiveControl = null;
            this.btnListUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListUsuarios.Location = new System.Drawing.Point(542, 91);
            this.btnListUsuarios.Name = "btnListUsuarios";
            this.btnListUsuarios.Size = new System.Drawing.Size(220, 100);
            this.btnListUsuarios.TabIndex = 4;
            this.btnListUsuarios.Text = "Gestión de Usuarios";
            this.btnListUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUsuarios.UseSelectable = true;
            this.btnListUsuarios.Click += new System.EventHandler(this.btnListUsuarios_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.ActiveControl = null;
            this.btnProductList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductList.Location = new System.Drawing.Point(59, 226);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(220, 100);
            this.btnProductList.TabIndex = 5;
            this.btnProductList.Text = "Listado de Productos";
            this.btnProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductList.UseSelectable = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveControl = null;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(542, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 100);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Salir del Sistema";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.ActiveControl = null;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.Location = new System.Drawing.Point(59, 91);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(220, 100);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.Text = "Buscar Productos";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.UseSelectable = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnListUsuarios);
            this.Name = "PanelPrincipal";
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnListUsuarios;
        private MetroFramework.Controls.MetroTile btnProductList;
        private MetroFramework.Controls.MetroTile btnExit;
        private MetroFramework.Controls.MetroTile btnBuscarProducto;
    }
}

