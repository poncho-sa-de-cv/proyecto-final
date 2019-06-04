namespace Proyecto_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.BtnRes = new System.Windows.Forms.PictureBox();
            this.btnMaxi = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnReporteProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgOrdenes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReporteInvent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentasHoy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.TitleBar.Controls.Add(this.BtnRes);
            this.TitleBar.Controls.Add(this.btnMaxi);
            this.TitleBar.Controls.Add(this.BtnMin);
            this.TitleBar.Controls.Add(this.btnCerrar);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1386, 37);
            this.TitleBar.TabIndex = 2;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // BtnRes
            // 
            this.BtnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRes.Image = global::Proyecto_01.Properties.Resources.res;
            this.BtnRes.Location = new System.Drawing.Point(1327, 3);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(25, 25);
            this.BtnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnRes.TabIndex = 3;
            this.BtnRes.TabStop = false;
            this.BtnRes.Visible = false;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxi.Image = global::Proyecto_01.Properties.Resources.maxi;
            this.btnMaxi.Location = new System.Drawing.Point(1327, 3);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(25, 25);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaxi.TabIndex = 2;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = global::Proyecto_01.Properties.Resources.minimazar;
            this.BtnMin.Location = new System.Drawing.Point(1296, 3);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(25, 25);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMin.TabIndex = 1;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Proyecto_01.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1358, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(-35, 34);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.btnReporteProductos);
            this.splitContainerControl1.Panel1.Controls.Add(this.imgVenta);
            this.splitContainerControl1.Panel1.Controls.Add(this.imgOrdenes);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnReporteInvent);
            this.splitContainerControl1.Panel1.Controls.Add(this.imgProducto);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnMenu);
            this.splitContainerControl1.Panel1.Controls.Add(this.imgReporte);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnVentasHoy);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1456, 693);
            this.splitContainerControl1.SplitterPosition = 271;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // btnReporteProductos
            // 
            this.btnReporteProductos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReporteProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnReporteProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporteProductos.BorderRadius = 0;
            this.btnReporteProductos.ButtonText = "Productos";
            this.btnReporteProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnReporteProductos.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReporteProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReporteProductos.Iconimage")));
            this.btnReporteProductos.Iconimage_right = null;
            this.btnReporteProductos.Iconimage_right_Selected = null;
            this.btnReporteProductos.Iconimage_Selected = null;
            this.btnReporteProductos.IconMarginLeft = 0;
            this.btnReporteProductos.IconMarginRight = 0;
            this.btnReporteProductos.IconRightVisible = true;
            this.btnReporteProductos.IconRightZoom = 0D;
            this.btnReporteProductos.IconVisible = true;
            this.btnReporteProductos.IconZoom = 90D;
            this.btnReporteProductos.IsTab = false;
            this.btnReporteProductos.Location = new System.Drawing.Point(86, 579);
            this.btnReporteProductos.Name = "btnReporteProductos";
            this.btnReporteProductos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnReporteProductos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReporteProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReporteProductos.selected = false;
            this.btnReporteProductos.Size = new System.Drawing.Size(134, 37);
            this.btnReporteProductos.TabIndex = 17;
            this.btnReporteProductos.Text = "Productos";
            this.btnReporteProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteProductos.Textcolor = System.Drawing.Color.White;
            this.btnReporteProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProductos.Visible = false;
            this.btnReporteProductos.Click += new System.EventHandler(this.btnReporteComple_Click);
            // 
            // imgVenta
            // 
            this.imgVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVenta.BorderRadius = 0;
            this.imgVenta.ButtonText = "Venta";
            this.imgVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgVenta.DisabledColor = System.Drawing.Color.Gray;
            this.imgVenta.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgVenta.Iconimage = ((System.Drawing.Image)(resources.GetObject("imgVenta.Iconimage")));
            this.imgVenta.Iconimage_right = null;
            this.imgVenta.Iconimage_right_Selected = null;
            this.imgVenta.Iconimage_Selected = null;
            this.imgVenta.IconMarginLeft = 0;
            this.imgVenta.IconMarginRight = 0;
            this.imgVenta.IconRightVisible = true;
            this.imgVenta.IconRightZoom = 0D;
            this.imgVenta.IconVisible = true;
            this.imgVenta.IconZoom = 90D;
            this.imgVenta.IsTab = false;
            this.imgVenta.Location = new System.Drawing.Point(42, 251);
            this.imgVenta.Name = "imgVenta";
            this.imgVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.imgVenta.selected = false;
            this.imgVenta.Size = new System.Drawing.Size(152, 48);
            this.imgVenta.TabIndex = 11;
            this.imgVenta.Text = "Venta";
            this.imgVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgVenta.Textcolor = System.Drawing.Color.White;
            this.imgVenta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgVenta.Click += new System.EventHandler(this.imgVenta_Click_1);
            // 
            // imgOrdenes
            // 
            this.imgOrdenes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOrdenes.BorderRadius = 0;
            this.imgOrdenes.ButtonText = "Tareas";
            this.imgOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgOrdenes.DisabledColor = System.Drawing.Color.Gray;
            this.imgOrdenes.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgOrdenes.Iconimage = ((System.Drawing.Image)(resources.GetObject("imgOrdenes.Iconimage")));
            this.imgOrdenes.Iconimage_right = null;
            this.imgOrdenes.Iconimage_right_Selected = null;
            this.imgOrdenes.Iconimage_Selected = null;
            this.imgOrdenes.IconMarginLeft = 0;
            this.imgOrdenes.IconMarginRight = 0;
            this.imgOrdenes.IconRightVisible = true;
            this.imgOrdenes.IconRightZoom = 0D;
            this.imgOrdenes.IconVisible = true;
            this.imgOrdenes.IconZoom = 90D;
            this.imgOrdenes.IsTab = false;
            this.imgOrdenes.Location = new System.Drawing.Point(42, 305);
            this.imgOrdenes.Name = "imgOrdenes";
            this.imgOrdenes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgOrdenes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgOrdenes.OnHoverTextColor = System.Drawing.Color.White;
            this.imgOrdenes.selected = false;
            this.imgOrdenes.Size = new System.Drawing.Size(152, 48);
            this.imgOrdenes.TabIndex = 12;
            this.imgOrdenes.Text = "Tareas";
            this.imgOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgOrdenes.Textcolor = System.Drawing.Color.White;
            this.imgOrdenes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgOrdenes.Click += new System.EventHandler(this.imgOrdenes_Click_1);
            // 
            // btnReporteInvent
            // 
            this.btnReporteInvent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReporteInvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnReporteInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporteInvent.BorderRadius = 0;
            this.btnReporteInvent.ButtonText = "Inventario";
            this.btnReporteInvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteInvent.DisabledColor = System.Drawing.Color.Gray;
            this.btnReporteInvent.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReporteInvent.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReporteInvent.Iconimage")));
            this.btnReporteInvent.Iconimage_right = null;
            this.btnReporteInvent.Iconimage_right_Selected = null;
            this.btnReporteInvent.Iconimage_Selected = null;
            this.btnReporteInvent.IconMarginLeft = 0;
            this.btnReporteInvent.IconMarginRight = 0;
            this.btnReporteInvent.IconRightVisible = true;
            this.btnReporteInvent.IconRightZoom = 0D;
            this.btnReporteInvent.IconVisible = true;
            this.btnReporteInvent.IconZoom = 90D;
            this.btnReporteInvent.IsTab = false;
            this.btnReporteInvent.Location = new System.Drawing.Point(86, 546);
            this.btnReporteInvent.Name = "btnReporteInvent";
            this.btnReporteInvent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnReporteInvent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReporteInvent.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReporteInvent.selected = false;
            this.btnReporteInvent.Size = new System.Drawing.Size(134, 37);
            this.btnReporteInvent.TabIndex = 16;
            this.btnReporteInvent.Text = "Inventario";
            this.btnReporteInvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteInvent.Textcolor = System.Drawing.Color.White;
            this.btnReporteInvent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteInvent.Visible = false;
            this.btnReporteInvent.Click += new System.EventHandler(this.btnReporteInvent_Click);
            // 
            // imgProducto
            // 
            this.imgProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProducto.BorderRadius = 0;
            this.imgProducto.ButtonText = "Producto";
            this.imgProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgProducto.DisabledColor = System.Drawing.Color.Gray;
            this.imgProducto.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("imgProducto.Iconimage")));
            this.imgProducto.Iconimage_right = null;
            this.imgProducto.Iconimage_right_Selected = null;
            this.imgProducto.Iconimage_Selected = null;
            this.imgProducto.IconMarginLeft = 0;
            this.imgProducto.IconMarginRight = 0;
            this.imgProducto.IconRightVisible = true;
            this.imgProducto.IconRightZoom = 0D;
            this.imgProducto.IconVisible = true;
            this.imgProducto.IconZoom = 90D;
            this.imgProducto.IsTab = false;
            this.imgProducto.Location = new System.Drawing.Point(42, 359);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.imgProducto.selected = false;
            this.imgProducto.Size = new System.Drawing.Size(152, 48);
            this.imgProducto.TabIndex = 13;
            this.imgProducto.Text = "Producto";
            this.imgProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgProducto.Textcolor = System.Drawing.Color.White;
            this.imgProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgProducto.Click += new System.EventHandler(this.imgProducto_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "Menu";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenu.Iconimage")));
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 0;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 90D;
            this.btnMenu.IsTab = false;
            this.btnMenu.Location = new System.Drawing.Point(42, 197);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenu.selected = false;
            this.btnMenu.Size = new System.Drawing.Size(152, 48);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Textcolor = System.Drawing.Color.White;
            this.btnMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_2);
            // 
            // imgReporte
            // 
            this.imgReporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgReporte.BorderRadius = 0;
            this.imgReporte.ButtonText = "Reporte";
            this.imgReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgReporte.DisabledColor = System.Drawing.Color.Gray;
            this.imgReporte.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgReporte.Iconimage = ((System.Drawing.Image)(resources.GetObject("imgReporte.Iconimage")));
            this.imgReporte.Iconimage_right = null;
            this.imgReporte.Iconimage_right_Selected = null;
            this.imgReporte.Iconimage_Selected = null;
            this.imgReporte.IconMarginLeft = 0;
            this.imgReporte.IconMarginRight = 0;
            this.imgReporte.IconRightVisible = true;
            this.imgReporte.IconRightZoom = 0D;
            this.imgReporte.IconVisible = true;
            this.imgReporte.IconZoom = 90D;
            this.imgReporte.IsTab = false;
            this.imgReporte.Location = new System.Drawing.Point(42, 467);
            this.imgReporte.Name = "imgReporte";
            this.imgReporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.imgReporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.imgReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.imgReporte.selected = false;
            this.imgReporte.Size = new System.Drawing.Size(152, 48);
            this.imgReporte.TabIndex = 14;
            this.imgReporte.Text = "Reporte";
            this.imgReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imgReporte.Textcolor = System.Drawing.Color.White;
            this.imgReporte.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgReporte.Click += new System.EventHandler(this.imgReporte_Click_1);
            // 
            // btnVentasHoy
            // 
            this.btnVentasHoy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVentasHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnVentasHoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentasHoy.BorderRadius = 0;
            this.btnVentasHoy.ButtonText = "Ventas de hoy";
            this.btnVentasHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentasHoy.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentasHoy.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVentasHoy.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentasHoy.Iconimage")));
            this.btnVentasHoy.Iconimage_right = null;
            this.btnVentasHoy.Iconimage_right_Selected = null;
            this.btnVentasHoy.Iconimage_Selected = null;
            this.btnVentasHoy.IconMarginLeft = 0;
            this.btnVentasHoy.IconMarginRight = 0;
            this.btnVentasHoy.IconRightVisible = true;
            this.btnVentasHoy.IconRightZoom = 0D;
            this.btnVentasHoy.IconVisible = true;
            this.btnVentasHoy.IconZoom = 90D;
            this.btnVentasHoy.IsTab = false;
            this.btnVentasHoy.Location = new System.Drawing.Point(86, 512);
            this.btnVentasHoy.Name = "btnVentasHoy";
            this.btnVentasHoy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(81)))), ((int)(((byte)(170)))));
            this.btnVentasHoy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnVentasHoy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVentasHoy.selected = false;
            this.btnVentasHoy.Size = new System.Drawing.Size(134, 37);
            this.btnVentasHoy.TabIndex = 15;
            this.btnVentasHoy.Text = "Ventas de hoy";
            this.btnVentasHoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentasHoy.Textcolor = System.Drawing.Color.White;
            this.btnVentasHoy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasHoy.Visible = false;
            this.btnVentasHoy.Click += new System.EventHandler(this.btnVentasHoy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 720);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox btnMaxi;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox BtnRes;
        private Bunifu.Framework.UI.BunifuFlatButton imgProducto;
        private Bunifu.Framework.UI.BunifuFlatButton imgReporte;
        private Bunifu.Framework.UI.BunifuFlatButton imgVenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentasHoy;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnReporteInvent;
        private Bunifu.Framework.UI.BunifuFlatButton imgOrdenes;
        private Bunifu.Framework.UI.BunifuFlatButton btnReporteProductos;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}

