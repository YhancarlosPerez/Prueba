namespace erp_businessflex
{
    partial class mantenimientochequesdevueltoscliente
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
            this.dgc_chequedevueltocliente = new DevExpress.XtraGrid.GridControl();
            this.dgv_chequedevueltocliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Mask = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_editar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eliminar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_chequedevueltocliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chequedevueltocliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgc_chequedevueltocliente
            // 
            this.dgc_chequedevueltocliente.Location = new System.Drawing.Point(3, 4);
            this.dgc_chequedevueltocliente.MainView = this.dgv_chequedevueltocliente;
            this.dgc_chequedevueltocliente.Name = "dgc_chequedevueltocliente";
            this.dgc_chequedevueltocliente.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Mask});
            this.dgc_chequedevueltocliente.Size = new System.Drawing.Size(769, 284);
            this.dgc_chequedevueltocliente.TabIndex = 0;
            this.dgc_chequedevueltocliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_chequedevueltocliente});
            // 
            // dgv_chequedevueltocliente
            // 
            this.dgv_chequedevueltocliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.dgv_chequedevueltocliente.GridControl = this.dgc_chequedevueltocliente;
            this.dgv_chequedevueltocliente.Name = "dgv_chequedevueltocliente";
            this.dgv_chequedevueltocliente.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID#";
            this.gridColumn1.FieldName = "IdCheque";
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
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "FechaCheque";
            this.gridColumn4.MaxWidth = 100;
            this.gridColumn4.MinWidth = 100;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Numero";
            this.gridColumn3.FieldName = "NumeroCheque";
            this.gridColumn3.MaxWidth = 100;
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cliente";
            this.gridColumn5.FieldName = "NombreCliente";
            this.gridColumn5.MaxWidth = 200;
            this.gridColumn5.MinWidth = 200;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 200;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Banco";
            this.gridColumn2.FieldName = "NombreBanco";
            this.gridColumn2.MaxWidth = 150;
            this.gridColumn2.MinWidth = 150;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nombre Cta.";
            this.gridColumn6.FieldName = "NombreCuenta";
            this.gridColumn6.MaxWidth = 200;
            this.gridColumn6.MinWidth = 200;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 200;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "No. Cuenta";
            this.gridColumn7.FieldName = "NoCuentaBanco";
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
            this.gridColumn8.Caption = "Monto";
            this.gridColumn8.ColumnEdit = this.Mask;
            this.gridColumn8.FieldName = "MontoCheque";
            this.gridColumn8.MaxWidth = 100;
            this.gridColumn8.MinWidth = 100;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 100;
            // 
            // Mask
            // 
            this.Mask.AutoHeight = false;
            this.Mask.Mask.EditMask = "n2";
            this.Mask.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Mask.Mask.UseMaskAsDisplayFormat = true;
            this.Mask.Name = "Mask";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Comisión Bancaria";
            this.gridColumn9.ColumnEdit = this.Mask;
            this.gridColumn9.FieldName = "ComisionBancaria";
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
            this.gridColumn10.Caption = "CargarComision";
            this.gridColumn10.FieldName = "CargarComision";
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
            this.gridColumn11.Caption = "Notas";
            this.gridColumn11.FieldName = "Notas";
            this.gridColumn11.MaxWidth = 250;
            this.gridColumn11.MinWidth = 250;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            this.gridColumn11.Width = 250;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(602, 293);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "&Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(683, 293);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // mantenimientochequesdevueltoscliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 320);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgc_chequedevueltocliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mantenimientochequesdevueltoscliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Movimientos - Cheques Devueltos";
            this.Load += new System.EventHandler(this.mantenimientochequesdevueltoscliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgc_chequedevueltocliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chequedevueltocliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_editar;
        private DevExpress.XtraEditors.SimpleButton btn_eliminar;
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
        public DevExpress.XtraGrid.Views.Grid.GridView dgv_chequedevueltocliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Mask;
        public DevExpress.XtraGrid.GridControl dgc_chequedevueltocliente;
    }
}