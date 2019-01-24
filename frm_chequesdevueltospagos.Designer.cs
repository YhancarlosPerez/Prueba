namespace erp_businessflex
{
    partial class frm_chequesdevueltospagos
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
            this.txt_recibidode = new DevExpress.XtraEditors.TextEdit();
            this.lbl_recibidode = new DevExpress.XtraEditors.LabelControl();
            this.lbl_fecha = new DevExpress.XtraEditors.LabelControl();
            this.txt_monto = new DevExpress.XtraEditors.TextEdit();
            this.lbl_monto = new DevExpress.XtraEditors.LabelControl();
            this.cmb_nombremoneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_moneda = new DevExpress.XtraEditors.LabelControl();
            this.memo_notas = new DevExpress.XtraEditors.MemoEdit();
            this.btn_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_notas = new DevExpress.XtraEditors.LabelControl();
            this.cmb_idmoneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_idfactura = new DevExpress.XtraEditors.TextEdit();
            this.lbl_idfactura = new DevExpress.XtraEditors.LabelControl();
            this.txt_fecha = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_recibidode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombremoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_notas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idmoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idfactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_recibidode
            // 
            this.txt_recibidode.Location = new System.Drawing.Point(12, 64);
            this.txt_recibidode.Name = "txt_recibidode";
            this.txt_recibidode.Size = new System.Drawing.Size(339, 20);
            this.txt_recibidode.TabIndex = 0;
            this.txt_recibidode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_recibidode_KeyPress);
            // 
            // lbl_recibidode
            // 
            this.lbl_recibidode.Location = new System.Drawing.Point(12, 47);
            this.lbl_recibidode.Name = "lbl_recibidode";
            this.lbl_recibidode.Size = new System.Drawing.Size(59, 13);
            this.lbl_recibidode.TabIndex = 2;
            this.lbl_recibidode.Text = "Recibido de:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(384, 7);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(33, 13);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(382, 62);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 20);
            this.txt_monto.TabIndex = 4;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // lbl_monto
            // 
            this.lbl_monto.Location = new System.Drawing.Point(384, 47);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(34, 13);
            this.lbl_monto.TabIndex = 5;
            this.lbl_monto.Text = "Monto:";
            // 
            // cmb_nombremoneda
            // 
            this.cmb_nombremoneda.Location = new System.Drawing.Point(12, 103);
            this.cmb_nombremoneda.Name = "cmb_nombremoneda";
            this.cmb_nombremoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombremoneda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombremoneda.Size = new System.Drawing.Size(139, 20);
            this.cmb_nombremoneda.TabIndex = 6;
            this.cmb_nombremoneda.SelectedIndexChanged += new System.EventHandler(this.cmb_nombremoneda_SelectedIndexChanged);
            // 
            // lbl_moneda
            // 
            this.lbl_moneda.Location = new System.Drawing.Point(12, 88);
            this.lbl_moneda.Name = "lbl_moneda";
            this.lbl_moneda.Size = new System.Drawing.Size(42, 13);
            this.lbl_moneda.TabIndex = 7;
            this.lbl_moneda.Text = "Moneda:";
            // 
            // memo_notas
            // 
            this.memo_notas.Location = new System.Drawing.Point(12, 143);
            this.memo_notas.Name = "memo_notas";
            this.memo_notas.Size = new System.Drawing.Size(470, 96);
            this.memo_notas.TabIndex = 8;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(326, 244);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(407, 244);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_notas
            // 
            this.lbl_notas.Location = new System.Drawing.Point(12, 128);
            this.lbl_notas.Name = "lbl_notas";
            this.lbl_notas.Size = new System.Drawing.Size(32, 13);
            this.lbl_notas.TabIndex = 11;
            this.lbl_notas.Text = "Notas:";
            // 
            // cmb_idmoneda
            // 
            this.cmb_idmoneda.Location = new System.Drawing.Point(157, 103);
            this.cmb_idmoneda.Name = "cmb_idmoneda";
            this.cmb_idmoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idmoneda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idmoneda.Size = new System.Drawing.Size(46, 20);
            this.cmb_idmoneda.TabIndex = 12;
            this.cmb_idmoneda.SelectedIndexChanged += new System.EventHandler(this.cmb_idmoneda_SelectedIndexChanged);
            // 
            // txt_idfactura
            // 
            this.txt_idfactura.Location = new System.Drawing.Point(12, 24);
            this.txt_idfactura.Name = "txt_idfactura";
            this.txt_idfactura.Size = new System.Drawing.Size(100, 20);
            this.txt_idfactura.TabIndex = 13;
            this.txt_idfactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idfactura_KeyPress);
            // 
            // lbl_idfactura
            // 
            this.lbl_idfactura.Location = new System.Drawing.Point(12, 7);
            this.lbl_idfactura.Name = "lbl_idfactura";
            this.lbl_idfactura.Size = new System.Drawing.Size(55, 13);
            this.lbl_idfactura.TabIndex = 14;
            this.lbl_idfactura.Text = "ID. Factura";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(382, 24);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 15;
            this.txt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_KeyPress);
            // 
            // frm_chequesdevueltospagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 270);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_idfactura);
            this.Controls.Add(this.txt_idfactura);
            this.Controls.Add(this.cmb_idmoneda);
            this.Controls.Add(this.lbl_notas);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.memo_notas);
            this.Controls.Add(this.lbl_moneda);
            this.Controls.Add(this.cmb_nombremoneda);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_recibidode);
            this.Controls.Add(this.txt_recibidode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_chequesdevueltospagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheques Devueltos - Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.txt_recibidode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombremoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_notas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idmoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idfactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbl_recibidode;
        private DevExpress.XtraEditors.LabelControl lbl_fecha;
        private DevExpress.XtraEditors.LabelControl lbl_monto;
        private DevExpress.XtraEditors.LabelControl lbl_moneda;
        private DevExpress.XtraEditors.SimpleButton btn_aceptar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.LabelControl lbl_notas;
        public DevExpress.XtraEditors.TextEdit txt_recibidode;
        public DevExpress.XtraEditors.TextEdit txt_monto;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nombremoneda;
        public DevExpress.XtraEditors.MemoEdit memo_notas;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_idmoneda;
        public DevExpress.XtraEditors.TextEdit txt_idfactura;
        private DevExpress.XtraEditors.LabelControl lbl_idfactura;
        public DevExpress.XtraEditors.TextEdit txt_fecha;
    }
}