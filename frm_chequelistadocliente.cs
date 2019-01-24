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
    public partial class frm_chequedevueltoslistadocliente : Form
    {
        public frm_chequedevueltoslistadocliente()
        {
            InitializeComponent();
            metodos.llenarComboboxIdBancoCliente(cmb_idbanco, cmb_nombrebanco);
            metodos.llenarComboboxIdCliente(cmb_idcliente, cmb_nombrecliente);
            metodos.llenarComboboxCuentaBancoIdNombreCliente(cmb_idnombrecuenta, cmb_nombrecuenta, cmb_nocuenta);
            de_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        libreria metodos = new libreria();
        public string id;
        public bool accion = true;

        private void cmb_idbanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombrebanco.SelectedIndex = cmb_idbanco.SelectedIndex;
        }

        private void cmb_nombrebanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idbanco.SelectedIndex = cmb_nombrebanco.SelectedIndex;
        }

        private void cmb_idcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombrecliente.SelectedIndex = cmb_idcliente.SelectedIndex;
        }

        private void cmb_nombrecliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idcliente.SelectedIndex = cmb_nombrecliente.SelectedIndex;
        }

        private void cmb_idnombrecuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_nombrecuenta.SelectedIndex = cmb_nocuenta.SelectedIndex = cmb_idnombrecuenta.SelectedIndex;
        }

        private void cmb_nombrecuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idnombrecuenta.SelectedIndex = cmb_nocuenta.SelectedIndex = cmb_nombrecuenta.SelectedIndex;
        }

        private void cmb_nocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_idnombrecuenta.SelectedIndex = cmb_nombrecuenta.SelectedIndex = cmb_nocuenta.SelectedIndex;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            mantenimientochequesdevueltoscliente.RefrescarRegistros = true;
              
            metodos.mantenimientoChequesDevueltosCliente(this);

            MessageBox.Show(id);
            metodos.ValidarProcesoKardex(this.Name);
            if (metodos.EjecutarProcesoKardex == true)
            {
                metodos.UtilizarProcedimientosKardexGenerar(metodos.NombreProcesoKardex, "6", "1", id);
            }
            this.Close();
        }
        private void frm_chequedevueltoslistadocliente_Shown(object sender, EventArgs e)
        {
            if (accion == true)
            {
                txt_monto.Text = "0.00";
                txt_comisionbancaria.Text = "0.00";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frm_chequedevueltoslistadocliente_Load(object sender, EventArgs e)
        {

        }
    }
}
