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
    public partial class frm_mantenimientoencuentasporcobrar : Form
    {
        public frm_mantenimientoencuentasporcobrar()
        {
            InitializeComponent();
            dgc_cuentasporcobrar.DataSource =  metodos.llenarGridCuentasporCobrarClienteFactura();
            txt_monto.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("total_facturamaestro");
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        libreria metodos = new libreria();
        public static bool RefrescarRegistros = true;

        private void dgv_cuentasporcobrar_Click(object sender, EventArgs e)
        {
            txt_monto.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("total_facturamaestro");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            frm_descuentoencuentasporcobrar frm = new frm_descuentoencuentasporcobrar();

            frm.txt_idfactura.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("id_facturamaestro");
            frm.txt_cliente.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("nombre_clientemaestro");
            frm.txt_monto.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("total_facturamaestro");
            frm.cmb_idmoneda.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("codigomoneda_facturamaestro");
            frm.cmb_nombremoneda.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("Moneda");
            frm.memo_concepto.Text = dgv_cuentasporcobrar.GetFocusedRowCellDisplayText("nota_facturamaestro");

            RefrescarRegistros = false;
            frm.ShowDialog();
            if (RefrescarRegistros)
            {
                dgc_cuentasporcobrar.DataSource = metodos.llenarGridCuentasporCobrarClienteFactura();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
