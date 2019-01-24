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
    public partial class frm_chequesdevueltospagos : Form
    {
        public frm_chequesdevueltospagos()
        {
            InitializeComponent();
            metodos.llenarComboboxMoneda(cmb_idmoneda, cmb_nombremoneda);
        }
        libreria metodos = new libreria();
        private void txt_idfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_recibidode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_nombremoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idmoneda.SelectedIndex = cmb_nombremoneda.SelectedIndex;
        }

        private void cmb_idmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombremoneda.SelectedIndex = cmb_idmoneda.SelectedIndex;
        }

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            frm_mantenimientochequesdevueltospagos.RefrescarRegistros = true;
            metodos.actualizarChequesDevueltosPagos(this);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
