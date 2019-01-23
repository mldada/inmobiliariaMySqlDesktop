namespace Inmobiliaria
{
    partial class Frm_Principal
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
            this.Index = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlHader = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.pnlFotter = new System.Windows.Forms.Panel();
            this.BtnReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.BtnNuevoAlquiler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevaVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlVentas = new System.Windows.Forms.Panel();
            this.BtnVentaLoteTerreno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnVentaLocalGalpon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnVentaTipoCasa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnVentaCasaDuplex = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnVentaDepartamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TimerVenta = new System.Windows.Forms.Timer(this.components);
            this.pnlAside = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlBuscar = new System.Windows.Forms.Panel();
            this.BtnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PnlAlquileres = new System.Windows.Forms.Panel();
            this.BtnAlquilerLocalGalpon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAlquilerTipoCasa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAlquilerCasaDuplex = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAlquilerDepartamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnAlquiler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TimerNuevo = new System.Windows.Forms.Timer(this.components);
            this.TimerAlquiler = new System.Windows.Forms.Timer(this.components);
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlHader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.pnlNuevo.SuspendLayout();
            this.PnlVentas.SuspendLayout();
            this.pnlAside.SuspendLayout();
            this.PnlAlquileres.SuspendLayout();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.ElipseRadius = 15;
            this.Index.TargetControl = this;
            // 
            // pnlHader
            // 
            this.pnlHader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnlHader.Controls.Add(this.btnMinimizar);
            this.pnlHader.Controls.Add(this.btnCerrar);
            this.pnlHader.Controls.Add(this.btnMaximizar);
            this.pnlHader.Controls.Add(this.btnRestaurar);
            this.pnlHader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHader.Location = new System.Drawing.Point(0, 0);
            this.pnlHader.Name = "pnlHader";
            this.pnlHader.Size = new System.Drawing.Size(1400, 50);
            this.pnlHader.TabIndex = 0;
            this.pnlHader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHader_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(1290, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(1342, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Location = new System.Drawing.Point(1316, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Location = new System.Drawing.Point(1316, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pnlFotter
            // 
            this.pnlFotter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.pnlFotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFotter.Location = new System.Drawing.Point(0, 728);
            this.pnlFotter.Name = "pnlFotter";
            this.pnlFotter.Size = new System.Drawing.Size(1400, 22);
            this.pnlFotter.TabIndex = 2;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Activecolor = System.Drawing.Color.Transparent;
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReporte.BorderRadius = 0;
            this.BtnReporte.ButtonText = "Reporte";
            this.BtnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporte.DisabledColor = System.Drawing.Color.Gray;
            this.BtnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnReporte.Iconimage = null;
            this.BtnReporte.Iconimage_right = null;
            this.BtnReporte.Iconimage_right_Selected = null;
            this.BtnReporte.Iconimage_Selected = null;
            this.BtnReporte.IconMarginLeft = 0;
            this.BtnReporte.IconMarginRight = 0;
            this.BtnReporte.IconRightVisible = true;
            this.BtnReporte.IconRightZoom = 0D;
            this.BtnReporte.IconVisible = true;
            this.BtnReporte.IconZoom = 90D;
            this.BtnReporte.IsTab = false;
            this.BtnReporte.Location = new System.Drawing.Point(0, 243);
            this.BtnReporte.Margin = new System.Windows.Forms.Padding(0);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnReporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnReporte.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnReporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnReporte.selected = false;
            this.BtnReporte.Size = new System.Drawing.Size(200, 50);
            this.BtnReporte.TabIndex = 4;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnReporte.Textcolor = System.Drawing.Color.White;
            this.BtnReporte.TextFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.BtnNuevoAlquiler);
            this.pnlNuevo.Controls.Add(this.BtnNuevaVenta);
            this.pnlNuevo.Controls.Add(this.BtnNuevo);
            this.pnlNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNuevo.Location = new System.Drawing.Point(0, 193);
            this.pnlNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNuevo.MaximumSize = new System.Drawing.Size(200, 100);
            this.pnlNuevo.MinimumSize = new System.Drawing.Size(200, 50);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(200, 50);
            this.pnlNuevo.TabIndex = 6;
            // 
            // BtnNuevoAlquiler
            // 
            this.BtnNuevoAlquiler.Activecolor = System.Drawing.Color.Transparent;
            this.BtnNuevoAlquiler.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevoAlquiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevoAlquiler.BorderRadius = 0;
            this.BtnNuevoAlquiler.ButtonText = "Alquiler";
            this.BtnNuevoAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoAlquiler.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevoAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNuevoAlquiler.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevoAlquiler.Iconimage = null;
            this.BtnNuevoAlquiler.Iconimage_right = null;
            this.BtnNuevoAlquiler.Iconimage_right_Selected = null;
            this.BtnNuevoAlquiler.Iconimage_Selected = null;
            this.BtnNuevoAlquiler.IconMarginLeft = 0;
            this.BtnNuevoAlquiler.IconMarginRight = 0;
            this.BtnNuevoAlquiler.IconRightVisible = true;
            this.BtnNuevoAlquiler.IconRightZoom = 0D;
            this.BtnNuevoAlquiler.IconVisible = true;
            this.BtnNuevoAlquiler.IconZoom = 90D;
            this.BtnNuevoAlquiler.IsTab = false;
            this.BtnNuevoAlquiler.Location = new System.Drawing.Point(0, 75);
            this.BtnNuevoAlquiler.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevoAlquiler.Name = "BtnNuevoAlquiler";
            this.BtnNuevoAlquiler.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevoAlquiler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevoAlquiler.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnNuevoAlquiler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnNuevoAlquiler.selected = false;
            this.BtnNuevoAlquiler.Size = new System.Drawing.Size(200, 25);
            this.BtnNuevoAlquiler.TabIndex = 4;
            this.BtnNuevoAlquiler.Text = "Alquiler";
            this.BtnNuevoAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevoAlquiler.Textcolor = System.Drawing.Color.White;
            this.BtnNuevoAlquiler.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnNuevoAlquiler.Click += new System.EventHandler(this.BtnNuevoAlquiler_Click);
            // 
            // BtnNuevaVenta
            // 
            this.BtnNuevaVenta.Activecolor = System.Drawing.Color.Transparent;
            this.BtnNuevaVenta.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevaVenta.BorderRadius = 0;
            this.BtnNuevaVenta.ButtonText = "Venta";
            this.BtnNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevaVenta.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNuevaVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevaVenta.Iconimage = null;
            this.BtnNuevaVenta.Iconimage_right = null;
            this.BtnNuevaVenta.Iconimage_right_Selected = null;
            this.BtnNuevaVenta.Iconimage_Selected = null;
            this.BtnNuevaVenta.IconMarginLeft = 0;
            this.BtnNuevaVenta.IconMarginRight = 0;
            this.BtnNuevaVenta.IconRightVisible = true;
            this.BtnNuevaVenta.IconRightZoom = 0D;
            this.BtnNuevaVenta.IconVisible = true;
            this.BtnNuevaVenta.IconZoom = 90D;
            this.BtnNuevaVenta.IsTab = false;
            this.BtnNuevaVenta.Location = new System.Drawing.Point(0, 50);
            this.BtnNuevaVenta.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevaVenta.Name = "BtnNuevaVenta";
            this.BtnNuevaVenta.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnNuevaVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevaVenta.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnNuevaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnNuevaVenta.selected = false;
            this.BtnNuevaVenta.Size = new System.Drawing.Size(200, 25);
            this.BtnNuevaVenta.TabIndex = 2;
            this.BtnNuevaVenta.Text = "Venta";
            this.BtnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevaVenta.Textcolor = System.Drawing.Color.White;
            this.BtnNuevaVenta.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnNuevaVenta.Click += new System.EventHandler(this.BtnNuevaVenta_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Activecolor = System.Drawing.Color.Transparent;
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevo.BorderRadius = 0;
            this.BtnNuevo.ButtonText = "Nuevo";
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Iconimage = null;
            this.BtnNuevo.Iconimage_right = null;
            this.BtnNuevo.Iconimage_right_Selected = null;
            this.BtnNuevo.Iconimage_Selected = null;
            this.BtnNuevo.IconMarginLeft = 0;
            this.BtnNuevo.IconMarginRight = 0;
            this.BtnNuevo.IconRightVisible = true;
            this.BtnNuevo.IconRightZoom = 0D;
            this.BtnNuevo.IconVisible = true;
            this.BtnNuevo.IconZoom = 90D;
            this.BtnNuevo.IsTab = false;
            this.BtnNuevo.Location = new System.Drawing.Point(0, 0);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnNuevo.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnNuevo.selected = false;
            this.BtnNuevo.Size = new System.Drawing.Size(200, 50);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNuevo.Textcolor = System.Drawing.Color.White;
            this.BtnNuevo.TextFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PnlVentas
            // 
            this.PnlVentas.Controls.Add(this.BtnVentaLoteTerreno);
            this.PnlVentas.Controls.Add(this.BtnVentaLocalGalpon);
            this.PnlVentas.Controls.Add(this.BtnVentaTipoCasa);
            this.PnlVentas.Controls.Add(this.BtnVentaCasaDuplex);
            this.PnlVentas.Controls.Add(this.BtnVentaDepartamento);
            this.PnlVentas.Controls.Add(this.BtnVenta);
            this.PnlVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlVentas.Location = new System.Drawing.Point(0, 93);
            this.PnlVentas.Margin = new System.Windows.Forms.Padding(0);
            this.PnlVentas.MaximumSize = new System.Drawing.Size(200, 175);
            this.PnlVentas.MinimumSize = new System.Drawing.Size(200, 50);
            this.PnlVentas.Name = "PnlVentas";
            this.PnlVentas.Size = new System.Drawing.Size(200, 50);
            this.PnlVentas.TabIndex = 0;
            // 
            // BtnVentaLoteTerreno
            // 
            this.BtnVentaLoteTerreno.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVentaLoteTerreno.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaLoteTerreno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentaLoteTerreno.BorderRadius = 0;
            this.BtnVentaLoteTerreno.ButtonText = "Lote / Terreno";
            this.BtnVentaLoteTerreno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentaLoteTerreno.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentaLoteTerreno.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentaLoteTerreno.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentaLoteTerreno.Iconimage = null;
            this.BtnVentaLoteTerreno.Iconimage_right = null;
            this.BtnVentaLoteTerreno.Iconimage_right_Selected = null;
            this.BtnVentaLoteTerreno.Iconimage_Selected = null;
            this.BtnVentaLoteTerreno.IconMarginLeft = 0;
            this.BtnVentaLoteTerreno.IconMarginRight = 0;
            this.BtnVentaLoteTerreno.IconRightVisible = true;
            this.BtnVentaLoteTerreno.IconRightZoom = 0D;
            this.BtnVentaLoteTerreno.IconVisible = true;
            this.BtnVentaLoteTerreno.IconZoom = 90D;
            this.BtnVentaLoteTerreno.IsTab = false;
            this.BtnVentaLoteTerreno.Location = new System.Drawing.Point(0, 150);
            this.BtnVentaLoteTerreno.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentaLoteTerreno.Name = "BtnVentaLoteTerreno";
            this.BtnVentaLoteTerreno.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaLoteTerreno.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentaLoteTerreno.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVentaLoteTerreno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVentaLoteTerreno.selected = false;
            this.BtnVentaLoteTerreno.Size = new System.Drawing.Size(200, 25);
            this.BtnVentaLoteTerreno.TabIndex = 7;
            this.BtnVentaLoteTerreno.Text = "Lote / Terreno";
            this.BtnVentaLoteTerreno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentaLoteTerreno.Textcolor = System.Drawing.Color.White;
            this.BtnVentaLoteTerreno.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnVentaLoteTerreno.Click += new System.EventHandler(this.BtnVentaLoteTerreno_Click);
            // 
            // BtnVentaLocalGalpon
            // 
            this.BtnVentaLocalGalpon.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVentaLocalGalpon.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaLocalGalpon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentaLocalGalpon.BorderRadius = 0;
            this.BtnVentaLocalGalpon.ButtonText = "Local / Galpón";
            this.BtnVentaLocalGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentaLocalGalpon.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentaLocalGalpon.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentaLocalGalpon.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentaLocalGalpon.Iconimage = null;
            this.BtnVentaLocalGalpon.Iconimage_right = null;
            this.BtnVentaLocalGalpon.Iconimage_right_Selected = null;
            this.BtnVentaLocalGalpon.Iconimage_Selected = null;
            this.BtnVentaLocalGalpon.IconMarginLeft = 0;
            this.BtnVentaLocalGalpon.IconMarginRight = 0;
            this.BtnVentaLocalGalpon.IconRightVisible = true;
            this.BtnVentaLocalGalpon.IconRightZoom = 0D;
            this.BtnVentaLocalGalpon.IconVisible = true;
            this.BtnVentaLocalGalpon.IconZoom = 90D;
            this.BtnVentaLocalGalpon.IsTab = false;
            this.BtnVentaLocalGalpon.Location = new System.Drawing.Point(0, 125);
            this.BtnVentaLocalGalpon.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentaLocalGalpon.Name = "BtnVentaLocalGalpon";
            this.BtnVentaLocalGalpon.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaLocalGalpon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentaLocalGalpon.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVentaLocalGalpon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVentaLocalGalpon.selected = false;
            this.BtnVentaLocalGalpon.Size = new System.Drawing.Size(200, 25);
            this.BtnVentaLocalGalpon.TabIndex = 6;
            this.BtnVentaLocalGalpon.Text = "Local / Galpón";
            this.BtnVentaLocalGalpon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentaLocalGalpon.Textcolor = System.Drawing.Color.White;
            this.BtnVentaLocalGalpon.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnVentaLocalGalpon.Click += new System.EventHandler(this.BtnVentaLocalGalpon_Click);
            // 
            // BtnVentaTipoCasa
            // 
            this.BtnVentaTipoCasa.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVentaTipoCasa.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaTipoCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentaTipoCasa.BorderRadius = 0;
            this.BtnVentaTipoCasa.ButtonText = "Tipo Casa";
            this.BtnVentaTipoCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentaTipoCasa.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentaTipoCasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentaTipoCasa.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentaTipoCasa.Iconimage = null;
            this.BtnVentaTipoCasa.Iconimage_right = null;
            this.BtnVentaTipoCasa.Iconimage_right_Selected = null;
            this.BtnVentaTipoCasa.Iconimage_Selected = null;
            this.BtnVentaTipoCasa.IconMarginLeft = 0;
            this.BtnVentaTipoCasa.IconMarginRight = 0;
            this.BtnVentaTipoCasa.IconRightVisible = true;
            this.BtnVentaTipoCasa.IconRightZoom = 0D;
            this.BtnVentaTipoCasa.IconVisible = true;
            this.BtnVentaTipoCasa.IconZoom = 90D;
            this.BtnVentaTipoCasa.IsTab = false;
            this.BtnVentaTipoCasa.Location = new System.Drawing.Point(0, 100);
            this.BtnVentaTipoCasa.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentaTipoCasa.Name = "BtnVentaTipoCasa";
            this.BtnVentaTipoCasa.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaTipoCasa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentaTipoCasa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVentaTipoCasa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVentaTipoCasa.selected = false;
            this.BtnVentaTipoCasa.Size = new System.Drawing.Size(200, 25);
            this.BtnVentaTipoCasa.TabIndex = 5;
            this.BtnVentaTipoCasa.Text = "Tipo Casa";
            this.BtnVentaTipoCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentaTipoCasa.Textcolor = System.Drawing.Color.White;
            this.BtnVentaTipoCasa.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnVentaTipoCasa.Click += new System.EventHandler(this.BtnVentaTipoCasa_Click);
            // 
            // BtnVentaCasaDuplex
            // 
            this.BtnVentaCasaDuplex.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVentaCasaDuplex.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaCasaDuplex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentaCasaDuplex.BorderRadius = 0;
            this.BtnVentaCasaDuplex.ButtonText = "Casa / Dúplex";
            this.BtnVentaCasaDuplex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentaCasaDuplex.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentaCasaDuplex.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentaCasaDuplex.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentaCasaDuplex.Iconimage = null;
            this.BtnVentaCasaDuplex.Iconimage_right = null;
            this.BtnVentaCasaDuplex.Iconimage_right_Selected = null;
            this.BtnVentaCasaDuplex.Iconimage_Selected = null;
            this.BtnVentaCasaDuplex.IconMarginLeft = 0;
            this.BtnVentaCasaDuplex.IconMarginRight = 0;
            this.BtnVentaCasaDuplex.IconRightVisible = true;
            this.BtnVentaCasaDuplex.IconRightZoom = 0D;
            this.BtnVentaCasaDuplex.IconVisible = true;
            this.BtnVentaCasaDuplex.IconZoom = 90D;
            this.BtnVentaCasaDuplex.IsTab = false;
            this.BtnVentaCasaDuplex.Location = new System.Drawing.Point(0, 75);
            this.BtnVentaCasaDuplex.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentaCasaDuplex.Name = "BtnVentaCasaDuplex";
            this.BtnVentaCasaDuplex.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaCasaDuplex.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentaCasaDuplex.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVentaCasaDuplex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVentaCasaDuplex.selected = false;
            this.BtnVentaCasaDuplex.Size = new System.Drawing.Size(200, 25);
            this.BtnVentaCasaDuplex.TabIndex = 4;
            this.BtnVentaCasaDuplex.Text = "Casa / Dúplex";
            this.BtnVentaCasaDuplex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentaCasaDuplex.Textcolor = System.Drawing.Color.White;
            this.BtnVentaCasaDuplex.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnVentaCasaDuplex.Click += new System.EventHandler(this.BtnVentaCasaDuplex_Click);
            // 
            // BtnVentaDepartamento
            // 
            this.BtnVentaDepartamento.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVentaDepartamento.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVentaDepartamento.BorderRadius = 0;
            this.BtnVentaDepartamento.ButtonText = "Departamento";
            this.BtnVentaDepartamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentaDepartamento.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVentaDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentaDepartamento.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVentaDepartamento.Iconimage = null;
            this.BtnVentaDepartamento.Iconimage_right = null;
            this.BtnVentaDepartamento.Iconimage_right_Selected = null;
            this.BtnVentaDepartamento.Iconimage_Selected = null;
            this.BtnVentaDepartamento.IconMarginLeft = 0;
            this.BtnVentaDepartamento.IconMarginRight = 0;
            this.BtnVentaDepartamento.IconRightVisible = true;
            this.BtnVentaDepartamento.IconRightZoom = 0D;
            this.BtnVentaDepartamento.IconVisible = true;
            this.BtnVentaDepartamento.IconZoom = 90D;
            this.BtnVentaDepartamento.IsTab = false;
            this.BtnVentaDepartamento.Location = new System.Drawing.Point(0, 50);
            this.BtnVentaDepartamento.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentaDepartamento.Name = "BtnVentaDepartamento";
            this.BtnVentaDepartamento.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnVentaDepartamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVentaDepartamento.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVentaDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVentaDepartamento.selected = false;
            this.BtnVentaDepartamento.Size = new System.Drawing.Size(200, 25);
            this.BtnVentaDepartamento.TabIndex = 2;
            this.BtnVentaDepartamento.Text = "Departamento";
            this.BtnVentaDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentaDepartamento.Textcolor = System.Drawing.Color.White;
            this.BtnVentaDepartamento.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentaDepartamento.Click += new System.EventHandler(this.BtnVentaDepartamento_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.Activecolor = System.Drawing.Color.Transparent;
            this.BtnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVenta.BorderRadius = 0;
            this.BtnVenta.ButtonText = "Venta";
            this.BtnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVenta.DisabledColor = System.Drawing.Color.Gray;
            this.BtnVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnVenta.Iconimage = null;
            this.BtnVenta.Iconimage_right = null;
            this.BtnVenta.Iconimage_right_Selected = null;
            this.BtnVenta.Iconimage_Selected = null;
            this.BtnVenta.IconMarginLeft = 0;
            this.BtnVenta.IconMarginRight = 0;
            this.BtnVenta.IconRightVisible = true;
            this.BtnVenta.IconRightZoom = 0D;
            this.BtnVenta.IconVisible = true;
            this.BtnVenta.IconZoom = 90D;
            this.BtnVenta.IsTab = false;
            this.BtnVenta.Location = new System.Drawing.Point(0, 0);
            this.BtnVenta.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnVenta.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnVenta.selected = false;
            this.BtnVenta.Size = new System.Drawing.Size(200, 50);
            this.BtnVenta.TabIndex = 1;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVenta.Textcolor = System.Drawing.Color.White;
            this.BtnVenta.TextFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // TimerVenta
            // 
            this.TimerVenta.Interval = 15;
            this.TimerVenta.Tick += new System.EventHandler(this.TimerVenta_Tick);
            // 
            // pnlAside
            // 
            this.pnlAside.BackColor = System.Drawing.Color.Black;
            this.pnlAside.Controls.Add(this.PnlBuscar);
            this.pnlAside.Controls.Add(this.BtnInicio);
            this.pnlAside.Controls.Add(this.PnlVentas);
            this.pnlAside.Controls.Add(this.PnlAlquileres);
            this.pnlAside.Controls.Add(this.pnlNuevo);
            this.pnlAside.Controls.Add(this.BtnReporte);
            this.pnlAside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAside.Location = new System.Drawing.Point(0, 50);
            this.pnlAside.Name = "pnlAside";
            this.pnlAside.Size = new System.Drawing.Size(194, 678);
            this.pnlAside.TabIndex = 0;
            // 
            // PnlBuscar
            // 
            this.PnlBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.PnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.PnlBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBuscar.Name = "PnlBuscar";
            this.PnlBuscar.Size = new System.Drawing.Size(200, 43);
            this.PnlBuscar.TabIndex = 0;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInicio.BorderRadius = 0;
            this.BtnInicio.ButtonText = "Inicio";
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.DisabledColor = System.Drawing.Color.White;
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInicio.Iconimage = null;
            this.BtnInicio.Iconimage_right = null;
            this.BtnInicio.Iconimage_right_Selected = null;
            this.BtnInicio.Iconimage_Selected = null;
            this.BtnInicio.IconMarginLeft = 0;
            this.BtnInicio.IconMarginRight = 0;
            this.BtnInicio.IconRightVisible = true;
            this.BtnInicio.IconRightZoom = 0D;
            this.BtnInicio.IconVisible = true;
            this.BtnInicio.IconZoom = 90D;
            this.BtnInicio.IsTab = false;
            this.BtnInicio.Location = new System.Drawing.Point(0, 43);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnInicio.OnHovercolor = System.Drawing.Color.White;
            this.BtnInicio.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnInicio.selected = false;
            this.BtnInicio.Size = new System.Drawing.Size(200, 50);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnInicio.Textcolor = System.Drawing.Color.Transparent;
            this.BtnInicio.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // PnlAlquileres
            // 
            this.PnlAlquileres.Controls.Add(this.BtnAlquilerLocalGalpon);
            this.PnlAlquileres.Controls.Add(this.BtnAlquilerTipoCasa);
            this.PnlAlquileres.Controls.Add(this.BtnAlquilerCasaDuplex);
            this.PnlAlquileres.Controls.Add(this.BtnAlquilerDepartamento);
            this.PnlAlquileres.Controls.Add(this.BtnAlquiler);
            this.PnlAlquileres.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAlquileres.Location = new System.Drawing.Point(0, 143);
            this.PnlAlquileres.Margin = new System.Windows.Forms.Padding(0);
            this.PnlAlquileres.MaximumSize = new System.Drawing.Size(200, 150);
            this.PnlAlquileres.MinimumSize = new System.Drawing.Size(200, 50);
            this.PnlAlquileres.Name = "PnlAlquileres";
            this.PnlAlquileres.Size = new System.Drawing.Size(200, 50);
            this.PnlAlquileres.TabIndex = 7;
            // 
            // BtnAlquilerLocalGalpon
            // 
            this.BtnAlquilerLocalGalpon.Activecolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerLocalGalpon.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerLocalGalpon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlquilerLocalGalpon.BorderRadius = 0;
            this.BtnAlquilerLocalGalpon.ButtonText = "Local / Galpón";
            this.BtnAlquilerLocalGalpon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlquilerLocalGalpon.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerLocalGalpon.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlquilerLocalGalpon.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerLocalGalpon.Iconimage = null;
            this.BtnAlquilerLocalGalpon.Iconimage_right = null;
            this.BtnAlquilerLocalGalpon.Iconimage_right_Selected = null;
            this.BtnAlquilerLocalGalpon.Iconimage_Selected = null;
            this.BtnAlquilerLocalGalpon.IconMarginLeft = 0;
            this.BtnAlquilerLocalGalpon.IconMarginRight = 0;
            this.BtnAlquilerLocalGalpon.IconRightVisible = true;
            this.BtnAlquilerLocalGalpon.IconRightZoom = 0D;
            this.BtnAlquilerLocalGalpon.IconVisible = true;
            this.BtnAlquilerLocalGalpon.IconZoom = 90D;
            this.BtnAlquilerLocalGalpon.IsTab = false;
            this.BtnAlquilerLocalGalpon.Location = new System.Drawing.Point(0, 125);
            this.BtnAlquilerLocalGalpon.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlquilerLocalGalpon.Name = "BtnAlquilerLocalGalpon";
            this.BtnAlquilerLocalGalpon.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerLocalGalpon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAlquilerLocalGalpon.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnAlquilerLocalGalpon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlquilerLocalGalpon.selected = false;
            this.BtnAlquilerLocalGalpon.Size = new System.Drawing.Size(200, 25);
            this.BtnAlquilerLocalGalpon.TabIndex = 6;
            this.BtnAlquilerLocalGalpon.Text = "Local / Galpón";
            this.BtnAlquilerLocalGalpon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAlquilerLocalGalpon.Textcolor = System.Drawing.Color.White;
            this.BtnAlquilerLocalGalpon.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnAlquilerLocalGalpon.Click += new System.EventHandler(this.BtnAlquilerLocalGalpon_Click);
            // 
            // BtnAlquilerTipoCasa
            // 
            this.BtnAlquilerTipoCasa.Activecolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerTipoCasa.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerTipoCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlquilerTipoCasa.BorderRadius = 0;
            this.BtnAlquilerTipoCasa.ButtonText = "Tipo Casa";
            this.BtnAlquilerTipoCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlquilerTipoCasa.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerTipoCasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlquilerTipoCasa.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerTipoCasa.Iconimage = null;
            this.BtnAlquilerTipoCasa.Iconimage_right = null;
            this.BtnAlquilerTipoCasa.Iconimage_right_Selected = null;
            this.BtnAlquilerTipoCasa.Iconimage_Selected = null;
            this.BtnAlquilerTipoCasa.IconMarginLeft = 0;
            this.BtnAlquilerTipoCasa.IconMarginRight = 0;
            this.BtnAlquilerTipoCasa.IconRightVisible = true;
            this.BtnAlquilerTipoCasa.IconRightZoom = 0D;
            this.BtnAlquilerTipoCasa.IconVisible = true;
            this.BtnAlquilerTipoCasa.IconZoom = 90D;
            this.BtnAlquilerTipoCasa.IsTab = false;
            this.BtnAlquilerTipoCasa.Location = new System.Drawing.Point(0, 100);
            this.BtnAlquilerTipoCasa.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlquilerTipoCasa.Name = "BtnAlquilerTipoCasa";
            this.BtnAlquilerTipoCasa.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerTipoCasa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAlquilerTipoCasa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnAlquilerTipoCasa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlquilerTipoCasa.selected = false;
            this.BtnAlquilerTipoCasa.Size = new System.Drawing.Size(200, 25);
            this.BtnAlquilerTipoCasa.TabIndex = 5;
            this.BtnAlquilerTipoCasa.Text = "Tipo Casa";
            this.BtnAlquilerTipoCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAlquilerTipoCasa.Textcolor = System.Drawing.Color.White;
            this.BtnAlquilerTipoCasa.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnAlquilerTipoCasa.Click += new System.EventHandler(this.BtnAlquilerTipoCasa_Click);
            // 
            // BtnAlquilerCasaDuplex
            // 
            this.BtnAlquilerCasaDuplex.Activecolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerCasaDuplex.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerCasaDuplex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlquilerCasaDuplex.BorderRadius = 0;
            this.BtnAlquilerCasaDuplex.ButtonText = "Casa / Dúplex";
            this.BtnAlquilerCasaDuplex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlquilerCasaDuplex.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerCasaDuplex.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlquilerCasaDuplex.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerCasaDuplex.Iconimage = null;
            this.BtnAlquilerCasaDuplex.Iconimage_right = null;
            this.BtnAlquilerCasaDuplex.Iconimage_right_Selected = null;
            this.BtnAlquilerCasaDuplex.Iconimage_Selected = null;
            this.BtnAlquilerCasaDuplex.IconMarginLeft = 0;
            this.BtnAlquilerCasaDuplex.IconMarginRight = 0;
            this.BtnAlquilerCasaDuplex.IconRightVisible = true;
            this.BtnAlquilerCasaDuplex.IconRightZoom = 0D;
            this.BtnAlquilerCasaDuplex.IconVisible = true;
            this.BtnAlquilerCasaDuplex.IconZoom = 90D;
            this.BtnAlquilerCasaDuplex.IsTab = false;
            this.BtnAlquilerCasaDuplex.Location = new System.Drawing.Point(0, 75);
            this.BtnAlquilerCasaDuplex.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlquilerCasaDuplex.Name = "BtnAlquilerCasaDuplex";
            this.BtnAlquilerCasaDuplex.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerCasaDuplex.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAlquilerCasaDuplex.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnAlquilerCasaDuplex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlquilerCasaDuplex.selected = false;
            this.BtnAlquilerCasaDuplex.Size = new System.Drawing.Size(200, 25);
            this.BtnAlquilerCasaDuplex.TabIndex = 4;
            this.BtnAlquilerCasaDuplex.Text = "Casa / Dúplex";
            this.BtnAlquilerCasaDuplex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAlquilerCasaDuplex.Textcolor = System.Drawing.Color.White;
            this.BtnAlquilerCasaDuplex.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnAlquilerCasaDuplex.Click += new System.EventHandler(this.BtnAlquilerCasaDuplex_Click);
            // 
            // BtnAlquilerDepartamento
            // 
            this.BtnAlquilerDepartamento.Activecolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerDepartamento.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlquilerDepartamento.BorderRadius = 0;
            this.BtnAlquilerDepartamento.ButtonText = "Departamento";
            this.BtnAlquilerDepartamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlquilerDepartamento.DisabledColor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlquilerDepartamento.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAlquilerDepartamento.Iconimage = null;
            this.BtnAlquilerDepartamento.Iconimage_right = null;
            this.BtnAlquilerDepartamento.Iconimage_right_Selected = null;
            this.BtnAlquilerDepartamento.Iconimage_Selected = null;
            this.BtnAlquilerDepartamento.IconMarginLeft = 0;
            this.BtnAlquilerDepartamento.IconMarginRight = 0;
            this.BtnAlquilerDepartamento.IconRightVisible = true;
            this.BtnAlquilerDepartamento.IconRightZoom = 0D;
            this.BtnAlquilerDepartamento.IconVisible = true;
            this.BtnAlquilerDepartamento.IconZoom = 90D;
            this.BtnAlquilerDepartamento.IsTab = false;
            this.BtnAlquilerDepartamento.Location = new System.Drawing.Point(0, 50);
            this.BtnAlquilerDepartamento.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlquilerDepartamento.Name = "BtnAlquilerDepartamento";
            this.BtnAlquilerDepartamento.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.BtnAlquilerDepartamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAlquilerDepartamento.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnAlquilerDepartamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlquilerDepartamento.selected = false;
            this.BtnAlquilerDepartamento.Size = new System.Drawing.Size(200, 25);
            this.BtnAlquilerDepartamento.TabIndex = 2;
            this.BtnAlquilerDepartamento.Text = "Departamento";
            this.BtnAlquilerDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAlquilerDepartamento.Textcolor = System.Drawing.Color.White;
            this.BtnAlquilerDepartamento.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnAlquilerDepartamento.Click += new System.EventHandler(this.BtnAlquilerDepartamento_Click);
            // 
            // BtnAlquiler
            // 
            this.BtnAlquiler.Activecolor = System.Drawing.Color.Transparent;
            this.BtnAlquiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnAlquiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAlquiler.BorderRadius = 0;
            this.BtnAlquiler.ButtonText = "Alquiler";
            this.BtnAlquiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlquiler.DisabledColor = System.Drawing.Color.Gray;
            this.BtnAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlquiler.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnAlquiler.Iconimage = null;
            this.BtnAlquiler.Iconimage_right = null;
            this.BtnAlquiler.Iconimage_right_Selected = null;
            this.BtnAlquiler.Iconimage_Selected = null;
            this.BtnAlquiler.IconMarginLeft = 0;
            this.BtnAlquiler.IconMarginRight = 0;
            this.BtnAlquiler.IconRightVisible = true;
            this.BtnAlquiler.IconRightZoom = 0D;
            this.BtnAlquiler.IconVisible = true;
            this.BtnAlquiler.IconZoom = 90D;
            this.BtnAlquiler.IsTab = false;
            this.BtnAlquiler.Location = new System.Drawing.Point(0, 0);
            this.BtnAlquiler.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlquiler.Name = "BtnAlquiler";
            this.BtnAlquiler.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.BtnAlquiler.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAlquiler.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.BtnAlquiler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlquiler.selected = false;
            this.BtnAlquiler.Size = new System.Drawing.Size(200, 50);
            this.BtnAlquiler.TabIndex = 1;
            this.BtnAlquiler.Text = "Alquiler";
            this.BtnAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAlquiler.Textcolor = System.Drawing.Color.White;
            this.BtnAlquiler.TextFont = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BtnAlquiler.Click += new System.EventHandler(this.BtnAlquiler_Click);
            // 
            // TimerNuevo
            // 
            this.TimerNuevo.Interval = 10;
            this.TimerNuevo.Tick += new System.EventHandler(this.TimerNuevo_Tick);
            // 
            // TimerAlquiler
            // 
            this.TimerAlquiler.Interval = 10;
            this.TimerAlquiler.Tick += new System.EventHandler(this.TimerAlquiler_Tick);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(194, 50);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1206, 678);
            this.pnlContenido.TabIndex = 3;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlAside);
            this.Controls.Add(this.pnlFotter);
            this.Controls.Add(this.pnlHader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Index";
            this.pnlHader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.pnlNuevo.ResumeLayout(false);
            this.PnlVentas.ResumeLayout(false);
            this.pnlAside.ResumeLayout(false);
            this.PnlAlquileres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Index;
        private System.Windows.Forms.Panel pnlFotter;
        private System.Windows.Forms.Panel pnlHader;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInicio;
        private Bunifu.Framework.UI.BunifuFlatButton BtnReporte;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVenta;
        private System.Windows.Forms.Panel PnlVentas;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVentaTipoCasa;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVentaCasaDuplex;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVentaDepartamento;
        private System.Windows.Forms.Timer TimerVenta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVentaLocalGalpon;
        private System.Windows.Forms.FlowLayoutPanel pnlAside;
        private System.Windows.Forms.Panel pnlNuevo;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevoAlquiler;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevaVenta;
        private Bunifu.Framework.UI.BunifuFlatButton BtnNuevo;
        private System.Windows.Forms.Timer TimerNuevo;
        private System.Windows.Forms.Panel PnlAlquileres;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAlquilerLocalGalpon;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAlquilerTipoCasa;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAlquilerCasaDuplex;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAlquilerDepartamento;
        private Bunifu.Framework.UI.BunifuFlatButton BtnAlquiler;
        private Bunifu.Framework.UI.BunifuFlatButton BtnVentaLoteTerreno;
        private System.Windows.Forms.Timer TimerAlquiler;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel PnlBuscar;
    }
}