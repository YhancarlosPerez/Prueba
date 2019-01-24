namespace erp_businessflex
{
    partial class Frm_mantenimientorecibodeingreso
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
            this.btn_editar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_imprimir = new DevExpress.XtraEditors.SimpleButton();
            this.dgc_mantenimientoreciboingreso = new DevExpress.XtraGrid.GridControl();
            this.dgv_mantenimientoreciboingreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_mantenimientoreciboingreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimientoreciboingreso)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(389, 333);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(95, 26);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "&Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(490, 333);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(95, 26);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "&Eliminar";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(288, 333);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(95, 26);
            this.btn_imprimir.TabIndex = 5;
            this.btn_imprimir.Text = "&Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // dgc_mantenimientoreciboingreso
            // 
            this.dgc_mantenimientoreciboingreso.Location = new System.Drawing.Point(1, 2);
            this.dgc_mantenimientoreciboingreso.MainView = this.dgv_mantenimientoreciboingreso;
            this.dgc_mantenimientoreciboingreso.Name = "dgc_mantenimientoreciboingreso";
            this.dgc_mantenimientoreciboingreso.Size = new System.Drawing.Size(589, 325);
            this.dgc_mantenimientoreciboingreso.TabIndex = 4;
            this.dgc_mantenimientoreciboingreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_mantenimientoreciboingreso});
            // 
            // dgv_mantenimientoreciboingreso
            // 
            this.dgv_mantenimientoreciboingreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn5,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.dgv_mantenimientoreciboingreso.GridControl = this.dgc_mantenimientoreciboingreso;
            this.dgv_mantenimientoreciboingreso.Name = "dgv_mantenimientoreciboingreso";
            this.dgv_mantenimientoreciboingreso.OptionsView.ShowGroupPanel = false;
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
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Monto";
            this.gridColumn6.FieldName = "Monto";
            this.gridColumn6.MaxWidth = 100;
            this.gridColumn6.MinWidth = 100;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Concepto";
            this.gridColumn7.FieldName = "Concepto";
            this.gridColumn7.MaxWidth = 250;
            this.gridColumn7.MinWidth = 250;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 250;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "IdCliente";
            this.gridColumn5.FieldName = "IdCliente";
            this.gridColumn5.MaxWidth = 100;
            this.gridColumn5.MinWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 100;
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
            this.gridColumn10.Caption = "No.Cheque";
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
            this.gridColumn11.Caption = "Targeta de Credito";
            this.gridColumn11.FieldName = "TargCredito";
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
            this.gridColumn12.Caption = "No.Targeta de Credito";
            this.gridColumn12.FieldName = "NumTargCredito";
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
            // Frm_mantenimientorecibodeingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 361);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dgc_mantenimientoreciboingreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_mantenimientorecibodeingreso";
            this.Text = "Mantenimiento Recibo de Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.dgc_mantenimientoreciboingreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimientoreciboingreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_editar;
        private DevExpress.XtraEditors.SimpleButton btn_eliminar;
        private DevExpress.XtraEditors.SimpleButton btn_imprimir;
        private DevExpress.XtraGrid.GridControl dgc_mantenimientoreciboingreso;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_mantenimientoreciboingreso;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
    }
}