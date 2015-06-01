namespace Obligatorio_IS2
{
    partial class DialogConfirm
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
            this.lblMessage = new MetroFramework.Controls.MetroLabel();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.lnkCancel = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(99, 97);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(236, 19);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Está seguro que desea salir del sistema";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(234, 139);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(119, 38);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lnkCancel
            // 
            this.lnkCancel.Location = new System.Drawing.Point(52, 148);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(94, 18);
            this.lnkCancel.TabIndex = 2;
            this.lnkCancel.Text = "[ Cancelar ]";
            this.lnkCancel.UseSelectable = true;
            this.lnkCancel.Click += new System.EventHandler(this.lnkCancel_Click);
            // 
            // DialogConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 200);
            this.Controls.Add(this.lnkCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblMessage);
            this.Name = "DialogConfirm";
            this.Text = "Atención";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblMessage;
        private MetroFramework.Controls.MetroButton btnAccept;
        private MetroFramework.Controls.MetroLink lnkCancel;
    }
}