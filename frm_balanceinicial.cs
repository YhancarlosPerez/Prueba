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
    public partial class frm_balanceinicial : Form
    {
        libreria metodos = new libreria();

        public bool accion = false;
        public string IdRegistro = string.Empty;
        public frm_balanceinicial()
        {
            InitializeComponent();
            ConsultaPrimeraInstancia();
        }

        public void ConsultaPrimeraInstancia()
        {
            metodos.LlenarComboBoxCliente(cmb_cliente, cmb_ClienteId);
            metodos.LlenarComboBoxMoneda(cmb_moneda, cmb_MonedaId);

            /*if (accion)
            {
                cmb_MonedaId.Text = Moneda;
                cmb_cliente.Text = Cliente;
            }*/
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ClienteId.SelectedIndex = cmb_cliente.SelectedIndex;
        }

        private void cmb_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_MonedaId.SelectedIndex = cmb_moneda.SelectedIndex;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                metodos.BalanceInicialesCliente(this);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe corregir los datos suministrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_balanceinicial_Shown(object sender, EventArgs e)
        {
            if (!accion)
            {
                txt_tasa.Text = "0.00";
                txt_valor.Text = "0.00";
                de_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cmb_moneda.SelectedIndex = 0;
            }
        }

        private bool ValidarDatos()
        {
            bool repuesta = true;
            dxErrorProviderBalance.ClearErrors();
            if (cmb_cliente.Text == string.Empty) { dxErrorProviderBalance.SetError(cmb_cliente, "Debe seleccionar un cliente."); repuesta = false; }
            if (Convert.ToDecimal(txt_valor.Text) <= 0) { dxErrorProviderBalance.SetError(txt_valor, "Debe ingresar un valor mayor a cero."); repuesta = false; }
            return repuesta;
        }

        private void cmb_MonedaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_moneda.SelectedIndex = cmb_MonedaId.SelectedIndex;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //fin
    }
}
