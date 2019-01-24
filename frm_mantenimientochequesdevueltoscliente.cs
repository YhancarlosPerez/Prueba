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
    public partial class mantenimientochequesdevueltoscliente : Form
    {
        public mantenimientochequesdevueltoscliente()
        {
            InitializeComponent();
            dgc_chequedevueltocliente.DataSource = metodos.llenarGridChequeDevueltoCliente();
        }
        libreria metodos = new libreria();
       public static bool RefrescarRegistros = true;

        private void btn_editar_Click(object sender, EventArgs e)
        {
            frm_chequedevueltoslistadocliente frm = new frm_chequedevueltoslistadocliente();
            frm.accion = false;
            frm.id = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("IdCheque");
            frm.cmb_nombrebanco.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("NombreBanco");
            frm.txt_numero.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("NumeroCheque");
            frm.de_fecha.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("FechaCheque");
            frm.cmb_nombrecliente.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("NombreCliente");
            frm.cmb_nombrecuenta.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("NombreCuenta");
            frm.cmb_nocuenta.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("NoCuentaBanco");
            frm.txt_monto.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("MontoCheque");
            frm.txt_comisionbancaria.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("ComisionBancaria");

            if(Convert.ToInt32(dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("CargarComision").ToString()) == 1)
            {
                frm.chk_cargarcomision.Checked = true;
            }
            else
            {
                frm.chk_cargarcomision.Checked = false;
            }

            frm.memo_notas.Text = dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("Notas");

            RefrescarRegistros = false;
            frm.ShowDialog();

            if(RefrescarRegistros)
            {
                dgc_chequedevueltocliente.DataSource = metodos.llenarGridChequeDevueltoCliente();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_chequedevueltocliente.RowCount != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Estas Seguro que Deseas Eliminar el Registro", "Ventana de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    metodos.eliminarChequeDevueltoCliente(Id: dgv_chequedevueltocliente.GetFocusedRowCellDisplayText("IdCheque"));
                    dgc_chequedevueltocliente.DataSource = metodos.llenarGridChequeDevueltoCliente();
                    MessageBox.Show("Registro Eliminado con Exito", "Venana de  Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay Registro para Eliminar", "Venana de  Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientochequesdevueltoscliente_Load(object sender, EventArgs e)
        {

        }
    }
}
