namespace Inmobiliaria
{
    partial class VentaCasaDuplex
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPrimario = new DevExpress.XtraEditors.PanelControl();
            this.PnlCentral = new DevExpress.XtraEditors.PanelControl();
            this.PnlDerecho = new DevExpress.XtraEditors.PanelControl();
            this.PnlIzquierdo = new DevExpress.XtraEditors.PanelControl();
            this.PnlPie = new DevExpress.XtraEditors.PanelControl();
            this.PnlEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.GdVentaCasaDuplex = new DevExpress.XtraGrid.GridControl();
            this.gridViewVentaCasaDuplex = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPrimario)).BeginInit();
            this.PnlPrimario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlCentral)).BeginInit();
            this.PnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlDerecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlIzquierdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdVentaCasaDuplex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentaCasaDuplex)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrimario
            // 
            this.PnlPrimario.Controls.Add(this.PnlCentral);
            this.PnlPrimario.Controls.Add(this.PnlDerecho);
            this.PnlPrimario.Controls.Add(this.PnlIzquierdo);
            this.PnlPrimario.Controls.Add(this.PnlPie);
            this.PnlPrimario.Controls.Add(this.PnlEncabezado);
            this.PnlPrimario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrimario.Location = new System.Drawing.Point(0, 0);
            this.PnlPrimario.Name = "PnlPrimario";
            this.PnlPrimario.Size = new System.Drawing.Size(1217, 535);
            this.PnlPrimario.TabIndex = 0;
            // 
            // PnlCentral
            // 
            this.PnlCentral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlCentral.Controls.Add(this.GdVentaCasaDuplex);
            this.PnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCentral.Location = new System.Drawing.Point(32, 67);
            this.PnlCentral.Name = "PnlCentral";
            this.PnlCentral.Size = new System.Drawing.Size(1153, 436);
            this.PnlCentral.TabIndex = 4;
            // 
            // PnlDerecho
            // 
            this.PnlDerecho.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecho.Location = new System.Drawing.Point(1185, 67);
            this.PnlDerecho.Name = "PnlDerecho";
            this.PnlDerecho.Size = new System.Drawing.Size(30, 436);
            this.PnlDerecho.TabIndex = 3;
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(2, 67);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(30, 436);
            this.PnlIzquierdo.TabIndex = 2;
            // 
            // PnlPie
            // 
            this.PnlPie.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPie.Location = new System.Drawing.Point(2, 503);
            this.PnlPie.Name = "PnlPie";
            this.PnlPie.Size = new System.Drawing.Size(1213, 30);
            this.PnlPie.TabIndex = 1;
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(2, 2);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(1213, 65);
            this.PnlEncabezado.TabIndex = 0;
            // 
            // GdVentaCasaDuplex
            // 
            this.GdVentaCasaDuplex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdVentaCasaDuplex.Location = new System.Drawing.Point(0, 0);
            this.GdVentaCasaDuplex.MainView = this.gridViewVentaCasaDuplex;
            this.GdVentaCasaDuplex.Name = "GdVentaCasaDuplex";
            this.GdVentaCasaDuplex.Size = new System.Drawing.Size(1153, 436);
            this.GdVentaCasaDuplex.TabIndex = 0;
            this.GdVentaCasaDuplex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVentaCasaDuplex});
            // 
            // gridViewVentaCasaDuplex
            // 
            this.gridViewVentaCasaDuplex.GridControl = this.GdVentaCasaDuplex;
            this.gridViewVentaCasaDuplex.Name = "gridViewVentaCasaDuplex";
            this.gridViewVentaCasaDuplex.OptionsView.ShowGroupPanel = false;
            // 
            // VentaCasaDuplex
            // 
            this.Controls.Add(this.PnlPrimario);
            this.Name = "VentaCasaDuplex";
            this.Size = new System.Drawing.Size(1217, 535);
            ((System.ComponentModel.ISupportInitialize)(this.PnlPrimario)).EndInit();
            this.PnlPrimario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlCentral)).EndInit();
            this.PnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlDerecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlIzquierdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GdVentaCasaDuplex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentaCasaDuplex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PnlPrimario;
        private DevExpress.XtraEditors.PanelControl PnlCentral;
        private DevExpress.XtraEditors.PanelControl PnlDerecho;
        private DevExpress.XtraEditors.PanelControl PnlIzquierdo;
        private DevExpress.XtraEditors.PanelControl PnlPie;
        private DevExpress.XtraEditors.PanelControl PnlEncabezado;
        private DevExpress.XtraGrid.GridControl GdVentaCasaDuplex;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVentaCasaDuplex;
    }
}
