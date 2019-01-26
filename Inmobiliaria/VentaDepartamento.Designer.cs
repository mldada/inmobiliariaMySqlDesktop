namespace Inmobiliaria
{
    partial class VentaDepartamento
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaDepartamento));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.GdVentaDepartamento = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewVentaDepartamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_inmueble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_propiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc_tipo_propiedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coles_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsuperficie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaltura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_localidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc_localidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryAutoAjusteVertical = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldc_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant_ambientes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapto_credito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryAC = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.PnlContenedorPrincipalVentaDepartamento = new DevExpress.XtraEditors.PanelControl();
            this.PnlContenedor = new DevExpress.XtraEditors.PanelControl();
            this.PnlDerecho = new DevExpress.XtraEditors.PanelControl();
            this.PnlIzquierdo = new DevExpress.XtraEditors.PanelControl();
            this.PnlPie = new DevExpress.XtraEditors.PanelControl();
            this.PnlEncabezado = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GdVentaDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentaDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAutoAjusteVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlContenedorPrincipalVentaDepartamento)).BeginInit();
            this.PnlContenedorPrincipalVentaDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlContenedor)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlDerecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlIzquierdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlEncabezado)).BeginInit();
            this.PnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // GdVentaDepartamento
            // 
            this.GdVentaDepartamento.DataMember = "joyel_testing_Sp_Buscar_Inmuebles";
            this.GdVentaDepartamento.DataSource = this.sqlDataSource1;
            this.GdVentaDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GdVentaDepartamento.Location = new System.Drawing.Point(2, 2);
            this.GdVentaDepartamento.MainView = this.gridViewVentaDepartamento;
            this.GdVentaDepartamento.Name = "GdVentaDepartamento";
            this.GdVentaDepartamento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnEditar,
            this.repositoryAutoAjusteVertical,
            this.repositoryAC});
            this.GdVentaDepartamento.Size = new System.Drawing.Size(946, 432);
            this.GdVentaDepartamento.TabIndex = 0;
            this.GdVentaDepartamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVentaDepartamento});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "179.43.126.9_joyel_testing_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "joyel_testing_Sp_Buscar_Inmuebles";
            queryParameter1.Name = "@p_id_tipo_propiedad";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "1";
            queryParameter2.Name = "@p_es_venta";
            queryParameter2.Type = typeof(ulong);
            queryParameter2.ValueInfo = "1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "joyel_testing.Sp_Buscar_Inmuebles";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewVentaDepartamento
            // 
            this.gridViewVentaDepartamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_inmueble,
            this.colid_tipo_propiedad,
            this.coldc_tipo_propiedad,
            this.coles_venta,
            this.colimporte,
            this.colsuperficie,
            this.colcalle,
            this.colaltura,
            this.colid_localidad,
            this.coldc_localidad,
            this.coldescripcion,
            this.colid_estado,
            this.coldc_estado,
            this.colcant_ambientes,
            this.colpiso,
            this.coldepto,
            this.colapto_credito,
            this.editar});
            this.gridViewVentaDepartamento.GridControl = this.GdVentaDepartamento;
            this.gridViewVentaDepartamento.Name = "gridViewVentaDepartamento";
            this.gridViewVentaDepartamento.OptionsView.RowAutoHeight = true;
            this.gridViewVentaDepartamento.OptionsView.ShowGroupPanel = false;
            // 
            // colid_inmueble
            // 
            this.colid_inmueble.AppearanceCell.Options.UseTextOptions = true;
            this.colid_inmueble.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_inmueble.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_inmueble.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_inmueble.Caption = "ID";
            this.colid_inmueble.FieldName = "id_inmueble";
            this.colid_inmueble.Name = "colid_inmueble";
            this.colid_inmueble.OptionsColumn.AllowEdit = false;
            this.colid_inmueble.OptionsFilter.AllowAutoFilter = false;
            this.colid_inmueble.Visible = true;
            this.colid_inmueble.VisibleIndex = 0;
            this.colid_inmueble.Width = 38;
            // 
            // colid_tipo_propiedad
            // 
            this.colid_tipo_propiedad.FieldName = "id_tipo_propiedad";
            this.colid_tipo_propiedad.Name = "colid_tipo_propiedad";
            // 
            // coldc_tipo_propiedad
            // 
            this.coldc_tipo_propiedad.FieldName = "dc_tipo_propiedad";
            this.coldc_tipo_propiedad.Name = "coldc_tipo_propiedad";
            // 
            // coles_venta
            // 
            this.coles_venta.FieldName = "es_venta";
            this.coles_venta.Name = "coles_venta";
            // 
            // colimporte
            // 
            this.colimporte.AppearanceHeader.Options.UseTextOptions = true;
            this.colimporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colimporte.Caption = "IMPORTE";
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 9;
            this.colimporte.Width = 56;
            // 
            // colsuperficie
            // 
            this.colsuperficie.AppearanceCell.Options.UseTextOptions = true;
            this.colsuperficie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsuperficie.AppearanceHeader.Options.UseTextOptions = true;
            this.colsuperficie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsuperficie.Caption = "SUP.";
            this.colsuperficie.FieldName = "superficie";
            this.colsuperficie.Name = "colsuperficie";
            this.colsuperficie.OptionsColumn.AllowEdit = false;
            this.colsuperficie.Visible = true;
            this.colsuperficie.VisibleIndex = 7;
            this.colsuperficie.Width = 36;
            // 
            // colcalle
            // 
            this.colcalle.AppearanceHeader.Options.UseTextOptions = true;
            this.colcalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcalle.Caption = "CALLE";
            this.colcalle.FieldName = "calle";
            this.colcalle.Name = "colcalle";
            this.colcalle.OptionsColumn.AllowEdit = false;
            this.colcalle.Visible = true;
            this.colcalle.VisibleIndex = 1;
            this.colcalle.Width = 100;
            // 
            // colaltura
            // 
            this.colaltura.AppearanceCell.Options.UseTextOptions = true;
            this.colaltura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaltura.AppearanceHeader.Options.UseTextOptions = true;
            this.colaltura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colaltura.Caption = "ALTURA";
            this.colaltura.FieldName = "altura";
            this.colaltura.Name = "colaltura";
            this.colaltura.OptionsColumn.AllowEdit = false;
            this.colaltura.Visible = true;
            this.colaltura.VisibleIndex = 2;
            this.colaltura.Width = 50;
            // 
            // colid_localidad
            // 
            this.colid_localidad.FieldName = "id_localidad";
            this.colid_localidad.Name = "colid_localidad";
            // 
            // coldc_localidad
            // 
            this.coldc_localidad.Caption = "LOCALIDAD";
            this.coldc_localidad.FieldName = "dc_localidad";
            this.coldc_localidad.Name = "coldc_localidad";
            this.coldc_localidad.OptionsColumn.AllowEdit = false;
            this.coldc_localidad.Visible = true;
            this.coldc_localidad.VisibleIndex = 3;
            this.coldc_localidad.Width = 104;
            // 
            // coldescripcion
            // 
            this.coldescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.coldescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldescripcion.Caption = "DESCRIPCION";
            this.coldescripcion.ColumnEdit = this.repositoryAutoAjusteVertical;
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 8;
            this.coldescripcion.Width = 329;
            // 
            // repositoryAutoAjusteVertical
            // 
            this.repositoryAutoAjusteVertical.Name = "repositoryAutoAjusteVertical";
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // coldc_estado
            // 
            this.coldc_estado.AppearanceCell.Options.UseTextOptions = true;
            this.coldc_estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldc_estado.AppearanceHeader.Options.UseTextOptions = true;
            this.coldc_estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldc_estado.Caption = "EST.";
            this.coldc_estado.FieldName = "dc_estado";
            this.coldc_estado.Name = "coldc_estado";
            this.coldc_estado.OptionsColumn.AllowEdit = false;
            this.coldc_estado.Visible = true;
            this.coldc_estado.VisibleIndex = 10;
            this.coldc_estado.Width = 40;
            // 
            // colcant_ambientes
            // 
            this.colcant_ambientes.AppearanceCell.Options.UseTextOptions = true;
            this.colcant_ambientes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcant_ambientes.AppearanceHeader.Options.UseTextOptions = true;
            this.colcant_ambientes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcant_ambientes.Caption = "AMB.";
            this.colcant_ambientes.FieldName = "cant_ambientes";
            this.colcant_ambientes.Name = "colcant_ambientes";
            this.colcant_ambientes.OptionsColumn.AllowEdit = false;
            this.colcant_ambientes.Visible = true;
            this.colcant_ambientes.VisibleIndex = 6;
            this.colcant_ambientes.Width = 37;
            // 
            // colpiso
            // 
            this.colpiso.AppearanceCell.Options.UseTextOptions = true;
            this.colpiso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpiso.AppearanceHeader.Options.UseTextOptions = true;
            this.colpiso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colpiso.Caption = "PISO";
            this.colpiso.FieldName = "piso";
            this.colpiso.Name = "colpiso";
            this.colpiso.OptionsColumn.AllowEdit = false;
            this.colpiso.Visible = true;
            this.colpiso.VisibleIndex = 4;
            this.colpiso.Width = 39;
            // 
            // coldepto
            // 
            this.coldepto.AppearanceCell.Options.UseTextOptions = true;
            this.coldepto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldepto.AppearanceHeader.Options.UseTextOptions = true;
            this.coldepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldepto.Caption = "DEP.";
            this.coldepto.FieldName = "depto";
            this.coldepto.Name = "coldepto";
            this.coldepto.OptionsColumn.AllowEdit = false;
            this.coldepto.Visible = true;
            this.coldepto.VisibleIndex = 5;
            this.coldepto.Width = 37;
            // 
            // colapto_credito
            // 
            this.colapto_credito.AppearanceHeader.Options.UseTextOptions = true;
            this.colapto_credito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colapto_credito.Caption = "AC";
            this.colapto_credito.ColumnEdit = this.repositoryAC;
            this.colapto_credito.FieldName = "apto_credito";
            this.colapto_credito.Name = "colapto_credito";
            this.colapto_credito.OptionsColumn.AllowEdit = false;
            this.colapto_credito.Visible = true;
            this.colapto_credito.VisibleIndex = 11;
            this.colapto_credito.Width = 33;
            // 
            // repositoryAC
            // 
            this.repositoryAC.AutoHeight = false;
            this.repositoryAC.Name = "repositoryAC";
            this.repositoryAC.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // editar
            // 
            this.editar.ColumnEdit = this.BtnEditar;
            this.editar.Name = "editar";
            this.editar.Visible = true;
            this.editar.VisibleIndex = 12;
            this.editar.Width = 29;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.BtnEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnEditar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnEditar_ButtonClick);
            // 
            // PnlContenedorPrincipalVentaDepartamento
            // 
            this.PnlContenedorPrincipalVentaDepartamento.Controls.Add(this.PnlContenedor);
            this.PnlContenedorPrincipalVentaDepartamento.Controls.Add(this.PnlDerecho);
            this.PnlContenedorPrincipalVentaDepartamento.Controls.Add(this.PnlIzquierdo);
            this.PnlContenedorPrincipalVentaDepartamento.Controls.Add(this.PnlPie);
            this.PnlContenedorPrincipalVentaDepartamento.Controls.Add(this.PnlEncabezado);
            this.PnlContenedorPrincipalVentaDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedorPrincipalVentaDepartamento.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedorPrincipalVentaDepartamento.Name = "PnlContenedorPrincipalVentaDepartamento";
            this.PnlContenedorPrincipalVentaDepartamento.Size = new System.Drawing.Size(1014, 535);
            this.PnlContenedorPrincipalVentaDepartamento.TabIndex = 6;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.GdVentaDepartamento);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(32, 67);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(950, 436);
            this.PnlContenedor.TabIndex = 10;
            // 
            // PnlDerecho
            // 
            this.PnlDerecho.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecho.Location = new System.Drawing.Point(982, 67);
            this.PnlDerecho.Name = "PnlDerecho";
            this.PnlDerecho.Size = new System.Drawing.Size(30, 436);
            this.PnlDerecho.TabIndex = 9;
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(2, 67);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(30, 436);
            this.PnlIzquierdo.TabIndex = 8;
            // 
            // PnlPie
            // 
            this.PnlPie.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPie.Location = new System.Drawing.Point(2, 503);
            this.PnlPie.Name = "PnlPie";
            this.PnlPie.Size = new System.Drawing.Size(1010, 30);
            this.PnlPie.TabIndex = 7;
            // 
            // PnlEncabezado
            // 
            this.PnlEncabezado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PnlEncabezado.Controls.Add(this.layoutControl1);
            this.PnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlEncabezado.Location = new System.Drawing.Point(2, 2);
            this.PnlEncabezado.Name = "PnlEncabezado";
            this.PnlEncabezado.Size = new System.Drawing.Size(1010, 65);
            this.PnlEncabezado.TabIndex = 6;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.separatorControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1010, 65);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 28);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(986, 25);
            this.separatorControl1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1010, 65);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem1.Control = this.separatorControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(990, 45);
            this.layoutControlItem1.Text = "VENTA DEPARTAMENTO";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(116, 13);
            // 
            // VentaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlContenedorPrincipalVentaDepartamento);
            this.Name = "VentaDepartamento";
            this.Size = new System.Drawing.Size(1014, 535);
            this.Load += new System.EventHandler(this.VentaDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GdVentaDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentaDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAutoAjusteVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlContenedorPrincipalVentaDepartamento)).EndInit();
            this.PnlContenedorPrincipalVentaDepartamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlContenedor)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlDerecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlIzquierdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlEncabezado)).EndInit();
            this.PnlEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GdVentaDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVentaDepartamento;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_inmueble;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_propiedad;
        private DevExpress.XtraGrid.Columns.GridColumn coldc_tipo_propiedad;
        private DevExpress.XtraGrid.Columns.GridColumn coles_venta;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn colsuperficie;
        private DevExpress.XtraGrid.Columns.GridColumn colcalle;
        private DevExpress.XtraGrid.Columns.GridColumn colaltura;
        private DevExpress.XtraGrid.Columns.GridColumn colid_localidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldc_localidad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn coldc_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcant_ambientes;
        private DevExpress.XtraGrid.Columns.GridColumn colpiso;
        private DevExpress.XtraGrid.Columns.GridColumn coldepto;
        private DevExpress.XtraGrid.Columns.GridColumn editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnEditar;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PanelControl PnlContenedorPrincipalVentaDepartamento;
        private DevExpress.XtraEditors.PanelControl PnlEncabezado;
        private DevExpress.XtraEditors.PanelControl PnlPie;
        private DevExpress.XtraEditors.PanelControl PnlIzquierdo;
        private DevExpress.XtraEditors.PanelControl PnlDerecho;
        private DevExpress.XtraEditors.PanelControl PnlContenedor;
        private DevExpress.XtraGrid.Columns.GridColumn colapto_credito;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryAutoAjusteVertical;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryAC;
    }
}
