
namespace PV2
{
    partial class frmNVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVenta));
            this.pcVentas = new DevExpress.XtraEditors.PanelControl();
            this.gcVentas = new DevExpress.XtraGrid.GridControl();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupClientes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlupUsuarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.checkMayoreo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbCajero = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnIngresar = new DevExpress.XtraEditors.SimpleButton();
            this.rlupMarcas = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblImporte = new DevExpress.XtraEditors.LabelControl();
            this.lblDescuento = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcVentas)).BeginInit();
            this.pcVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMayoreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCajero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcVentas
            // 
            this.pcVentas.Controls.Add(this.gcVentas);
            this.pcVentas.Location = new System.Drawing.Point(27, 152);
            this.pcVentas.Name = "pcVentas";
            this.pcVentas.Size = new System.Drawing.Size(928, 452);
            this.pcVentas.TabIndex = 0;
            // 
            // gcVentas
            // 
            this.gcVentas.DataSource = this.ventasBindingSource;
            this.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVentas.Location = new System.Drawing.Point(2, 2);
            this.gcVentas.MainView = this.gvVentas;
            this.gcVentas.Name = "gcVentas";
            this.gcVentas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupProductos,
            this.rlupClientes,
            this.rlupUsuarios,
            this.rlupMarcas,
            this.repositoryItemLookUpEdit1});
            this.gcVentas.Size = new System.Drawing.Size(924, 448);
            this.gcVentas.TabIndex = 0;
            this.gcVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVentas});
            this.gcVentas.Click += new System.EventHandler(this.gcVentas_Click);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(BML.Ventas);
            // 
            // gvVentas
            // 
            this.gvVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidVenta,
            this.colfolio,
            this.colfecha,
            this.colidProducto,
            this.colcantidad,
            this.colimporte,
            this.coldescuento,
            this.coltotal,
            this.colestatus,
            this.colidCliente,
            this.colidUsuario,
            this.colactivo});
            this.gvVentas.GridControl = this.gcVentas;
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.OptionsBehavior.Editable = false;
            this.gvVentas.OptionsView.ShowAutoFilterRow = true;
            this.gvVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "ID";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.MinWidth = 25;
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 0;
            this.colidVenta.Width = 94;
            // 
            // colfolio
            // 
            this.colfolio.Caption = "Folio";
            this.colfolio.FieldName = "folio";
            this.colfolio.MinWidth = 25;
            this.colfolio.Name = "colfolio";
            this.colfolio.Visible = true;
            this.colfolio.VisibleIndex = 1;
            this.colfolio.Width = 94;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 25;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            this.colfecha.Width = 94;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "Producto";
            this.colidProducto.ColumnEdit = this.rlupProductos;
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.MinWidth = 25;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 3;
            this.colidProducto.Width = 94;
            // 
            // rlupProductos
            // 
            this.rlupProductos.AutoHeight = false;
            this.rlupProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupProductos.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProducto", "id Producto", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descripcion", "descripcion", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "id Categoria", 80, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("precioUnitario", "precio Unitario", 94, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("stock", "stock", 41, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 48, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "id Marca", 60, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupProductos.DataSource = this.productoBindingSource;
            this.rlupProductos.DisplayMember = "descripcion";
            this.rlupProductos.Name = "rlupProductos";
            this.rlupProductos.ValueMember = "idProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BML.Producto);
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 25;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 4;
            this.colcantidad.Width = 94;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.FieldName = "importe";
            this.colimporte.MinWidth = 25;
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 5;
            this.colimporte.Width = 94;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.MinWidth = 25;
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 6;
            this.coldescuento.Width = 94;
            // 
            // coltotal
            // 
            this.coltotal.Caption = "Total";
            this.coltotal.FieldName = "total";
            this.coltotal.MinWidth = 25;
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 7;
            this.coltotal.Width = 94;
            // 
            // colestatus
            // 
            this.colestatus.Caption = "Status";
            this.colestatus.FieldName = "estatus";
            this.colestatus.MinWidth = 25;
            this.colestatus.Name = "colestatus";
            this.colestatus.Visible = true;
            this.colestatus.VisibleIndex = 8;
            this.colestatus.Width = 94;
            // 
            // colidCliente
            // 
            this.colidCliente.Caption = "Cliente";
            this.colidCliente.ColumnEdit = this.rlupClientes;
            this.colidCliente.FieldName = "idCliente";
            this.colidCliente.MinWidth = 25;
            this.colidCliente.Name = "colidCliente";
            this.colidCliente.Visible = true;
            this.colidCliente.VisibleIndex = 9;
            this.colidCliente.Width = 94;
            // 
            // rlupClientes
            // 
            this.rlupClientes.AutoHeight = false;
            this.rlupClientes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupClientes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 64, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apPaterno", "ap Paterno", 73, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apMaterno", "ap Materno", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 62, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cp", "cp", 24, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 48, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupClientes.DataSource = this.clienteBindingSource;
            this.rlupClientes.DisplayMember = "nombre";
            this.rlupClientes.Name = "rlupClientes";
            this.rlupClientes.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(BML.Cliente);
            // 
            // colidUsuario
            // 
            this.colidUsuario.Caption = "Cajero";
            this.colidUsuario.ColumnEdit = this.rlupUsuarios;
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.MinWidth = 25;
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 10;
            this.colidUsuario.Width = 94;
            // 
            // rlupUsuarios
            // 
            this.rlupUsuarios.AutoHeight = false;
            this.rlupUsuarios.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupUsuarios.DataSource = this.usuarioBindingSource;
            this.rlupUsuarios.DisplayMember = "nombre";
            this.rlupUsuarios.Name = "rlupUsuarios";
            this.rlupUsuarios.ValueMember = "idUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(BML.Usuario);
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 94;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cliente: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Codigo: ";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(97, 13);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCliente", "id Cliente", 64, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apPaterno", "ap Paterno", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("apMaterno", "ap Materno", 76, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("direccion", "direccion", 62, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("telefono", "telefono", 57, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cp", "cp", 24, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("codigo", "codigo", 48, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.clienteBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "nombre";
            this.lookUpEdit1.Properties.ValueMember = "idCliente";
            this.lookUpEdit1.Size = new System.Drawing.Size(222, 22);
            this.lookUpEdit1.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 62);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(222, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // checkMayoreo
            // 
            this.checkMayoreo.Location = new System.Drawing.Point(356, 16);
            this.checkMayoreo.Name = "checkMayoreo";
            this.checkMayoreo.Properties.Caption = "Mayoreo";
            this.checkMayoreo.Size = new System.Drawing.Size(94, 24);
            this.checkMayoreo.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(680, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Cajero: ";
            // 
            // cbCajero
            // 
            this.cbCajero.Location = new System.Drawing.Point(733, 21);
            this.cbCajero.Name = "cbCajero";
            this.cbCajero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCajero.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idUsuario", "id Usuario", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nombre", "nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("password", "password", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 44, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cbCajero.Properties.DataSource = this.usuarioBindingSource;
            this.cbCajero.Properties.DisplayMember = "nombre";
            this.cbCajero.Properties.ValueMember = "idUsuario";
            this.cbCajero.Size = new System.Drawing.Size(222, 22);
            this.cbCajero.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Importe: ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(381, 112);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Descuento: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(765, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Total: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Appearance.Options.UseFont = true;
            this.btnIngresar.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIngresar.AppearancePressed.Options.UseBackColor = true;
            this.btnIngresar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnIngresar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIngresar.ImageOptions.SvgImage")));
            this.btnIngresar.Location = new System.Drawing.Point(456, 12);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnIngresar.Size = new System.Drawing.Size(182, 79);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Nueva venta";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // rlupMarcas
            // 
            this.rlupMarcas.AutoHeight = false;
            this.rlupMarcas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupMarcas.Name = "rlupMarcas";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // lblImporte
            // 
            this.lblImporte.Location = new System.Drawing.Point(101, 112);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(32, 16);
            this.lblImporte.TabIndex = 12;
            this.lblImporte.Text = "$0.00";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Location = new System.Drawing.Point(473, 112);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(19, 16);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.Text = "%0";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(832, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 16);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "$0.00";
            // 
            // frmNVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 639);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbCajero);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.checkMayoreo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pcVentas);
            this.Name = "frmNVenta";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmNVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcVentas)).EndInit();
            this.pcVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMayoreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCajero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcVentas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.CheckEdit checkMayoreo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cbCajero;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnIngresar;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.GridControl gcVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVentas;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colfolio;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn colestatus;
        private DevExpress.XtraGrid.Columns.GridColumn colidCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupProductos;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupUsuarios;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupMarcas;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.LabelControl lblImporte;
        private DevExpress.XtraEditors.LabelControl lblDescuento;
        private DevExpress.XtraEditors.LabelControl lblTotal;
    }
}