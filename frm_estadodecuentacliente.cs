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
    public partial class frm_estadodecuentacliente : Form
    {
        public frm_estadodecuentacliente()
        {
            InitializeComponent();
            cmb_ver.SelectedIndex = 0;
            de_dia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            de_desde.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
            de_hasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            metodos.llenarComboboxIdNombreCliente(cmb_idcliente, cmb_nombrecliente);
            dgc_estadodecuentacliente.DataSource = metodos.llenarGridConsultaEstadodeCuentaCliente();
            rbtn_cliente.Checked = false;
            cmb_nombrecliente.Enabled = false;
        }
        libreria metodos = new libreria();

        private void cmb_ver_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Por Nombre Cliente.
            if (cmb_ver.SelectedIndex == 0)
            {
                lbl_busqueda.Visible = false;
                de_dia.Visible = false;
                de_desde.Visible = false;
                de_hasta.Visible = false;
            }
            else if (cmb_ver.SelectedIndex == 1)
            {
                //Por Día.
                lbl_busqueda.Text = "Buscar por Día";
                lbl_busqueda.Visible = true;
                de_dia.Visible = true;
                de_desde.Visible = false;
                de_hasta.Visible = false;
            }
            else if (cmb_ver.SelectedIndex == 2)
            {
                //Por Fecha.
                lbl_busqueda.Text = "Buscar por Fecha";
                lbl_busqueda.Visible = true;
                de_dia.Visible = false;
                de_desde.Visible = true;
                de_hasta.Visible = true;
            }
        }

        private void cmb_idcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombrecliente.SelectedIndex = cmb_idcliente.SelectedIndex;
        }

        private void cmb_nombrecliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idcliente.SelectedIndex = cmb_nombrecliente.SelectedIndex;
        }

        private void btn_generarreporte_Click(object sender, EventArgs e)
        {
            if (dgv_estadodecuentacliente.RowCount != 0)
            {
                //Reporte.
                Clientes.Reporte.rpt_estadodecuentacliente reporte = new Clientes.Reporte.rpt_estadodecuentacliente();
                reporte.SetDataSource(dgc_estadodecuentacliente.DataSource as DataTable);

                Form_2 frm = new Form_2();
                frm.crystalReportViewer1.ReportSource = reporte;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Debe de Filtrar los Datos para poder Generar el Reporte", "Ventana de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtn_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_cliente.Checked != true)
            {
                cmb_nombrecliente.Enabled = false;
                cmb_nombrecliente.Text = string.Empty;
            }
            else
            {
                cmb_nombrecliente.Enabled = true;
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
                if (cmb_ver.SelectedIndex == 0)
                {
                    //Todos.
                    dgc_estadodecuentacliente.DataSource = metodos.llenarGridConsultaEstadodeCuentaCliente();
                }
                else if (cmb_ver.SelectedIndex == 1)
                {
                    //Por Día.
                    dgc_estadodecuentacliente.DataSource = metodos.llenarGridConsultaEstadodeCuentaClientePorDia(this);
                }
                else if (cmb_ver.SelectedIndex == 2)
                {
                    //Por Fecha. 
                    dgc_estadodecuentacliente.DataSource = metodos.llenarGridConsultaEstadodeCuentaClientePorFecha(this);
                }
        }
    }
 }
