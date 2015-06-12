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
    public partial class DialogConfirm : MetroFramework.Forms.MetroForm
    {
        public DialogConfirm(String message)
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void lnkCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
