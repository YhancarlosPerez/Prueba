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
    public partial class frm_historicoreciboingreso : Form
    {
        public frm_historicoreciboingreso()
        {
            InitializeComponent();
            cmb_ver.SelectedIndex = 0;
            de_dia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_desde.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dgc_historicorecibodeingreso.DataSource = metodos.llenarGridConsultaReciboIngresoCliente();
        }
        libreria metodos = new libreria();
        private void frm_historicoreciboingreso_Load(object sender, EventArgs e)
        {

        }

        private void cmb_ver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ver.SelectedIndex == 0)
            {   
                //Todos.
                txt_busqueda.Visible = false;
                lbl_busqueda.Visible = false;
                txt_busqueda.Visible = false;
                de_dia.Visible = false;
                de_desde.Visible = false;
                de_hasta.Visible = false;
                txt_busqueda.Text = string.Empty;
            }
            else if (cmb_ver.SelectedIndex == 1)
            {
                //Por Nombre Cliente.
                lbl_busqueda.Text = "Buscar por Nombre";
                lbl_busqueda.Visible = true;
                txt_busqueda.Visible = true;
                de_dia.Visible = false;
                de_desde.Visible = false;
                de_hasta.Visible = false;
            }
            else if (cmb_ver.SelectedIndex == 2)
            {
                //Por Día.
                txt_busqueda.Visible = false;
                lbl_busqueda.Text = "Buscar por Día";
                lbl_busqueda.Visible = true;
                de_dia.Visible = true;
                de_desde.Visible = false;
                de_hasta.Visible = false;
                txt_busqueda.Text = string.Empty;
            }
            else if(cmb_ver.SelectedIndex == 3)
            {
                //Por Fecha.
                txt_busqueda.Visible = false;
                lbl_busqueda.Text = "Buscar por Fecha";
                lbl_busqueda.Visible = true;
                de_dia.Visible = false;
                de_desde.Visible = true;
                de_hasta.Visible = true;
                txt_busqueda.Text = string.Empty;
           }
        }

        private void btn_generarreporte_Click(object sender, EventArgs e)
        {
            //Reporte Historico Recibo de Ingreso Cliente.
            if (dgv_historicorecibodeingreso.RowCount != 0)
            {
                Clientes.Reporte.rpt_historicocliente reporte = new Clientes.Reporte.rpt_historicocliente();
                reporte.SetDataSource(dgc_historicorecibodeingreso.DataSource as DataTable);

                Form_2 frm = new Form_2();
                frm.crystalReportViewer1.ReportSource = reporte;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Debe de Filtrar los Datos para poder Generar el Reporte", "Ventana de Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
 
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (cmb_ver.SelectedIndex == 0)
            {
            //Todos.
            dgc_historicorecibodeingreso.DataSource = metodos.llenarGridConsultaReciboIngresoCliente();
            }
            else if (cmb_ver.SelectedIndex == 1)
            {
            //Nombre Cliente.
            dgc_historicorecibodeingreso.DataSource = metodos.consultaHistoricoFiltroNombreCliente(this);
            }
            else if (cmb_ver.SelectedIndex == 2)
            {
            //Por Día.
            dgc_historicorecibodeingreso.DataSource = metodos.consultaHistoricoFiltroPorDia(this);
            }
            else if (cmb_ver.SelectedIndex == 3)
            {
            //Por Fecha.
            dgc_historicorecibodeingreso.DataSource = metodos.consultaHistoricoFiltroPorFecha(this);
            }
        }
    }
}
