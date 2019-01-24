using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace erp_businessflex
{
    public partial class frm_generarrecibo : Form
    {
        public frm_generarrecibo()
        {
            InitializeComponent();
        }

        private void btn_pagofactura_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_ordenfactura factura = new frm_ordenfactura();
            factura.StartPosition = FormStartPosition.Manual;
            factura.Location = new Point(0, 0);
            factura.MdiParent = this.MdiParent;
            factura.Show();
            
            this.Close();
        }
    }
}
