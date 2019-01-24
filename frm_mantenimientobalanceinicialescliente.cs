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
    public partial class frm_mantenimientobalanceinicialescliente : Form
    {
        libreria metodos = new libreria();
        public frm_mantenimientobalanceinicialescliente()
        {
            InitializeComponent();
            de_hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_desde.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");

            dgc_mantenimientobalanceiniciales.DataSource = metodos.MostrarRegistroBalanceInicialesClientePrimeraInstancia();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            frm_balanceinicial frm = new frm_balanceinicial();
            frm.accion = true;
            frm.IdRegistro = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("id_kardexclientemaestro");
            frm.de_fecha.Text = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("fecha");
            frm.txt_valor.Text = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("valor");            
            frm.txt_tasa.Text = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("MontoTasa");
            frm.memo_notas.Text = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("nota");
            metodos.FormatoFormulario(frm);
            frm.ConsultaPrimeraInstancia();
            frm.cmb_cliente.Text = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("cliente");
            frm.cmb_MonedaId.Text = dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("CodigoMoneda");
            frm.ShowDialog();
            dgc_mantenimientobalanceiniciales.DataSource = metodos.MostrarRegistroBalanceInicialesClientePrimeraInstancia();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro/a que desea eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                metodos.EliminarBalanceInicialCliente(dgv_mantenimientobalanceiniciales.GetFocusedRowCellDisplayText("id_kardexclientemaestro"));
                dgc_mantenimientobalanceiniciales.DataSource = metodos.MostrarRegistroBalanceInicialesClientePrimeraInstancia();
                MessageBox.Show("Registro eliminado con exito.", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            dgc_mantenimientobalanceiniciales.DataSource = metodos.MostrarRegistroBalanceInicialesClienteDesdeHasta(de_desde.DateTime.ToString("yyyy-MM-dd"), de_hasta.DateTime.ToString("yyyy-MM-dd"));
        }
    }
}
