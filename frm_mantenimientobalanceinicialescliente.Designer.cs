namespace erp_businessflex
{
    partial class frm_mantenimientobalanceinicialescliente
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
            this.dgc_mantenimientobalanceiniciales = new DevExpress.XtraGrid.GridControl();
            this.dgv_mantenimientobalanceiniciales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_editar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eliminar = new DevExpress.XtraEditors.SimpleButton();
            this.de_desde = new DevExpress.XtraEditors.DateEdit();
            this.de_hasta = new DevExpress.XtraEditors.DateEdit();
            this.btn_consulta = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_desde = new DevExpress.XtraEditors.LabelControl();
            this.lbl_hasta = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_mantenimientobalanceiniciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimientobalanceiniciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgc_mantenimientobalanceiniciales
            // 
            this.dgc_mantenimientobalanceiniciales.Location = new System.Drawing.Point(5, 77);
            this.dgc_mantenimientobalanceiniciales.MainView = this.dgv_mantenimientobalanceiniciales;
            this.dgc_mantenimientobalanceiniciales.Name = "dgc_mantenimientobalanceiniciales";
            this.dgc_mantenimientobalanceiniciales.Size = new System.Drawing.Size(745, 413);
            this.dgc_mantenimientobalanceiniciales.TabIndex = 0;
            this.dgc_mantenimientobalanceiniciales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_mantenimientobalanceiniciales});
            // 
            // dgv_mantenimientobalanceiniciales
            // 
            this.dgv_mantenimientobalanceiniciales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.dgv_mantenimientobalanceiniciales.GridControl = this.dgc_mantenimientobalanceiniciales;
            this.dgv_mantenimientobalanceiniciales.Name = "dgv_mantenimientobalanceiniciales";
            this.dgv_mantenimientobalanceiniciales.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id_registro";
            this.gridColumn1.FieldName = "id_kardexclientemaestro";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cliente";
            this.gridColumn2.FieldName = "cliente";
            this.gridColumn2.MaxWidth = 300;
            this.gridColumn2.MinWidth = 300;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 300;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha";
            this.gridColumn3.FieldName = "fecha";
            this.gridColumn3.MaxWidth = 90;
            this.gridColumn3.MinWidth = 90;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 90;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Valor";
            this.gridColumn4.FieldName = "valor";
            this.gridColumn4.MaxWidth = 80;
            this.gridColumn4.MinWidth = 80;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 80;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "codigo_moneda";
            this.gridColumn5.FieldName = "CodigoMoneda";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "monto_tasa";
            this.gridColumn6.FieldName = "MontoTasa";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Notas";
            this.gridColumn7.FieldName = "nota";
            this.gridColumn7.MaxWidth = 400;
            this.gridColumn7.MinWidth = 400;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 400;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(554, 496);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(651, 496);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // de_desde
            // 
            this.de_desde.EditValue = null;
            this.de_desde.Location = new System.Drawing.Point(6, 39);
            this.de_desde.Name = "de_desde";
            this.de_desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_desde.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_desde.Size = new System.Drawing.Size(100, 20);
            this.de_desde.TabIndex = 3;
            // 
            // de_hasta
            // 
            this.de_hasta.EditValue = null;
            this.de_hasta.Location = new System.Drawing.Point(130, 39);
            this.de_hasta.Name = "de_hasta";
            this.de_hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hasta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_hasta.Size = new System.Drawing.Size(100, 20);
            this.de_hasta.TabIndex = 4;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(252, 37);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_consulta.TabIndex = 5;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // lbl_desde
            // 
            this.lbl_desde.Location = new System.Drawing.Point(7, 24);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(34, 13);
            this.lbl_desde.TabIndex = 6;
            this.lbl_desde.Text = "Desde:";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.Location = new System.Drawing.Point(131, 24);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(32, 13);
            this.lbl_hasta.TabIndex = 7;
            this.lbl_hasta.Text = "Hasta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.de_desde);
            this.groupBox1.Controls.Add(this.btn_consulta);
            this.groupBox1.Controls.Add(this.lbl_hasta);
            this.groupBox1.Controls.Add(this.lbl_desde);
            this.groupBox1.Controls.Add(this.de_hasta);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar:";
            // 
            // frm_mantenimientobalanceinicialescliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgc_mantenimientobalanceiniciales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_mantenimientobalanceinicialescliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Balance Iniciales Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgc_mantenimientobalanceiniciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mantenimientobalanceiniciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hasta.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgc_mantenimientobalanceiniciales;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_mantenimientobalanceiniciales;
        private DevExpress.XtraEditors.SimpleButton btn_editar;
        private DevExpress.XtraEditors.SimpleButton btn_eliminar;
        private DevExpress.XtraEditors.DateEdit de_desde;
        private DevExpress.XtraEditors.DateEdit de_hasta;
        private DevExpress.XtraEditors.SimpleButton btn_consulta;
        private DevExpress.XtraEditors.LabelControl lbl_desde;
        private DevExpress.XtraEditors.LabelControl lbl_hasta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}