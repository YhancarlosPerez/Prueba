namespace erp_businessflex
{
    partial class frm_generarrecibo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_adelantoorden = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pagofactura = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_adelantoorden
            // 
            this.btn_adelantoorden.Location = new System.Drawing.Point(12, 12);
            this.btn_adelantoorden.Name = "btn_adelantoorden";
            this.btn_adelantoorden.Size = new System.Drawing.Size(156, 32);
            this.btn_adelantoorden.TabIndex = 0;
            this.btn_adelantoorden.Text = "Adelanto a Orden de Pedido";
            // 
            // btn_pagofactura
            // 
            this.btn_pagofactura.Location = new System.Drawing.Point(174, 12);
            this.btn_pagofactura.Name = "btn_pagofactura";
            this.btn_pagofactura.Size = new System.Drawing.Size(109, 32);
            this.btn_pagofactura.TabIndex = 1;
            this.btn_pagofactura.Text = "Pago de Factura";
            this.btn_pagofactura.Click += new System.EventHandler(this.btn_pagofactura_Click);
            // 
            // frm_generarrecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 53);
            this.Controls.Add(this.btn_pagofactura);
            this.Controls.Add(this.btn_adelantoorden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_generarrecibo";
            this.Text = "Generar Recibo USO";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_adelantoorden;
        private DevExpress.XtraEditors.SimpleButton btn_pagofactura;
    }
}