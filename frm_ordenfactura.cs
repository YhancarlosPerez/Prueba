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
    public partial class frm_ordenfactura : Form
    {
        public frm_ordenfactura()
        {
            InitializeComponent();
        }

        libreria metodos = new libreria();

        private void frm_adelantoorden_Shown(object sender, EventArgs e)
        {
            metodos.LlenarAdelantoORden(dgc_orden,dgv_orden,1);
            dgv_orden.MoveLast();
        }

        private void frm_adelantoorden_Load(object sender, EventArgs e)
        {

        }

        private void dgv_orden_DoubleClick(object sender, EventArgs e)
        {
            DataRow factura = dgv_orden.GetFocusedDataRow();

            frm_reciboingreso recibo = new frm_reciboingreso();
            recibo.StartPosition = FormStartPosition.Manual;
            recibo.Location = new Point(0, 0);
            recibo.MdiParent = this.MdiParent;
            recibo.Show();
            
            ///
            recibo.txt_clienteno.Text = factura[6].ToString();
            recibo.cmb_monedaid.Text = factura[7].ToString();
            ///

            recibo.txt_recibo.Text = factura[2].ToString();
            recibo.txt_monto.Text = factura[5].ToString(); //(/*Convert.ToDecimal(factura[4]) - */Convert.ToDecimal(factura[5])).ToString();
            recibo.me_concepto.Text = "Pago de la Factura No.:" + factura[0].ToString();

            metodos.CodigoDocumento = Convert.ToInt32(factura[0]);
            recibo.MontoFactura = Convert.ToDecimal(factura[5]);
           // this.Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            DataRow factura = dgv_orden.GetFocusedDataRow();

            frm_reciboingreso recibo = new frm_reciboingreso();
            recibo.StartPosition = FormStartPosition.Manual;
            recibo.Location = new Point(0, 0);
            recibo.MdiParent = this.MdiParent;
            recibo.Show();

            ///
            recibo.txt_clienteno.Text = factura[6].ToString();
            recibo.cmb_monedaid.Text = factura[7].ToString();
            ///

            recibo.txt_recibo.Text = factura[2].ToString();
            recibo.txt_monto.Text = factura[5].ToString();
            recibo.me_concepto.Text = "Pago de la Factura No.:" + factura[0].ToString();

            metodos.CodigoDocumento = Convert.ToInt32(factura[0]);
            recibo.MontoFactura = Convert.ToDecimal(factura[5]);
            //this.Close();
        }

        private void cmb_estadofactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            int condicion = cmb_estadofactura.SelectedIndex + 1;
            metodos.LlenarAdelantoORden(dgc_orden, dgv_orden,condicion);
            dgv_orden.MoveLast();
        }

     
    }
}
