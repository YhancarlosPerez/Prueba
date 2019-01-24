namespace erp_businessflex
{
    partial class frm_ordenfactura
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
            this.btn_seleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.dgc_orden = new DevExpress.XtraGrid.GridControl();
            this.dgv_orden = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmb_estadofactura = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgc_orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estadofactura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(358, 344);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 0;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // dgc_orden
            // 
            this.dgc_orden.Location = new System.Drawing.Point(0, 0);
            this.dgc_orden.MainView = this.dgv_orden;
            this.dgc_orden.Name = "dgc_orden";
            this.dgc_orden.Size = new System.Drawing.Size(814, 338);
            this.dgc_orden.TabIndex = 1;
            this.dgc_orden.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_orden});
            // 
            // dgv_orden
            // 
            this.dgv_orden.GridControl = this.dgc_orden;
            this.dgv_orden.Name = "dgv_orden";
            this.dgv_orden.OptionsBehavior.Editable = false;
            this.dgv_orden.OptionsBehavior.ReadOnly = true;
            this.dgv_orden.OptionsView.ShowGroupPanel = false;
            this.dgv_orden.DoubleClick += new System.EventHandler(this.dgv_orden_DoubleClick);
            // 
            // cmb_estadofactura
            // 
            this.cmb_estadofactura.EditValue = "De Contontado";
            this.cmb_estadofactura.Location = new System.Drawing.Point(12, 346);
            this.cmb_estadofactura.Name = "cmb_estadofactura";
            this.cmb_estadofactura.Properties.AutoComplete = false;
            this.cmb_estadofactura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_estadofactura.Properties.Items.AddRange(new object[] {
            "De Contado",
            "Por Cobrar",
            "Todas"});
            this.cmb_estadofactura.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_estadofactura.Size = new System.Drawing.Size(158, 20);
            this.cmb_estadofactura.TabIndex = 2;
            this.cmb_estadofactura.SelectedIndexChanged += new System.EventHandler(this.cmb_estadofactura_SelectedIndexChanged);
            // 
            // frm_ordenfactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 415);
            this.Controls.Add(this.cmb_estadofactura);
            this.Controls.Add(this.dgc_orden);
            this.Controls.Add(this.btn_seleccionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_ordenfactura";
            this.Text = "Orden Factura USO";
            this.Load += new System.EventHandler(this.frm_adelantoorden_Load);
            this.Shown += new System.EventHandler(this.frm_adelantoorden_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgc_orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_estadofactura.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_seleccionar;
        private DevExpress.XtraGrid.GridControl dgc_orden;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_orden;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_estadofactura;
    }
}