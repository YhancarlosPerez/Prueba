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
    public partial class frm_mantenimientochequesdevueltospagos : Form
    {
        public frm_mantenimientochequesdevueltospagos()
        {
            InitializeComponent();
            dgc_chequesdevueltospagos.DataSource = metodos.llenarGridChequesDevueltosPagos();
        }
        libreria metodos = new libreria();
        public static bool RefrescarRegistros = true;

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            frm_chequesdevueltospagos frm = new frm_chequesdevueltospagos();
            frm.txt_idfactura.Text = dgv_chequesdevueltospagos.GetFocusedRowCellDisplayText("Idfactura");
            frm.txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            frm.txt_recibidode.Text = dgv_chequesdevueltospagos.GetFocusedRowCellDisplayText("Cliente");
            frm.txt_monto.Text = dgv_chequesdevueltospagos.GetFocusedRowCellDisplayText("Balance");
            frm.cmb_idmoneda.Text = dgv_chequesdevueltospagos.GetFocusedRowCellDisplayText("CodigoMoneda");
            frm.cmb_nombremoneda.Text = dgv_chequesdevueltospagos.GetFocusedRowCellDisplayText("Moneda");
            frm.memo_notas.Text = dgv_chequesdevueltospagos.GetFocusedRowCellDisplayText("Concepto");

            RefrescarRegistros = false;
            frm.ShowDialog();
            if (RefrescarRegistros)
            {
                dgc_chequesdevueltospagos.DataSource = metodos.llenarGridChequesDevueltosPagos();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_mantenimientochequesdevueltospagos_Load(object sender, EventArgs e)
        {

        }
    }
}

