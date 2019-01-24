namespace erp_businessflex
{
    partial class frm_historicoreciboingreso
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
            this.lbl_ver = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ver = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_filtrar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_generarreporte = new DevExpress.XtraEditors.SimpleButton();
            this.dgc_historicorecibodeingreso = new DevExpress.XtraGrid.GridControl();
            this.dgv_historicorecibodeingreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_busqueda = new DevExpress.XtraEditors.TextEdit();
            this.lbl_busqueda = new DevExpress.XtraEditors.LabelControl();
            this.de_desde = new DevExpress.XtraEditors.DateEdit();
            this.de_hasta = new DevExpress.XtraEditors.DateEdit();
            this.de_dia = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_historicorecibodeingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historicorecibodeingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_busqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ver
            // 
            this.lbl_ver.Location = new System.Drawing.Point(12, 12);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(16, 13);
            this.lbl_ver.TabIndex = 0;
            this.lbl_ver.Text = "Ver";
            // 
            // cmb_ver
            // 
            this.cmb_ver.Location = new System.Drawing.Point(12, 31);
            this.cmb_ver.Name = "cmb_ver";
            this.cmb_ver.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ver.Properties.Items.AddRange(new object[] {
            "Todos\t",
            "Por Cliente",
            "Por Día\t",
            "Desde - Hasta"});
            this.cmb_ver.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_ver.Size = new System.Drawing.Size(142, 20);
            this.cmb_ver.TabIndex = 1;
            this.cmb_ver.SelectedIndexChanged += new System.EventHandler(this.cmb_ver_SelectedIndexChanged);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(185, 29);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 2;
            this.btn_filtrar.Text = "&Filtrar";
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_generarreporte
            // 
            this.btn_generarreporte.Location = new System.Drawing.Point(566, 29);
            this.btn_generarreporte.Name = "btn_generarreporte";
            this.btn_generarreporte.Size = new System.Drawing.Size(178, 23);
            this.btn_generarreporte.TabIndex = 3;
            this.btn_generarreporte.Text = "&Generar Reporte";
            this.btn_generarreporte.Click += new System.EventHandler(this.btn_generarreporte_Click);
            // 
            // dgc_historicorecibodeingreso
            // 
            this.dgc_historicorecibodeingreso.Location = new System.Drawing.Point(12, 57);
            this.dgc_historicorecibodeingreso.MainView = this.dgv_historicorecibodeingreso;
            this.dgc_historicorecibodeingreso.Name = "dgc_historicorecibodeingreso";
            this.dgc_historicorecibodeingreso.Size = new System.Drawing.Size(735, 259);
            this.dgc_historicorecibodeingreso.TabIndex = 4;
            this.dgc_historicorecibodeingreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_historicorecibodeingreso});
            // 
            // dgv_historicorecibodeingreso
            // 
            this.dgv_historicorecibodeingreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.dgv_historicorecibodeingreso.GridControl = this.dgc_historicorecibodeingreso;
            this.dgv_historicorecibodeingreso.Name = "dgv_historicorecibodeingreso";
            this.dgv_historicorecibodeingreso.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "No.Recibo";
            this.gridColumn1.FieldName = "IdRecibo";
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
            this.gridColumn3.Caption = "Cliente";
            this.gridColumn3.FieldName = "Cliente";
            this.gridColumn3.MaxWidth = 150;
            this.gridColumn3.MinWidth = 150;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Suma";
            this.gridColumn4.FieldName = "Suma";
            this.gridColumn4.MaxWidth = 300;
            this.gridColumn4.MinWidth = 300;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 300;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Monto";
            this.gridColumn5.FieldName = "Monto";
            this.gridColumn5.MaxWidth = 100;
            this.gridColumn5.MinWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IdCliente";
            this.gridColumn6.FieldName = "IdCliente";
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
            this.gridColumn7.Caption = "Concepto";
            this.gridColumn7.FieldName = "Concepto";
            this.gridColumn7.MaxWidth = 150;
            this.gridColumn7.MinWidth = 150;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 150;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Efectivo";
            this.gridColumn8.FieldName = "Efectivo";
            this.gridColumn8.MaxWidth = 100;
            this.gridColumn8.MinWidth = 100;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 100;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Cheque";
            this.gridColumn9.FieldName = "Cheque";
            this.gridColumn9.MaxWidth = 100;
            this.gridColumn9.MinWidth = 100;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 100;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "NumCheque";
            this.gridColumn10.FieldName = "NumCheque";
            this.gridColumn10.MaxWidth = 100;
            this.gridColumn10.MinWidth = 100;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 100;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "TargCredito";
            this.gridColumn11.FieldName = "Targeta de Credito";
            this.gridColumn11.MaxWidth = 100;
            this.gridColumn11.MinWidth = 100;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 100;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "NumTargCredito";
            this.gridColumn12.FieldName = "No.Targeta de Credito";
            this.gridColumn12.MaxWidth = 100;
            this.gridColumn12.MinWidth = 100;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            this.gridColumn12.Width = 100;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Transferencia Electronica";
            this.gridColumn13.FieldName = "TransElectronica";
            this.gridColumn13.MaxWidth = 100;
            this.gridColumn13.MinWidth = 100;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            this.gridColumn13.Width = 100;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "No.Transferencia Electronica";
            this.gridColumn14.FieldName = "NumTransElectronica";
            this.gridColumn14.MaxWidth = 100;
            this.gridColumn14.MinWidth = 100;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 13;
            this.gridColumn14.Width = 100;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(280, 31);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(222, 20);
            this.txt_busqueda.TabIndex = 5;
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.Location = new System.Drawing.Point(280, 13);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(47, 13);
            this.lbl_busqueda.TabIndex = 6;
            this.lbl_busqueda.Text = "Busqueda";
            // 
            // de_desde
            // 
            this.de_desde.EditValue = null;
            this.de_desde.Location = new System.Drawing.Point(280, 32);
            this.de_desde.Name = "de_desde";
            this.de_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_desde.Size = new System.Drawing.Size(111, 20);
            this.de_desde.TabIndex = 7;
            // 
            // de_hasta
            // 
            this.de_hasta.EditValue = null;
            this.de_hasta.Location = new System.Drawing.Point(397, 31);
            this.de_hasta.Name = "de_hasta";
            this.de_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_hasta.Size = new System.Drawing.Size(111, 20);
            this.de_hasta.TabIndex = 8;
            // 
            // de_dia
            // 
            this.de_dia.EditValue = null;
            this.de_dia.Location = new System.Drawing.Point(280, 32);
            this.de_dia.Name = "de_dia";
            this.de_dia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_dia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_dia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_dia.Size = new System.Drawing.Size(111, 20);
            this.de_dia.TabIndex = 9;
            // 
            // frm_historicoreciboingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 320);
            this.Controls.Add(this.de_dia);
            this.Controls.Add(this.de_hasta);
            this.Controls.Add(this.de_desde);
            this.Controls.Add(this.lbl_busqueda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.dgc_historicorecibodeingreso);
            this.Controls.Add(this.btn_generarreporte);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.cmb_ver);
            this.Controls.Add(this.lbl_ver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_historicoreciboingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico - Recibo Cliente";
            this.Load += new System.EventHandler(this.frm_historicoreciboingreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_historicorecibodeingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historicorecibodeingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_busqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_dia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_ver;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ver;
        private DevExpress.XtraEditors.SimpleButton btn_filtrar;
        private DevExpress.XtraEditors.SimpleButton btn_generarreporte;
        private DevExpress.XtraGrid.GridControl dgc_historicorecibodeingreso;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_historicorecibodeingreso;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        public DevExpress.XtraEditors.TextEdit txt_busqueda;
        public DevExpress.XtraEditors.DateEdit de_desde;
        public DevExpress.XtraEditors.DateEdit de_dia;
        public DevExpress.XtraEditors.DateEdit de_hasta;
    }
}