namespace Proyecto_01
{
    partial class NuevoProducto
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnGuardarProduc = new System.Windows.Forms.Button();
            this.grpboxDetalleProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbEstatus = new System.Windows.Forms.ComboBox();
            this.lblestatus = new System.Windows.Forms.Label();
            this.txtStockProduct = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoriaProduct = new System.Windows.Forms.Label();
            this.txtCostoProduct = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtPrecioProduct = new System.Windows.Forms.TextBox();
            this.txtDescripProduct = new System.Windows.Forms.TextBox();
            this.txtNombreProduct = new System.Windows.Forms.TextBox();
            this.lblPrecioProduct = new System.Windows.Forms.Label();
            this.lblDescripProduc = new System.Windows.Forms.Label();
            this.lblNombreProduc = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelarNewPRodc = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.optnProducto = new System.Windows.Forms.RadioButton();
            this.optnMateria = new System.Windows.Forms.RadioButton();
            this.lblImagen = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.grpboxDetalleProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.TitleBar.Controls.Add(this.BtnMin);
            this.TitleBar.Controls.Add(this.btnCerrar);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(800, 31);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = global::Proyecto_01.Properties.Resources.minimazar;
            this.BtnMin.Location = new System.Drawing.Point(741, 3);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(25, 25);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMin.TabIndex = 1;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Proyecto_01.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(772, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardarProduc
            // 
            this.btnGuardarProduc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarProduc.BackColor = System.Drawing.Color.Gray;
            this.btnGuardarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProduc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarProduc.Location = new System.Drawing.Point(344, 359);
            this.btnGuardarProduc.Name = "btnGuardarProduc";
            this.btnGuardarProduc.Size = new System.Drawing.Size(132, 42);
            this.btnGuardarProduc.TabIndex = 8;
            this.btnGuardarProduc.Text = "Guardar";
            this.btnGuardarProduc.UseVisualStyleBackColor = false;
            this.btnGuardarProduc.Click += new System.EventHandler(this.BtnGuardarProduc_Click);
            // 
            // grpboxDetalleProduct
            // 
            this.grpboxDetalleProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxDetalleProduct.Controls.Add(this.label1);
            this.grpboxDetalleProduct.Controls.Add(this.txtMarca);
            this.grpboxDetalleProduct.Controls.Add(this.cmbEstatus);
            this.grpboxDetalleProduct.Controls.Add(this.lblestatus);
            this.grpboxDetalleProduct.Controls.Add(this.txtStockProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblStock);
            this.grpboxDetalleProduct.Controls.Add(this.cmbCategoria);
            this.grpboxDetalleProduct.Controls.Add(this.lblCategoriaProduct);
            this.grpboxDetalleProduct.Controls.Add(this.txtCostoProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblCosto);
            this.grpboxDetalleProduct.Controls.Add(this.txtPrecioProduct);
            this.grpboxDetalleProduct.Controls.Add(this.txtDescripProduct);
            this.grpboxDetalleProduct.Controls.Add(this.txtNombreProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblPrecioProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblDescripProduc);
            this.grpboxDetalleProduct.Controls.Add(this.lblNombreProduc);
            this.grpboxDetalleProduct.Location = new System.Drawing.Point(24, 37);
            this.grpboxDetalleProduct.Name = "grpboxDetalleProduct";
            this.grpboxDetalleProduct.Size = new System.Drawing.Size(430, 316);
            this.grpboxDetalleProduct.TabIndex = 6;
            this.grpboxDetalleProduct.TabStop = false;
            this.grpboxDetalleProduct.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(122, 51);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(264, 26);
            this.txtMarca.TabIndex = 20;
            // 
            // cmbEstatus
            // 
            this.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstatus.FormattingEnabled = true;
            this.cmbEstatus.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cmbEstatus.Location = new System.Drawing.Point(121, 250);
            this.cmbEstatus.Name = "cmbEstatus";
            this.cmbEstatus.Size = new System.Drawing.Size(264, 21);
            this.cmbEstatus.TabIndex = 19;
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblestatus.Location = new System.Drawing.Point(62, 249);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(53, 19);
            this.lblestatus.TabIndex = 18;
            this.lblestatus.Text = "Estatus";
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockProduct.Location = new System.Drawing.Point(121, 215);
            this.txtStockProduct.MaxLength = 8;
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.Size = new System.Drawing.Size(264, 26);
            this.txtStockProduct.TabIndex = 17;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblStock.Location = new System.Drawing.Point(71, 215);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 19);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Stock";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Papeleria",
            "Recipientes",
            "Ropa",
            "Otros"});
            this.cmbCategoria.Location = new System.Drawing.Point(121, 284);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(264, 21);
            this.cmbCategoria.TabIndex = 15;
            // 
            // lblCategoriaProduct
            // 
            this.lblCategoriaProduct.AutoSize = true;
            this.lblCategoriaProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblCategoriaProduct.Location = new System.Drawing.Point(48, 283);
            this.lblCategoriaProduct.Name = "lblCategoriaProduct";
            this.lblCategoriaProduct.Size = new System.Drawing.Size(68, 19);
            this.lblCategoriaProduct.TabIndex = 11;
            this.lblCategoriaProduct.Text = "Categoria";
            // 
            // txtCostoProduct
            // 
            this.txtCostoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoProduct.Location = new System.Drawing.Point(122, 183);
            this.txtCostoProduct.MaxLength = 10;
            this.txtCostoProduct.Name = "txtCostoProduct";
            this.txtCostoProduct.Size = new System.Drawing.Size(264, 26);
            this.txtCostoProduct.TabIndex = 10;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblCosto.Location = new System.Drawing.Point(71, 183);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(45, 19);
            this.lblCosto.TabIndex = 9;
            this.lblCosto.Text = "Costo";
            // 
            // txtPrecioProduct
            // 
            this.txtPrecioProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProduct.Location = new System.Drawing.Point(122, 151);
            this.txtPrecioProduct.MaxLength = 10;
            this.txtPrecioProduct.Name = "txtPrecioProduct";
            this.txtPrecioProduct.Size = new System.Drawing.Size(264, 26);
            this.txtPrecioProduct.TabIndex = 8;
            // 
            // txtDescripProduct
            // 
            this.txtDescripProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripProduct.Location = new System.Drawing.Point(122, 83);
            this.txtDescripProduct.MaxLength = 100;
            this.txtDescripProduct.Multiline = true;
            this.txtDescripProduct.Name = "txtDescripProduct";
            this.txtDescripProduct.Size = new System.Drawing.Size(264, 62);
            this.txtDescripProduct.TabIndex = 7;
            // 
            // txtNombreProduct
            // 
            this.txtNombreProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProduct.Location = new System.Drawing.Point(122, 19);
            this.txtNombreProduct.MaxLength = 50;
            this.txtNombreProduct.Name = "txtNombreProduct";
            this.txtNombreProduct.Size = new System.Drawing.Size(264, 26);
            this.txtNombreProduct.TabIndex = 6;
            // 
            // lblPrecioProduct
            // 
            this.lblPrecioProduct.AutoSize = true;
            this.lblPrecioProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblPrecioProduct.Location = new System.Drawing.Point(69, 151);
            this.lblPrecioProduct.Name = "lblPrecioProduct";
            this.lblPrecioProduct.Size = new System.Drawing.Size(47, 19);
            this.lblPrecioProduct.TabIndex = 5;
            this.lblPrecioProduct.Text = "Precio";
            // 
            // lblDescripProduc
            // 
            this.lblDescripProduc.AutoSize = true;
            this.lblDescripProduc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblDescripProduc.Location = new System.Drawing.Point(65, 83);
            this.lblDescripProduc.Name = "lblDescripProduc";
            this.lblDescripProduc.Size = new System.Drawing.Size(51, 19);
            this.lblDescripProduc.TabIndex = 4;
            this.lblDescripProduc.Text = "Detalle";
            // 
            // lblNombreProduc
            // 
            this.lblNombreProduc.AutoSize = true;
            this.lblNombreProduc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProduc.Location = new System.Drawing.Point(56, 19);
            this.lblNombreProduc.Name = "lblNombreProduc";
            this.lblNombreProduc.Size = new System.Drawing.Size(60, 19);
            this.lblNombreProduc.TabIndex = 3;
            this.lblNombreProduc.Text = "Nombre";
            // 
            // picImagen
            // 
            this.picImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picImagen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picImagen.ErrorImage = null;
            this.picImagen.InitialImage = null;
            this.picImagen.Location = new System.Drawing.Point(480, 52);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(298, 299);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 7;
            this.picImagen.TabStop = false;
            // 
            // btnCancelarNewPRodc
            // 
            this.btnCancelarNewPRodc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarNewPRodc.BackColor = System.Drawing.Color.Gray;
            this.btnCancelarNewPRodc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNewPRodc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNewPRodc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarNewPRodc.Location = new System.Drawing.Point(206, 359);
            this.btnCancelarNewPRodc.Name = "btnCancelarNewPRodc";
            this.btnCancelarNewPRodc.Size = new System.Drawing.Size(132, 42);
            this.btnCancelarNewPRodc.TabIndex = 20;
            this.btnCancelarNewPRodc.Text = "Cancelar";
            this.btnCancelarNewPRodc.UseVisualStyleBackColor = false;
            this.btnCancelarNewPRodc.Click += new System.EventHandler(this.btnCancelarNewPRodc_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(565, 357);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(134, 42);
            this.btnExaminar.TabIndex = 21;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.optnProducto);
            this.panel1.Controls.Add(this.optnMateria);
            this.panel1.Location = new System.Drawing.Point(12, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 55);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "¿Que agregará?";
            // 
            // optnProducto
            // 
            this.optnProducto.AutoSize = true;
            this.optnProducto.Checked = true;
            this.optnProducto.Location = new System.Drawing.Point(87, 35);
            this.optnProducto.Name = "optnProducto";
            this.optnProducto.Size = new System.Drawing.Size(68, 17);
            this.optnProducto.TabIndex = 23;
            this.optnProducto.TabStop = true;
            this.optnProducto.Text = "Producto";
            this.optnProducto.UseVisualStyleBackColor = true;
            this.optnProducto.CheckedChanged += new System.EventHandler(this.OptnProducto_CheckedChanged);
            // 
            // optnMateria
            // 
            this.optnMateria.AutoSize = true;
            this.optnMateria.Location = new System.Drawing.Point(3, 35);
            this.optnMateria.Name = "optnMateria";
            this.optnMateria.Size = new System.Drawing.Size(60, 17);
            this.optnMateria.TabIndex = 22;
            this.optnMateria.Text = "Materia";
            this.optnMateria.UseVisualStyleBackColor = true;
            this.optnMateria.CheckedChanged += new System.EventHandler(this.OptnMateria_CheckedChanged);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblImagen.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(542, 185);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(180, 22);
            this.lblImagen.TabIndex = 23;
            this.lblImagen.Text = "Seleccione una Imagen";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnCancelarNewPRodc);
            this.Controls.Add(this.btnGuardarProduc);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.grpboxDetalleProduct);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProducto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.grpboxDetalleProduct.ResumeLayout(false);
            this.grpboxDetalleProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnGuardarProduc;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.GroupBox grpboxDetalleProduct;
        private System.Windows.Forms.TextBox txtPrecioProduct;
        private System.Windows.Forms.TextBox txtDescripProduct;
        private System.Windows.Forms.TextBox txtNombreProduct;
        private System.Windows.Forms.Label lblPrecioProduct;
        private System.Windows.Forms.Label lblDescripProduc;
        private System.Windows.Forms.Label lblNombreProduc;
        private System.Windows.Forms.TextBox txtCostoProduct;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoriaProduct;
        private System.Windows.Forms.Button btnCancelarNewPRodc;
        private System.Windows.Forms.TextBox txtStockProduct;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblestatus;
        private System.Windows.Forms.ComboBox cmbEstatus;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optnProducto;
        private System.Windows.Forms.RadioButton optnMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImagen;
    }
}