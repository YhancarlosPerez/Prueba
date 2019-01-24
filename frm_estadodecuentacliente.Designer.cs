namespace erp_businessflex
{
    partial class frm_estadodecuentacliente
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
            this.rbtn_cliente = new DevExpress.XtraEditors.CheckEdit();
            this.cmb_nombrecliente = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_ver = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ver = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_filtrar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_generarreporte = new DevExpress.XtraEditors.SimpleButton();
            this.de_desde = new DevExpress.XtraEditors.DateEdit();
            this.de_hasta = new DevExpress.XtraEditors.DateEdit();
            this.de_dia = new DevExpress.XtraEditors.DateEdit();
            this.dgc_estadodecuentacliente = new DevExpress.XtraGrid.GridControl();
            this.dgv_estadodecuentacliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaskDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_busqueda = new DevExpress.XtraEditors.LabelControl();
            this.cmb_idcliente = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_cliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrecliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_estadodecuentacliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadodecuentacliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idcliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_cliente
            // 
            this.rbtn_cliente.Location = new System.Drawing.Point(12, 9);
            this.rbtn_cliente.Name = "rbtn_cliente";
            this.rbtn_cliente.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cliente.Properties.Appearance.Options.UseFont = true;
            this.rbtn_cliente.Properties.Caption = "Cliente";
            this.rbtn_cliente.Size = new System.Drawing.Size(75, 23);
            this.rbtn_cliente.TabIndex = 0;
            this.rbtn_cliente.CheckedChanged += new System.EventHandler(this.rbtn_cliente_CheckedChanged);
            // 
            // cmb_nombrecliente
            // 
            this.cmb_nombrecliente.Location = new System.Drawing.Point(12, 37);
            this.cmb_nombrecliente.Name = "cmb_nombrecliente";
            this.cmb_nombrecliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_nombrecliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_nombrecliente.Size = new System.Drawing.Size(218, 20);
            this.cmb_nombrecliente.TabIndex = 1;
            this.cmb_nombrecliente.SelectedIndexChanged += new System.EventHandler(this.cmb_nombrecliente_SelectedIndexChanged);
            // 
            // lbl_ver
            // 
            this.lbl_ver.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ver.Appearance.Options.UseFont = true;
            this.lbl_ver.Location = new System.Drawing.Point(253, 12);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(24, 19);
            this.lbl_ver.TabIndex = 2;
            this.lbl_ver.Text = "Ver";
            // 
            // cmb_ver
            // 
            this.cmb_ver.Location = new System.Drawing.Point(250, 37);
            this.cmb_ver.Name = "cmb_ver";
            this.cmb_ver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ver.Properties.Items.AddRange(new object[] {
            "Todos",
            "Por Día",
            "Por Fecha"});
            this.cmb_ver.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_ver.Size = new System.Drawing.Size(132, 20);
            this.cmb_ver.TabIndex = 3;
            this.cmb_ver.SelectedIndexChanged += new System.EventHandler(this.cmb_ver_SelectedIndexChanged);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(399, 31);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(81, 27);
            this.btn_filtrar.TabIndex = 4;
            this.btn_filtrar.Text = "&Filtrar";
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_generarreporte
            // 
            this.btn_generarreporte.Location = new System.Drawing.Point(686, 29);
            this.btn_generarreporte.Name = "btn_generarreporte";
            this.btn_generarreporte.Size = new System.Drawing.Size(117, 26);
            this.btn_generarreporte.TabIndex = 5;
            this.btn_generarreporte.Text = "&Generar Reporte";
            this.btn_generarreporte.Click += new System.EventHandler(this.btn_generarreporte_Click);
            // 
            // de_desde
            // 
            this.de_desde.EditValue = null;
            this.de_desde.Location = new System.Drawing.Point(498, 35);
            this.de_desde.Name = "de_desde";
            this.de_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_desde.Size = new System.Drawing.Size(83, 20);
            this.de_desde.TabIndex = 6;
            // 
            // de_hasta
            // 
            this.de_hasta.EditValue = null;
            this.de_hasta.Location = new System.Drawing.Point(588, 34);
            this.de_hasta.Name = "de_hasta";
            this.de_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_hasta.Size = new System.Drawing.Size(83, 20);
            this.de_hasta.TabIndex = 7;
            // 
            // de_dia
            // 
            this.de_dia.EditValue = null;
            this.de_dia.Location = new System.Drawing.Point(498, 35);
            this.de_dia.Name = "de_dia";
            this.de_dia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_dia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_dia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_dia.Size = new System.Drawing.Size(83, 20);
            this.de_dia.TabIndex = 8;
            // 
            // dgc_estadodecuentacliente
            // 
            this.dgc_estadodecuentacliente.Location = new System.Drawing.Point(12, 64);
            this.dgc_estadodecuentacliente.MainView = this.dgv_estadodecuentacliente;
            this.dgc_estadodecuentacliente.Name = "dgc_estadodecuentacliente";
            this.dgc_estadodecuentacliente.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MaskDecimal});
            this.dgc_estadodecuentacliente.Size = new System.Drawing.Size(791, 233);
            this.dgc_estadodecuentacliente.TabIndex = 9;
            this.dgc_estadodecuentacliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_estadodecuentacliente});
            // 
            // dgv_estadodecuentacliente
            // 
            this.dgv_estadodecuentacliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn13,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.dgv_estadodecuentacliente.GridControl = this.dgc_estadodecuentacliente;
            this.dgv_estadodecuentacliente.Name = "dgv_estadodecuentacliente";
            this.dgv_estadodecuentacliente.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "No. Factura";
            this.gridColumn1.FieldName = "IdFactura";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha";
            this.gridColumn2.FieldName = "Fecha";
            this.gridColumn2.MaxWidth = 100;
            this.gridColumn2.MinWidth = 100;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha Vencimiento";
            this.gridColumn3.FieldName = "FchVenc";
            this.gridColumn3.MaxWidth = 100;
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID. Cliente";
            this.gridColumn4.FieldName = "IdCliente";
            this.gridColumn4.MaxWidth = 100;
            this.gridColumn4.MinWidth = 100;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cliente";
            this.gridColumn5.FieldName = "Cliente";
            this.gridColumn5.MaxWidth = 150;
            this.gridColumn5.MinWidth = 150;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Telefono";
            this.gridColumn6.FieldName = "Telefono";
            this.gridColumn6.MaxWidth = 100;
            this.gridColumn6.MinWidth = 100;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Condicion";
            this.gridColumn7.FieldName = "Condicion";
            this.gridColumn7.MaxWidth = 100;
            this.gridColumn7.MinWidth = 100;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total";
            this.gridColumn8.ColumnEdit = this.MaskDecimal;
            this.gridColumn8.FieldName = "Total";
            this.gridColumn8.MaxWidth = 100;
            this.gridColumn8.MinWidth = 100;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 100;
            // 
            // MaskDecimal
            // 
            this.MaskDecimal.AutoHeight = false;
            this.MaskDecimal.Mask.EditMask = "n2";
            this.MaskDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MaskDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.MaskDecimal.Name = "MaskDecimal";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Balance";
            this.gridColumn9.ColumnEdit = this.MaskDecimal;
            this.gridColumn9.FieldName = "Balance";
            this.gridColumn9.MaxWidth = 100;
            this.gridColumn9.MinWidth = 100;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 100;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "01-15";
            this.gridColumn13.ColumnEdit = this.MaskDecimal;
            this.gridColumn13.FieldName = "C0115";
            this.gridColumn13.MaxWidth = 100;
            this.gridColumn13.MinWidth = 100;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 9;
            this.gridColumn13.Width = 100;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "16-30";
            this.gridColumn10.ColumnEdit = this.MaskDecimal;
            this.gridColumn10.FieldName = "C1630";
            this.gridColumn10.MaxWidth = 100;
            this.gridColumn10.MinWidth = 100;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            this.gridColumn10.Width = 100;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "31-60";
            this.gridColumn11.ColumnEdit = this.MaskDecimal;
            this.gridColumn11.FieldName = "C3160";
            this.gridColumn11.MaxWidth = 100;
            this.gridColumn11.MinWidth = 100;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            this.gridColumn11.Width = 100;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "C61->";
            this.gridColumn12.ColumnEdit = this.MaskDecimal;
            this.gridColumn12.FieldName = "C61";
            this.gridColumn12.MaxWidth = 100;
            this.gridColumn12.MinWidth = 100;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            this.gridColumn12.Width = 100;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda.Appearance.Options.UseFont = true;
            this.lbl_busqueda.Location = new System.Drawing.Point(500, 10);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(68, 19);
            this.lbl_busqueda.TabIndex = 10;
            this.lbl_busqueda.Text = "Busqueda";
            // 
            // cmb_idcliente
            // 
            this.cmb_idcliente.Location = new System.Drawing.Point(181, 15);
            this.cmb_idcliente.Name = "cmb_idcliente";
            this.cmb_idcliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_idcliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_idcliente.Size = new System.Drawing.Size(49, 20);
            this.cmb_idcliente.TabIndex = 11;
            this.cmb_idcliente.Visible = false;
            this.cmb_idcliente.SelectedIndexChanged += new System.EventHandler(this.cmb_idcliente_SelectedIndexChanged);
            // 
            // frm_estadodecuentacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 309);
            this.Controls.Add(this.cmb_idcliente);
            this.Controls.Add(this.lbl_busqueda);
            this.Controls.Add(this.dgc_estadodecuentacliente);
            this.Controls.Add(this.de_dia);
            this.Controls.Add(this.de_hasta);
            this.Controls.Add(this.de_desde);
            this.Controls.Add(this.btn_generarreporte);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.cmb_ver);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.cmb_nombrecliente);
            this.Controls.Add(this.rbtn_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_estadodecuentacliente";
            this.Text = "Estados de Cuenta Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.rbtn_cliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_nombrecliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_estadodecuentacliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estadodecuentacliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_idcliente.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit rbtn_cliente;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_nombrecliente;
        private DevExpress.XtraEditors.LabelControl lbl_ver;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ver;
        private DevExpress.XtraEditors.SimpleButton btn_filtrar;
        private DevExpress.XtraEditors.SimpleButton btn_generarreporte;
        private DevExpress.XtraGrid.GridControl dgc_estadodecuentacliente;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_estadodecuentacliente;
        private DevExpress.XtraEditors.LabelControl lbl_busqueda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        public DevExpress.XtraEditors.DateEdit de_desde;
        public DevExpress.XtraEditors.DateEdit de_hasta;
        public DevExpress.XtraEditors.DateEdit de_dia;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_idcliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit MaskDecimal;
    }
}