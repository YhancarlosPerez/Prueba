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
    public partial class frm_descuentoencuentasporcobrar : Form
    {
        public frm_descuentoencuentasporcobrar()
        {
            InitializeComponent();
            metodos.llenarComboboxMoneda(cmb_idmoneda, cmb_nombremoneda);
            metodos.llenarComboboxRetencion(cmb_idtiporetencion, cmb_nombretiporetencion);
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        libreria metodos = new libreria();
        private void cmb_idmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombremoneda.SelectedIndex = cmb_idmoneda.SelectedIndex;
        }

        private void cmb_nombremoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idmoneda.SelectedIndex = cmb_nombremoneda.SelectedIndex;
        }

        private void cmb_idtiporetencion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombretiporetencion.SelectedIndex = cmb_idtiporetencion.SelectedIndex;
        }

        private void cmb_nombretiporetencion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idtiporetencion.SelectedIndex = cmb_nombretiporetencion.SelectedIndex;
        }

        private void txt_idfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            frm_mantenimientoencuentasporcobrar.RefrescarRegistros = true;
            metodos.actualizarDescuentoenCuentasporCobrarFactura(this);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
