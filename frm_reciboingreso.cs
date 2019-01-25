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
    public partial class frm_reciboingreso : Form
    {
        public frm_reciboingreso()
        {
            InitializeComponent();
        }

        clsnumeroletra NumerosAletras = new clsnumeroletra();
        libreria metodos = new libreria();
        public static string id;

        private decimal _MontoFactura = 0;
        /// <summary>
        /// Se usa para almacenar el monto de la factura.
        /// </summary>
        public decimal MontoFactura
        {
            set
            {
                _MontoFactura = value;
            }
            get
            {
                return _MontoFactura;
            }
        }

        private void frm_reciboingreso_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = metodos.Fecha;
            metodos.LlenarCmbRecibo(cmb_tiporetencion, cmb_tiporetencionid);
            cmb_tiporetencion.SelectedIndex = 0;

            metodos.LlenarCmbMoneda(cmb_moneda, cmb_monedaid);
            
        }

        private void txt_monto_Leave(object sender, EventArgs e)
        {
            txt_suma.Text = NumerosAletras.NumeroLetra(txt_monto.Text);

            //decimal monto = Convert.ToDecimal(txt_monto.Text);
            //txt_montodescuento.Text = ( _MontoFactura - monto ).ToString();
            
        }

        private void cmb_tiporetencion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_tiporetencionid.SelectedIndex = cmb_tiporetencion.SelectedIndex;
        }

       

    

        private void cbtn_cheque_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbtn_cheque.Checked == true)
            {
                txt_cheque.Visible = true;
                txt_montocheque.Visible = true;
                txt_cheque.Text = string.Empty;
                txt_montocheque.Text = "0.00";
            }
            else
            {
                txt_cheque.Visible = false;
                txt_montocheque.Visible = false;
                txt_cheque.Text = string.Empty;
                txt_montocheque.Text = "0.00";
            }

            CalcularMontoPagar();
        }

        private void cbtn_tarjetadecredito_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbtn_tarjetadecredito.Checked == true)
            {
                txt_tarjaetadecredito.Visible = true;
                txt_montotarjetadecredito.Visible = true;
                txt_tarjaetadecredito.Text = string.Empty;
                txt_montotarjetadecredito.Text = "0.00";
            }
            else
            {
                txt_tarjaetadecredito.Visible = false;
                txt_montotarjetadecredito.Visible = false;
                txt_tarjaetadecredito.Text = string.Empty;
                txt_montotarjetadecredito.Text = "0.00";
            }

            CalcularMontoPagar();
        }

        private void cbtn_transferenciaelectronica_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbtn_transferenciaelectronica.Checked == true)
            {
                txt_transferecniaelectronica.Visible = true;
                txt_montotransferenciaelectronica.Visible = true;
                txt_montotransferenciaelectronica.Text = "0.00";
                txt_transferecniaelectronica.Text = string.Empty;
            }
            else
            {
                txt_transferecniaelectronica.Visible = false;
                txt_montotransferenciaelectronica.Visible = false;
                txt_montotransferenciaelectronica.Text = "0.00";
                txt_transferecniaelectronica.Text = string.Empty;
            }

            CalcularMontoPagar();
        }

        private void cbtn_creditocliente_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbtn_creditocliente.Checked == true)
            {
                txt_creditocliente.Visible = true;
                txt_creditocliente.Text = "0.00";
            }
            else
            {
                txt_creditocliente.Visible = false;
                txt_creditocliente.Text = "0.00";
            }

            CalcularMontoPagar();
        }

        private void cbtn_efectivo_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbtn_efectivo.Checked == true)
            {
                txt_efectivo.Visible = true;
                txt_efectivo.Text = txt_monto.Text;
            }
            else
            {
                txt_efectivo.Visible = false;
            }

            CalcularMontoPagar();
        }

        private void frm_reciboingreso_Shown(object sender, EventArgs e)
        {
            txt_suma.Text = NumerosAletras.NumeroLetra(txt_monto.Text);
        }

        private void cmb_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_monedaid.SelectedIndex = cmb_moneda.SelectedIndex;
        }

        private void cmb_monedaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_moneda.SelectedIndex = cmb_monedaid.SelectedIndex;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            
            bool GlobalChexkBox = false;
            bool efectivo = false;
            bool cheque = false;
            bool TarjetaDeCredito = false;
            bool TransferenciaElectronica = false;
            bool CreditoCliente = false;
            
            bool TxtCampo = false;

            if (cbtn_efectivo.Checked)
            {
                efectivo = true;
                GlobalChexkBox = true;
            }

            if (cbtn_cheque.Checked)
            {
                cheque = true;
                GlobalChexkBox = true;
            }

            if (cbtn_tarjetadecredito.Checked)
            {
                TarjetaDeCredito = true;
                GlobalChexkBox = true;
            }

            if (cbtn_transferenciaelectronica.Checked)
            {
                TransferenciaElectronica = true;
                GlobalChexkBox = true;
            }

            if (cbtn_creditocliente.Checked)
            {
                CreditoCliente = true;
                GlobalChexkBox = true;
            }

            if (GlobalChexkBox)
            {

                if (efectivo)
                {
                    if ( Convert.ToDecimal( txt_efectivo.Text)  <= 0)
                    {
                        MessageBox.Show("Debe especificar el Monto en Efectivo.");
                        return;
                    }
                }

                if(cheque)
                {
                    if (txt_cheque.Text == string.Empty)
                    {
                        MessageBox.Show("Tiene que especificar un Numero de Cheque.");
                        return;
                    }
                    
                    if (Convert.ToDecimal( txt_montocheque.Text) <= 0)
                    {
                        MessageBox.Show("Tiene que especificar el Monto del Cheque.");
                        return;
                    }
                }

                if (TarjetaDeCredito)
                {
                    if (txt_tarjaetadecredito.Text == string.Empty)
                    {
                        MessageBox.Show("Tiene que especificar el Numero de Tarjeta.");
                        return;
                    }

                    if ( Convert.ToDecimal( txt_montotarjetadecredito.Text) <= 0)
                    {
                        MessageBox.Show("Tiene que especificar el Monto a Pasar.");
                        return;
                    }
                }

                if (TransferenciaElectronica)
                {
                    if (txt_transferecniaelectronica.Text == string.Empty)
                    {
                        MessageBox.Show("Tiene que especificar el Numero de Transferencia Electronica.");
                        return;
                    }

                    if (Convert.ToDecimal( txt_montotransferenciaelectronica.Text) <= 0)
                    {
                        MessageBox.Show("Tiene que especificar el Monto de la Transferencia Electronica.");
                        return;
                    }
                }

                if (CreditoCliente)
                {
                    if ( Convert.ToDecimal(txt_creditocliente.Text) <= 0 )
                    {
                        MessageBox.Show("Tiene que especificar el Monto de Credito del Cliente a Usar.");
                        return;
                    }
                }

                decimal MontoEfectivo,MontoCheque,MontoTarjetadeCredito,MontoTransferenciaElectronica,MontoCreditoCliente,MontoTotal;
                
                MontoEfectivo = Convert.ToDecimal(txt_efectivo.Text);
                MontoCheque  = Convert.ToDecimal(txt_montocheque.Text);
                MontoTarjetadeCredito = Convert.ToDecimal(txt_montotarjetadecredito.Text);
                MontoTransferenciaElectronica  = Convert.ToDecimal(txt_montotransferenciaelectronica.Text);
                MontoCreditoCliente  = Convert.ToDecimal(txt_creditocliente.Text);
                
                MontoTotal = MontoEfectivo + MontoCheque + MontoTarjetadeCredito + MontoTransferenciaElectronica + MontoCreditoCliente;

                if (MontoTotal > MontoFactura)
                {
                    MessageBox.Show("El metodo de pago debe ser menor o igual al Monto de la Factura");
                    return;
                }
                
                metodos.GuardarRecibo(this);
                MessageBox.Show(id);
                metodos.ValidarProcesoKardex(this.Name);
                if (metodos.EjecutarProcesoKardex == true)
                {
                    metodos.UtilizarProcedimientosKardexGenerar(metodos.NombreProcesoKardex, "2", "1", id);
                }
                //this.Close();
                MessageBox.Show("Recibo Generado con Exito", "Recibo Generado" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un metodo de pago.", "Metodo de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void CalcularMontoPagar()
        {
            try
            {

                decimal MontoEfectivo, MontoCheque, MontoTarjetadeCredito, MontoTransferenciaElectronica, MontoCreditoCliente, MontoTotal;

                MontoEfectivo = Convert.ToDecimal(txt_efectivo.Text);
                MontoCheque = Convert.ToDecimal(txt_montocheque.Text);
                MontoTarjetadeCredito = Convert.ToDecimal(txt_montotarjetadecredito.Text);
                MontoTransferenciaElectronica = Convert.ToDecimal(txt_montotransferenciaelectronica.Text);
                MontoCreditoCliente = Convert.ToDecimal(txt_creditocliente.Text);

                MontoTotal = MontoEfectivo + MontoCheque + MontoTarjetadeCredito + MontoTransferenciaElectronica + MontoCreditoCliente;
            
                if (MontoTotal > MontoFactura)
                {
                    //MessageBox.Show("El metodo de pago debe ser menor o igual al Monto de la Factura");
                    txt_montopagar.ForeColor = Color.Red;
                }
                else
                {
                    txt_montopagar.ForeColor = Color.Black;
                }
            
                txt_montopagar.Text = MontoTotal.ToString();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Estas Seguro que Deseas Salir de la Forma?","Ventana de Salida de la Forma", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                this.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt16(txt_efectivo.Text);

            MessageBox.Show(d+"");
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(txt_monto.Text);
        }

       

        private void txt_efectivo_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularMontoPagar();           
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.SoloNumero(sender, e);
        }

        private void txt_efectivo_Leave(object sender, EventArgs e)
        {
            string valor = txt_efectivo.Text;
            if (valor == string.Empty)
                txt_efectivo.Text = "0.00";

            CalcularMontoPagar();
        }

        private void txt_montocheque_Leave(object sender, EventArgs e)
        {
            string valor = txt_montocheque.Text;
            if (valor == string.Empty)
                txt_montocheque.Text = "0.00";

            CalcularMontoPagar();
        }

        private void txt_montotarjetadecredito_Leave(object sender, EventArgs e)
        {
            string valor = txt_montotarjetadecredito.Text;
            if (valor == string.Empty)
                txt_montotarjetadecredito.Text = "0.00";

            CalcularMontoPagar();
        }

        private void txt_montotransferenciaelectronica_Leave(object sender, EventArgs e)
        {
            string valor = txt_montotransferenciaelectronica.Text;
            if (valor == string.Empty)
                txt_montotransferenciaelectronica.Text = "0.00";

            CalcularMontoPagar();
        }

        private void txt_creditocliente_Leave(object sender, EventArgs e)
        {
            string valor = txt_creditocliente.Text;
            if (valor == string.Empty)
                txt_creditocliente.Text = "0.00";

            CalcularMontoPagar();
        }

        
    }
}
