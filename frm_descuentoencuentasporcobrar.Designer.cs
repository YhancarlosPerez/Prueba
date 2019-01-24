namespace erp_businessflex
{
    partial class frm_descuentoencuentasporcobrar
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
            this.txt_cliente = new DevExpress.XtraEditors.TextEdit();
            this.lbl_cliente = new DevExpress.XtraEditors.LabelControl();
            this.lbl_fecha = new DevExpress.XtraEditors.LabelControl();
            this.cmb_nombremoneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_idmoneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_nombremoneda = new DevExpress.XtraEditors.LabelControl();
            this.txt_monto = new DevExpress.XtraEditors.TextEdit();
            this.lbl_monto = new DevExpress.XtraEditors.LabelControl();
            this.lb_tiporetencion = new DevExpress.XtraEditors.LabelControl();
            this.cmb_idtiporetencion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_nombretiporetencion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memo_concepto = new DevExpress.XtraEditors.MemoEdit();
            this.lbl_concepto = new DevExpress.XtraEditors.LabelControl();
            this.btn_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txt_fecha = new DevExpress.XtraEditors.TextEdit();
            this.txt_idfactura = new DevExpress.XtraEditors.TextEdit();
            this.lbl_idfactura = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombremoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idmoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idtiporetencion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombretiporetencion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_concepto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idfactura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(12, 76);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(301, 20);
            this.txt_cliente.TabIndex = 0;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.Location = new System.Drawing.Point(12, 57);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(37, 13);
            this.lbl_cliente.TabIndex = 1;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(163, 8);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(33, 13);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // cmb_nombremoneda
            // 
            this.cmb_nombremoneda.Location = new System.Drawing.Point(12, 125);
            this.cmb_nombremoneda.Name = "cmb_nombremoneda";
            this.cmb_nombremoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombremoneda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombremoneda.Size = new System.Drawing.Size(129, 20);
            this.cmb_nombremoneda.TabIndex = 4;
            this.cmb_nombremoneda.SelectedIndexChanged += new System.EventHandler(this.cmb_nombremoneda_SelectedIndexChanged);
            // 
            // cmb_idmoneda
            // 
            this.cmb_idmoneda.Location = new System.Drawing.Point(100, 104);
            this.cmb_idmoneda.Name = "cmb_idmoneda";
            this.cmb_idmoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idmoneda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idmoneda.Size = new System.Drawing.Size(41, 20);
            this.cmb_idmoneda.TabIndex = 5;
            this.cmb_idmoneda.SelectedIndexChanged += new System.EventHandler(this.cmb_idmoneda_SelectedIndexChanged);
            // 
            // lbl_nombremoneda
            // 
            this.lbl_nombremoneda.Location = new System.Drawing.Point(12, 108);
            this.lbl_nombremoneda.Name = "lbl_nombremoneda";
            this.lbl_nombremoneda.Size = new System.Drawing.Size(42, 13);
            this.lbl_nombremoneda.TabIndex = 6;
            this.lbl_nombremoneda.Text = "Moneda:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(325, 76);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(104, 20);
            this.txt_monto.TabIndex = 7;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // lbl_monto
            // 
            this.lbl_monto.Location = new System.Drawing.Point(325, 57);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(34, 13);
            this.lbl_monto.TabIndex = 8;
            this.lbl_monto.Text = "Monto:";
            // 
            // lb_tiporetencion
            // 
            this.lb_tiporetencion.Location = new System.Drawing.Point(223, 108);
            this.lb_tiporetencion.Name = "lb_tiporetencion";
            this.lb_tiporetencion.Size = new System.Drawing.Size(90, 13);
            this.lb_tiporetencion.TabIndex = 11;
            this.lb_tiporetencion.Text = "Tipo de Retención:";
            // 
            // cmb_idtiporetencion
            // 
            this.cmb_idtiporetencion.Location = new System.Drawing.Point(391, 104);
            this.cmb_idtiporetencion.Name = "cmb_idtiporetencion";
            this.cmb_idtiporetencion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idtiporetencion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idtiporetencion.Size = new System.Drawing.Size(38, 20);
            this.cmb_idtiporetencion.TabIndex = 10;
            this.cmb_idtiporetencion.SelectedIndexChanged += new System.EventHandler(this.cmb_idtiporetencion_SelectedIndexChanged);
            // 
            // cmb_nombretiporetencion
            // 
            this.cmb_nombretiporetencion.Location = new System.Drawing.Point(223, 125);
            this.cmb_nombretiporetencion.Name = "cmb_nombretiporetencion";
            this.cmb_nombretiporetencion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombretiporetencion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombretiporetencion.Size = new System.Drawing.Size(206, 20);
            this.cmb_nombretiporetencion.TabIndex = 9;
            this.cmb_nombretiporetencion.SelectedIndexChanged += new System.EventHandler(this.cmb_nombretiporetencion_SelectedIndexChanged);
            // 
            // memo_concepto
            // 
            this.memo_concepto.Location = new System.Drawing.Point(12, 166);
            this.memo_concepto.Name = "memo_concepto";
            this.memo_concepto.Size = new System.Drawing.Size(417, 96);
            this.memo_concepto.TabIndex = 12;
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.Location = new System.Drawing.Point(12, 148);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(50, 13);
            this.lbl_concepto.TabIndex = 13;
            this.lbl_concepto.Text = "Concepto:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(266, 268);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(347, 268);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(162, 27);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(104, 20);
            this.txt_fecha.TabIndex = 16;
            this.txt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_KeyPress);
            // 
            // txt_idfactura
            // 
            this.txt_idfactura.Location = new System.Drawing.Point(12, 27);
            this.txt_idfactura.Name = "txt_idfactura";
            this.txt_idfactura.Size = new System.Drawing.Size(107, 20);
            this.txt_idfactura.TabIndex = 17;
            this.txt_idfactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idfactura_KeyPress);
            // 
            // lbl_idfactura
            // 
            this.lbl_idfactura.Location = new System.Drawing.Point(12, 8);
            this.lbl_idfactura.Name = "lbl_idfactura";
            this.lbl_idfactura.Size = new System.Drawing.Size(55, 13);
            this.lbl_idfactura.TabIndex = 18;
            this.lbl_idfactura.Text = "ID Factura:";
            // 
            // frm_descuentoencuentasporcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 295);
            this.Controls.Add(this.lbl_idfactura);
            this.Controls.Add(this.txt_idfactura);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_concepto);
            this.Controls.Add(this.memo_concepto);
            this.Controls.Add(this.lb_tiporetencion);
            this.Controls.Add(this.cmb_idtiporetencion);
            this.Controls.Add(this.cmb_nombretiporetencion);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_nombremoneda);
            this.Controls.Add(this.cmb_idmoneda);
            this.Controls.Add(this.cmb_nombremoneda);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.txt_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_descuentoencuentasporcobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuentos";
            ((System.ComponentModel.ISupportInitialize)(this.txt_cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombremoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idmoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idtiporetencion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombretiporetencion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_concepto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idfactura.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbl_cliente;
        private DevExpress.XtraEditors.LabelControl lbl_fecha;
        private DevExpress.XtraEditors.LabelControl lbl_nombremoneda;
        private DevExpress.XtraEditors.LabelControl lbl_monto;
        private DevExpress.XtraEditors.LabelControl lb_tiporetencion;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_idtiporetencion;
        private DevExpress.XtraEditors.LabelControl lbl_concepto;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        public DevExpress.XtraEditors.TextEdit txt_cliente;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nombremoneda;
        public DevExpress.XtraEditors.TextEdit txt_monto;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nombretiporetencion;
        public DevExpress.XtraEditors.MemoEdit memo_concepto;
        public DevExpress.XtraEditors.TextEdit txt_fecha;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_idmoneda;
        public DevExpress.XtraEditors.TextEdit txt_idfactura;
        private DevExpress.XtraEditors.LabelControl lbl_idfactura;
        public DevExpress.XtraEditors.SimpleButton btn_aceptar;
    }
}