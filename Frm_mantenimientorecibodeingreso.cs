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
    public partial class Frm_mantenimientorecibodeingreso : Form
    {
        public Frm_mantenimientorecibodeingreso()
        {
            InitializeComponent();
            dgc_mantenimientoreciboingreso.DataSource = metodos.llenarGridMantenimientoReciboIngresoCliente();
        }
        libreria metodos = new libreria();

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dgv_mantenimientoreciboingreso.RowCount != 0)
            {
                Clientes.Reporte.rpt_mantenimientorecibodeingreso reporte = new Clientes.Reporte.rpt_mantenimientorecibodeingreso();
                reporte.SetDataSource(dgc_mantenimientoreciboingreso.DataSource as DataTable);

                reporte.SetParameterValue("Fecha", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Fecha"));
                reporte.SetParameterValue("Monto", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Monto"));
                reporte.SetParameterValue("No.Recibo", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("IdRecibo"));
                reporte.SetParameterValue("Cliente", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Cliente"));
                reporte.SetParameterValue("Suma", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Suma"));
                reporte.SetParameterValue("No.Cliente", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("IdCliente"));
                reporte.SetParameterValue("Concepto", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Concepto"));
                reporte.SetParameterValue("Efectivo", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Efectivo"));
                reporte.SetParameterValue("Cheque", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Cheque"));
                reporte.SetParameterValue("Targ.Credito", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("TargCredito"));
                reporte.SetParameterValue("Trans.Elect", dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("TransElectronica"));

                Form_2 frm = new Form_2();
                frm.crystalReportViewer1.ReportSource = reporte;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Debe de Filtrar los Datos para poder Generar el Reporte", "Ventana de Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Pendiente para Trabajar Yhancarlos Perez
            //------------------------------------------

            //Llamado al Formulario Recibo de Ingreso.
            frm_reciboingreso frm = new frm_reciboingreso();

            //frm.txt_recibo.Text 
            frm.txt_recibono.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("IdRecibo");
            frm.txt_recibo.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Cliente");
            frm.txt_fecha.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Fecha");
            frm.txt_suma.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Suma");
            frm.txt_monto.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Monto");
            frm.txt_montodescuento.Text = "0.00";
            frm.me_concepto.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("Concepto");
            frm.txt_clienteno.Text = dgv_mantenimientoreciboingreso.GetFocusedRowCellDisplayText("IdCliente");
            frm.Show();

        }
    }
}
