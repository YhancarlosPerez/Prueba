namespace erp_businessflex
{
    partial class frm_chequedevueltoslistadocliente
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
            this.cmb_nombrebanco = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_idbanco = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_banco = new DevExpress.XtraEditors.LabelControl();
            this.txt_numero = new DevExpress.XtraEditors.TextEdit();
            this.lbl_fecha = new DevExpress.XtraEditors.LabelControl();
            this.lbl_numero = new DevExpress.XtraEditors.LabelControl();
            this.lbl_cliente = new DevExpress.XtraEditors.LabelControl();
            this.cmb_idcliente = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_nombrecliente = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_nombrecuenta = new DevExpress.XtraEditors.LabelControl();
            this.cmb_idnombrecuenta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_nombrecuenta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_nocuenta = new DevExpress.XtraEditors.LabelControl();
            this.cmb_nocuenta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_monto = new DevExpress.XtraEditors.LabelControl();
            this.txt_monto = new DevExpress.XtraEditors.TextEdit();
            this.lbl_comisionbancaria = new DevExpress.XtraEditors.LabelControl();
            this.txt_comisionbancaria = new DevExpress.XtraEditors.TextEdit();
            this.chk_cargarcomision = new DevExpress.XtraEditors.CheckEdit();
            this.memo_notas = new DevExpress.XtraEditors.MemoEdit();
            this.lbl_notas = new DevExpress.XtraEditors.LabelControl();
            this.btn_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.de_fecha = new DevExpress.XtraEditors.DateEdit();
            this.txt_fecha = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrebanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idbanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrecliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idnombrecuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrecuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nocuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_comisionbancaria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_cargarcomision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_notas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_nombrebanco
            // 
            this.cmb_nombrebanco.Location = new System.Drawing.Point(12, 28);
            this.cmb_nombrebanco.Name = "cmb_nombrebanco";
            this.cmb_nombrebanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombrebanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombrebanco.Size = new System.Drawing.Size(360, 20);
            this.cmb_nombrebanco.TabIndex = 0;
            this.cmb_nombrebanco.SelectedIndexChanged += new System.EventHandler(this.cmb_nombrebanco_SelectedIndexChanged);
            // 
            // cmb_idbanco
            // 
            this.cmb_idbanco.Location = new System.Drawing.Point(321, 7);
            this.cmb_idbanco.Name = "cmb_idbanco";
            this.cmb_idbanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idbanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idbanco.Size = new System.Drawing.Size(50, 20);
            this.cmb_idbanco.TabIndex = 1;
            this.cmb_idbanco.Visible = false;
            this.cmb_idbanco.SelectedIndexChanged += new System.EventHandler(this.cmb_idbanco_SelectedIndexChanged);
            // 
            // lbl_banco
            // 
            this.lbl_banco.Location = new System.Drawing.Point(15, 10);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(33, 13);
            this.lbl_banco.TabIndex = 2;
            this.lbl_banco.Text = "Banco:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(391, 28);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(136, 20);
            this.txt_numero.TabIndex = 3;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(543, 10);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(33, 13);
            this.lbl_fecha.TabIndex = 5;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.Location = new System.Drawing.Point(391, 9);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(41, 13);
            this.lbl_numero.TabIndex = 6;
            this.lbl_numero.Text = "Numero:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.Location = new System.Drawing.Point(15, 58);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(37, 13);
            this.lbl_cliente.TabIndex = 9;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // cmb_idcliente
            // 
            this.cmb_idcliente.Location = new System.Drawing.Point(391, 54);
            this.cmb_idcliente.Name = "cmb_idcliente";
            this.cmb_idcliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idcliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idcliente.Size = new System.Drawing.Size(50, 20);
            this.cmb_idcliente.TabIndex = 8;
            this.cmb_idcliente.Visible = false;
            this.cmb_idcliente.SelectedIndexChanged += new System.EventHandler(this.cmb_idcliente_SelectedIndexChanged);
            // 
            // cmb_nombrecliente
            // 
            this.cmb_nombrecliente.Location = new System.Drawing.Point(12, 76);
            this.cmb_nombrecliente.Name = "cmb_nombrecliente";
            this.cmb_nombrecliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombrecliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombrecliente.Size = new System.Drawing.Size(429, 20);
            this.cmb_nombrecliente.TabIndex = 7;
            this.cmb_nombrecliente.SelectedIndexChanged += new System.EventHandler(this.cmb_nombrecliente_SelectedIndexChanged);
            // 
            // lbl_nombrecuenta
            // 
            this.lbl_nombrecuenta.Location = new System.Drawing.Point(15, 105);
            this.lbl_nombrecuenta.Name = "lbl_nombrecuenta";
            this.lbl_nombrecuenta.Size = new System.Drawing.Size(79, 13);
            this.lbl_nombrecuenta.TabIndex = 12;
            this.lbl_nombrecuenta.Text = "Nombre Cuenta:";
            // 
            // cmb_idnombrecuenta
            // 
            this.cmb_idnombrecuenta.Location = new System.Drawing.Point(256, 102);
            this.cmb_idnombrecuenta.Name = "cmb_idnombrecuenta";
            this.cmb_idnombrecuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idnombrecuenta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idnombrecuenta.Size = new System.Drawing.Size(50, 20);
            this.cmb_idnombrecuenta.TabIndex = 11;
            this.cmb_idnombrecuenta.Visible = false;
            this.cmb_idnombrecuenta.SelectedIndexChanged += new System.EventHandler(this.cmb_idnombrecuenta_SelectedIndexChanged);
            // 
            // cmb_nombrecuenta
            // 
            this.cmb_nombrecuenta.Location = new System.Drawing.Point(12, 123);
            this.cmb_nombrecuenta.Name = "cmb_nombrecuenta";
            this.cmb_nombrecuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombrecuenta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombrecuenta.Size = new System.Drawing.Size(294, 20);
            this.cmb_nombrecuenta.TabIndex = 10;
            this.cmb_nombrecuenta.SelectedIndexChanged += new System.EventHandler(this.cmb_nombrecuenta_SelectedIndexChanged);
            // 
            // lbl_nocuenta
            // 
            this.lbl_nocuenta.Location = new System.Drawing.Point(321, 105);
            this.lbl_nocuenta.Name = "lbl_nocuenta";
            this.lbl_nocuenta.Size = new System.Drawing.Size(56, 13);
            this.lbl_nocuenta.TabIndex = 15;
            this.lbl_nocuenta.Text = "No.Cuenta:";
            // 
            // cmb_nocuenta
            // 
            this.cmb_nocuenta.Location = new System.Drawing.Point(321, 123);
            this.cmb_nocuenta.Name = "cmb_nocuenta";
            this.cmb_nocuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nocuenta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nocuenta.Size = new System.Drawing.Size(301, 20);
            this.cmb_nocuenta.TabIndex = 13;
            this.cmb_nocuenta.SelectedIndexChanged += new System.EventHandler(this.cmb_nocuenta_SelectedIndexChanged);
            // 
            // lbl_monto
            // 
            this.lbl_monto.Location = new System.Drawing.Point(12, 154);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(34, 13);
            this.lbl_monto.TabIndex = 17;
            this.lbl_monto.Text = "Monto:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(12, 173);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Properties.Mask.EditMask = "n2";
            this.txt_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_monto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_monto.Size = new System.Drawing.Size(136, 20);
            this.txt_monto.TabIndex = 16;
            // 
            // lbl_comisionbancaria
            // 
            this.lbl_comisionbancaria.Location = new System.Drawing.Point(170, 154);
            this.lbl_comisionbancaria.Name = "lbl_comisionbancaria";
            this.lbl_comisionbancaria.Size = new System.Drawing.Size(90, 13);
            this.lbl_comisionbancaria.TabIndex = 19;
            this.lbl_comisionbancaria.Text = "Comisión Bancaria:";
            // 
            // txt_comisionbancaria
            // 
            this.txt_comisionbancaria.Location = new System.Drawing.Point(170, 173);
            this.txt_comisionbancaria.Name = "txt_comisionbancaria";
            this.txt_comisionbancaria.Properties.Mask.EditMask = "n2";
            this.txt_comisionbancaria.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_comisionbancaria.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_comisionbancaria.Size = new System.Drawing.Size(136, 20);
            this.txt_comisionbancaria.TabIndex = 18;
            // 
            // chk_cargarcomision
            // 
            this.chk_cargarcomision.Location = new System.Drawing.Point(321, 174);
            this.chk_cargarcomision.Name = "chk_cargarcomision";
            this.chk_cargarcomision.Properties.Caption = "Cargar Comisión";
            this.chk_cargarcomision.Size = new System.Drawing.Size(102, 19);
            this.chk_cargarcomision.TabIndex = 20;
            // 
            // memo_notas
            // 
            this.memo_notas.Location = new System.Drawing.Point(12, 223);
            this.memo_notas.Name = "memo_notas";
            this.memo_notas.Size = new System.Drawing.Size(610, 96);
            this.memo_notas.TabIndex = 21;
            // 
            // lbl_notas
            // 
            this.lbl_notas.Location = new System.Drawing.Point(15, 204);
            this.lbl_notas.Name = "lbl_notas";
            this.lbl_notas.Size = new System.Drawing.Size(32, 13);
            this.lbl_notas.TabIndex = 22;
            this.lbl_notas.Text = "Notas:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(228, 323);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 23;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(310, 323);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(603, 58);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 13);
            this.lbl_id.TabIndex = 25;
            this.lbl_id.Text = "ID#";
            this.lbl_id.Visible = false;
            // 
            // de_fecha
            // 
            this.de_fecha.EditValue = null;
            this.de_fecha.Location = new System.Drawing.Point(542, 28);
            this.de_fecha.Name = "de_fecha";
            this.de_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_fecha.Size = new System.Drawing.Size(80, 20);
            this.de_fecha.TabIndex = 26;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(543, 28);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_fecha.Size = new System.Drawing.Size(79, 20);
            this.txt_fecha.TabIndex = 27;
            this.txt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // frm_chequedevueltoslistadocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 351);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.de_fecha);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_notas);
            this.Controls.Add(this.memo_notas);
            this.Controls.Add(this.chk_cargarcomision);
            this.Controls.Add(this.lbl_comisionbancaria);
            this.Controls.Add(this.txt_comisionbancaria);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_nocuenta);
            this.Controls.Add(this.cmb_nocuenta);
            this.Controls.Add(this.lbl_nombrecuenta);
            this.Controls.Add(this.cmb_idnombrecuenta);
            this.Controls.Add(this.cmb_nombrecuenta);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.cmb_idcliente);
            this.Controls.Add(this.cmb_nombrecliente);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.cmb_idbanco);
            this.Controls.Add(this.cmb_nombrebanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_chequedevueltoslistadocliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos - Cheques Devueltos - Creacíon";
            this.Load += new System.EventHandler(this.frm_chequedevueltoslistadocliente_Load);
            this.Shown += new System.EventHandler(this.frm_chequedevueltoslistadocliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrebanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idbanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrecliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idnombrecuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrecuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nocuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_comisionbancaria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_cargarcomision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo_notas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbl_banco;
        private DevExpress.XtraEditors.LabelControl lbl_fecha;
        private DevExpress.XtraEditors.LabelControl lbl_numero;
        private DevExpress.XtraEditors.LabelControl lbl_cliente;
        private DevExpress.XtraEditors.LabelControl lbl_nombrecuenta;
        private DevExpress.XtraEditors.LabelControl lbl_nocuenta;
        private DevExpress.XtraEditors.LabelControl lbl_monto;
        private DevExpress.XtraEditors.LabelControl lbl_comisionbancaria;
        private DevExpress.XtraEditors.LabelControl lbl_notas;
        private DevExpress.XtraEditors.SimpleButton btn_aceptar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_idbanco;
        public DevExpress.XtraEditors.TextEdit txt_numero;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_idcliente;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_idnombrecuenta;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nocuenta;
        public DevExpress.XtraEditors.TextEdit txt_monto;
        public DevExpress.XtraEditors.TextEdit txt_comisionbancaria;
        public DevExpress.XtraEditors.CheckEdit chk_cargarcomision;
        public DevExpress.XtraEditors.MemoEdit memo_notas;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nombrebanco;
        public DevExpress.XtraEditors.LabelControl lbl_id;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nombrecliente;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_nombrecuenta;
        public DevExpress.XtraEditors.DateEdit de_fecha;
        public DevExpress.XtraEditors.TextEdit txt_fecha;
    }
}