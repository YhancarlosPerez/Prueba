namespace erp_businessflex
{
    partial class frm_balanceinicial
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
            this.components = new System.ComponentModel.Container();
            this.cmb_cliente = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_ClienteId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.de_fecha = new DevExpress.XtraEditors.DateEdit();
            this.txt_valor = new DevExpress.XtraEditors.TextEdit();
            this.cmb_MonedaId = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_moneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memo_notas = new DevExpress.XtraEditors.MemoEdit();
            this.btn_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_cliente = new DevExpress.XtraEditors.LabelControl();
            this.lbl_fecha = new DevExpress.XtraEditors.LabelControl();
            this.lbl_valor = new DevExpress.XtraEditors.LabelControl();
            this.lbl_moneda = new DevExpress.XtraEditors.LabelControl();
            this.lbl_nota = new DevExpress.XtraEditors.LabelControl();
            this.lbl_tasa = new DevExpress.XtraEditors.LabelControl();
            this.txt_tasa = new DevExpress.XtraEditors.TextEdit();
            this.dxErrorProviderBalance = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ClienteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MonedaId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_moneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_notas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Location = new System.Drawing.Point(4, 32);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_cliente.Size = new System.Drawing.Size(381, 20);
            this.cmb_cliente.TabIndex = 0;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // cmb_ClienteId
            // 
            this.cmb_ClienteId.Location = new System.Drawing.Point(332, 8);
            this.cmb_ClienteId.Name = "cmb_ClienteId";
            this.cmb_ClienteId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ClienteId.Size = new System.Drawing.Size(53, 20);
            this.cmb_ClienteId.TabIndex = 1;
            this.cmb_ClienteId.Visible = false;
            // 
            // de_fecha
            // 
            this.de_fecha.EditValue = null;
            this.de_fecha.Location = new System.Drawing.Point(391, 32);
            this.de_fecha.Name = "de_fecha";
            this.de_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_fecha.Size = new System.Drawing.Size(95, 20);
            this.de_fecha.TabIndex = 2;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(298, 81);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Properties.Mask.EditMask = "n2";
            this.txt_valor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_valor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_valor.Size = new System.Drawing.Size(188, 20);
            this.txt_valor.TabIndex = 3;
            // 
            // cmb_MonedaId
            // 
            this.cmb_MonedaId.Location = new System.Drawing.Point(78, 58);
            this.cmb_MonedaId.Name = "cmb_MonedaId";
            this.cmb_MonedaId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_MonedaId.Size = new System.Drawing.Size(53, 20);
            this.cmb_MonedaId.TabIndex = 5;
            this.cmb_MonedaId.Visible = false;
            this.cmb_MonedaId.SelectedIndexChanged += new System.EventHandler(this.cmb_MonedaId_SelectedIndexChanged);
            // 
            // cmb_moneda
            // 
            this.cmb_moneda.Location = new System.Drawing.Point(6, 81);
            this.cmb_moneda.Name = "cmb_moneda";
            this.cmb_moneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_moneda.Size = new System.Drawing.Size(125, 20);
            this.cmb_moneda.TabIndex = 4;
            this.cmb_moneda.SelectedIndexChanged += new System.EventHandler(this.cmb_moneda_SelectedIndexChanged);
            // 
            // memo_notas
            // 
            this.memo_notas.Location = new System.Drawing.Point(6, 130);
            this.memo_notas.Name = "memo_notas";
            this.memo_notas.Size = new System.Drawing.Size(480, 62);
            this.memo_notas.TabIndex = 6;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(175, 201);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(265, 201);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.Location = new System.Drawing.Point(6, 15);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(37, 13);
            this.lbl_cliente.TabIndex = 9;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(395, 16);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(33, 13);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.Location = new System.Drawing.Point(301, 65);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(28, 13);
            this.lbl_valor.TabIndex = 10;
            this.lbl_valor.Text = "Valor:";
            // 
            // lbl_moneda
            // 
            this.lbl_moneda.Location = new System.Drawing.Point(10, 65);
            this.lbl_moneda.Name = "lbl_moneda";
            this.lbl_moneda.Size = new System.Drawing.Size(42, 13);
            this.lbl_moneda.TabIndex = 11;
            this.lbl_moneda.Text = "Modena:";
            // 
            // lbl_nota
            // 
            this.lbl_nota.Location = new System.Drawing.Point(9, 114);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(32, 13);
            this.lbl_nota.TabIndex = 12;
            this.lbl_nota.Text = "Notas:";
            // 
            // lbl_tasa
            // 
            this.lbl_tasa.Location = new System.Drawing.Point(152, 65);
            this.lbl_tasa.Name = "lbl_tasa";
            this.lbl_tasa.Size = new System.Drawing.Size(27, 13);
            this.lbl_tasa.TabIndex = 14;
            this.lbl_tasa.Text = "Tasa:";
            // 
            // txt_tasa
            // 
            this.txt_tasa.Location = new System.Drawing.Point(149, 81);
            this.txt_tasa.Name = "txt_tasa";
            this.txt_tasa.Size = new System.Drawing.Size(127, 20);
            this.txt_tasa.TabIndex = 13;
            // 
            // dxErrorProviderBalance
            // 
            this.dxErrorProviderBalance.ContainerControl = this;
            // 
            // frm_balanceinicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 235);
            this.Controls.Add(this.lbl_tasa);
            this.Controls.Add(this.txt_tasa);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.lbl_moneda);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.memo_notas);
            this.Controls.Add(this.cmb_MonedaId);
            this.Controls.Add(this.cmb_moneda);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.de_fecha);
            this.Controls.Add(this.cmb_ClienteId);
            this.Controls.Add(this.cmb_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_balanceinicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Inicial";
            this.Shown += new System.EventHandler(this.frm_balanceinicial_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ClienteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_MonedaId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_moneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_notas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProviderBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmb_moneda;
        private DevExpress.XtraEditors.SimpleButton btn_aceptar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.LabelControl lbl_cliente;
        private DevExpress.XtraEditors.LabelControl lbl_fecha;
        private DevExpress.XtraEditors.LabelControl lbl_valor;
        private DevExpress.XtraEditors.LabelControl lbl_moneda;
        private DevExpress.XtraEditors.LabelControl lbl_nota;
        private DevExpress.XtraEditors.LabelControl lbl_tasa;
        public DevExpress.XtraEditors.TextEdit txt_tasa;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_ClienteId;
        public DevExpress.XtraEditors.DateEdit de_fecha;
        public DevExpress.XtraEditors.TextEdit txt_valor;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_MonedaId;
        public DevExpress.XtraEditors.MemoEdit memo_notas;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProviderBalance;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_cliente;
    }
}