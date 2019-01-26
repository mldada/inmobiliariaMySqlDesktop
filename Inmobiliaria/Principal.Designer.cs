namespace Inmobiliaria
{
    partial class Principal
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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.ContenedorPrincipal = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnVentaDepartamento = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnVentaCasaDuplex = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnVentaTipoCasa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnVentaLocalGalpon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnVentaLoteTerreno = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnAlquilerDepartamento = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnAlquilerCasaDuplex = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnAlquilerTipoCasa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnAlquilerLocalGalpon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnNuevaVenta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnNuevoAlquiler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.BtnBuscar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(176, 27);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.Size = new System.Drawing.Size(1014, 535);
            this.ContenedorPrincipal.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement13,
            this.accordionControlElement12});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(176, 535);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnVentaDepartamento,
            this.BtnVentaCasaDuplex,
            this.BtnVentaTipoCasa,
            this.BtnVentaLocalGalpon,
            this.BtnVentaLoteTerreno});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Venta";
            // 
            // BtnVentaDepartamento
            // 
            this.BtnVentaDepartamento.Name = "BtnVentaDepartamento";
            this.BtnVentaDepartamento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnVentaDepartamento.Text = "Departamento";
            this.BtnVentaDepartamento.Click += new System.EventHandler(this.BtnVentaDepartamento_Click);
            // 
            // BtnVentaCasaDuplex
            // 
            this.BtnVentaCasaDuplex.Name = "BtnVentaCasaDuplex";
            this.BtnVentaCasaDuplex.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnVentaCasaDuplex.Text = "Casa Duplex";
            this.BtnVentaCasaDuplex.Click += new System.EventHandler(this.BtnVentaCasaDuplex_Click);
            // 
            // BtnVentaTipoCasa
            // 
            this.BtnVentaTipoCasa.Name = "BtnVentaTipoCasa";
            this.BtnVentaTipoCasa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnVentaTipoCasa.Text = "Tipo Casa";
            this.BtnVentaTipoCasa.Click += new System.EventHandler(this.BtnVentaTipoCasa_Click);
            // 
            // BtnVentaLocalGalpon
            // 
            this.BtnVentaLocalGalpon.Name = "BtnVentaLocalGalpon";
            this.BtnVentaLocalGalpon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnVentaLocalGalpon.Text = "Local - Galpon";
            this.BtnVentaLocalGalpon.Click += new System.EventHandler(this.BtnVentaLocalGalpon_Click);
            // 
            // BtnVentaLoteTerreno
            // 
            this.BtnVentaLoteTerreno.Name = "BtnVentaLoteTerreno";
            this.BtnVentaLoteTerreno.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnVentaLoteTerreno.Text = "Lote - Terreno";
            this.BtnVentaLoteTerreno.Click += new System.EventHandler(this.BtnVentaLoteTerreno_Click);
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnAlquilerDepartamento,
            this.BtnAlquilerCasaDuplex,
            this.BtnAlquilerTipoCasa,
            this.BtnAlquilerLocalGalpon});
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Text = "Alquiler";
            // 
            // BtnAlquilerDepartamento
            // 
            this.BtnAlquilerDepartamento.Name = "BtnAlquilerDepartamento";
            this.BtnAlquilerDepartamento.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnAlquilerDepartamento.Text = "Departamento";
            this.BtnAlquilerDepartamento.Click += new System.EventHandler(this.BtnAlquilerDepartamento_Click);
            // 
            // BtnAlquilerCasaDuplex
            // 
            this.BtnAlquilerCasaDuplex.Name = "BtnAlquilerCasaDuplex";
            this.BtnAlquilerCasaDuplex.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnAlquilerCasaDuplex.Text = "Casa Duplex";
            this.BtnAlquilerCasaDuplex.Click += new System.EventHandler(this.BtnAlquilerCasaDuplex_Click);
            // 
            // BtnAlquilerTipoCasa
            // 
            this.BtnAlquilerTipoCasa.Name = "BtnAlquilerTipoCasa";
            this.BtnAlquilerTipoCasa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnAlquilerTipoCasa.Text = "Tipo Casa";
            this.BtnAlquilerTipoCasa.Click += new System.EventHandler(this.BtnAlquilerTipoCasa_Click);
            // 
            // BtnAlquilerLocalGalpon
            // 
            this.BtnAlquilerLocalGalpon.Name = "BtnAlquilerLocalGalpon";
            this.BtnAlquilerLocalGalpon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnAlquilerLocalGalpon.Text = "Local - Galpon";
            this.BtnAlquilerLocalGalpon.Click += new System.EventHandler(this.BtnAlquilerLocalGalpon_Click);
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnNuevaVenta,
            this.BtnNuevoAlquiler,
            this.BtnBuscar});
            this.accordionControlElement12.Expanded = true;
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Text = "Nuevo";
            // 
            // BtnNuevaVenta
            // 
            this.BtnNuevaVenta.Name = "BtnNuevaVenta";
            this.BtnNuevaVenta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnNuevaVenta.Text = "Venta";
            this.BtnNuevaVenta.Click += new System.EventHandler(this.BtnNuevaVenta_Click);
            // 
            // BtnNuevoAlquiler
            // 
            this.BtnNuevoAlquiler.Name = "BtnNuevoAlquiler";
            this.BtnNuevoAlquiler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnNuevoAlquiler.Text = "Aqluiler";
            this.BtnNuevoAlquiler.Click += new System.EventHandler(this.BtnNuevoAlquiler_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1190, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(156, 122);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 562);
            this.ControlContainer = this.ContenedorPrincipal;
            this.Controls.Add(this.ContenedorPrincipal);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joyel Propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer ContenedorPrincipal;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnVentaDepartamento;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnVentaCasaDuplex;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnVentaTipoCasa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnVentaLocalGalpon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnVentaLoteTerreno;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnAlquilerDepartamento;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnAlquilerCasaDuplex;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnAlquilerTipoCasa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnAlquilerLocalGalpon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnNuevaVenta;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnNuevoAlquiler;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnBuscar;
    }
}