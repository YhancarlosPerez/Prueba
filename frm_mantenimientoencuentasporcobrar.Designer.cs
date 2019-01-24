namespace erp_businessflex
{
    partial class frm_mantenimientoencuentasporcobrar
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
            this.dgc_cuentasporcobrar = new DevExpress.XtraGrid.GridControl();
            this.dgv_cuentasporcobrar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbl_monto = new DevExpress.XtraEditors.LabelControl();
            this.txt_monto = new DevExpress.XtraEditors.TextEdit();
            this.lbl_fecha = new DevExpress.XtraEditors.LabelControl();
            this.txt_fecha = new DevExpress.XtraEditors.TextEdit();
            this.btn_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.MaskDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_cuentasporcobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuentasporcobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgc_cuentasporcobrar
            // 
            this.dgc_cuentasporcobrar.Location = new System.Drawing.Point(1, 1);
            this.dgc_cuentasporcobrar.MainView = this.dgv_cuentasporcobrar;
            this.dgc_cuentasporcobrar.Name = "dgc_cuentasporcobrar";
            this.dgc_cuentasporcobrar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MaskDecimal});
            this.dgc_cuentasporcobrar.Size = new System.Drawing.Size(668, 200);
            this.dgc_cuentasporcobrar.TabIndex = 0;
            this.dgc_cuentasporcobrar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_cuentasporcobrar});
            // 
            // dgv_cuentasporcobrar
            // 
            this.dgv_cuentasporcobrar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn6,
            this.gridColumn8});
            this.dgv_cuentasporcobrar.GridControl = this.dgc_cuentasporcobrar;
            this.dgv_cuentasporcobrar.Name = "dgv_cuentasporcobrar";
            this.dgv_cuentasporcobrar.OptionsView.ShowGroupPanel = false;
            this.dgv_cuentasporcobrar.Click += new System.EventHandler(this.dgv_cuentasporcobrar_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID.Factura";
            this.gridColumn1.FieldName = "id_facturamaestro";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID.Cliente";
            this.gridColumn4.FieldName = "codigocliente_facturamestro";
            this.gridColumn4.MaxWidth = 100;
            this.gridColumn4.MinWidth = 100;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cliente";
            this.gridColumn5.FieldName = "nombre_clientemaestro";
            this.gridColumn5.MaxWidth = 200;
            this.gridColumn5.MinWidth = 200;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 200;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha";
            this.gridColumn2.FieldName = "fecha_facturamestro";
            this.gridColumn2.MaxWidth = 100;
            this.gridColumn2.MinWidth = 100;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha Venc.";
            this.gridColumn3.FieldName = "fechavencimiento_facturamestro";
            this.gridColumn3.MaxWidth = 100;
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Balance";
            this.gridColumn7.ColumnEdit = this.MaskDecimal;
            this.gridColumn7.FieldName = "total_facturamaestro";
            this.gridColumn7.MaxWidth = 100;
            this.gridColumn7.MinWidth = 100;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "codigomoneda";
            this.gridColumn9.FieldName = "codigomoneda_facturamaestro";
            this.gridColumn9.MaxWidth = 100;
            this.gridColumn9.MinWidth = 100;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Moneda";
            this.gridColumn6.FieldName = "Moneda";
            this.gridColumn6.MaxWidth = 100;
            this.gridColumn6.MinWidth = 100;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Concepto";
            this.gridColumn8.FieldName = "nota_facturamaestro";
            this.gridColumn8.MaxWidth = 250;
            this.gridColumn8.MinWidth = 250;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Width = 250;
            // 
            // lbl_monto
            // 
            this.lbl_monto.Location = new System.Drawing.Point(6, 216);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(34, 13);
            this.lbl_monto.TabIndex = 1;
            this.lbl_monto.Text = "Monto:";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(46, 213);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Properties.Mask.EditMask = "n2";
            this.txt_monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_monto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_monto.Size = new System.Drawing.Size(139, 20);
            this.txt_monto.TabIndex = 2;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Location = new System.Drawing.Point(209, 216);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(33, 13);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(248, 213);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(139, 20);
            this.txt_fecha.TabIndex = 4;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(503, 211);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(584, 210);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // MaskDecimal
            // 
            this.MaskDecimal.AutoHeight = false;
            this.MaskDecimal.Mask.EditMask = "n2";
            this.MaskDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MaskDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.MaskDecimal.Name = "MaskDecimal";
            // 
            // frm_mantenimientoencuentasporcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 240);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.dgc_cuentasporcobrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_mantenimientoencuentasporcobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento en cuenta por Cobrar - Pago Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgc_cuentasporcobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuentasporcobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_cuentasporcobrar;
        private DevExpress.XtraEditors.LabelControl lbl_monto;
        private DevExpress.XtraEditors.TextEdit txt_monto;
        private DevExpress.XtraEditors.LabelControl lbl_fecha;
        private DevExpress.XtraEditors.TextEdit txt_fecha;
        private DevExpress.XtraEditors.SimpleButton btn_aceptar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        public DevExpress.XtraGrid.GridControl dgc_cuentasporcobrar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit MaskDecimal;
    }
}