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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategoriaProduct = new System.Windows.Forms.Label();
            this.txtCostoProduct = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtPrecioProduct = new System.Windows.Forms.TextBox();
            this.txtDescripProduct = new System.Windows.Forms.TextBox();
            this.txtNombreProduct = new System.Windows.Forms.TextBox();
            this.lblPrecioProduct = new System.Windows.Forms.Label();
            this.lblDescripProduc = new System.Windows.Forms.Label();
            this.lblNombreProduc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarNewPRodc = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.grpboxDetalleProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnGuardarProduc.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProduc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarProduc.Location = new System.Drawing.Point(322, 333);
            this.btnGuardarProduc.Name = "btnGuardarProduc";
            this.btnGuardarProduc.Size = new System.Drawing.Size(132, 42);
            this.btnGuardarProduc.TabIndex = 8;
            this.btnGuardarProduc.Text = "Guardar";
            this.btnGuardarProduc.UseVisualStyleBackColor = false;
            // 
            // grpboxDetalleProduct
            // 
            this.grpboxDetalleProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxDetalleProduct.Controls.Add(this.comboBox1);
            this.grpboxDetalleProduct.Controls.Add(this.lblCategoriaProduct);
            this.grpboxDetalleProduct.Controls.Add(this.txtCostoProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblCosto);
            this.grpboxDetalleProduct.Controls.Add(this.txtPrecioProduct);
            this.grpboxDetalleProduct.Controls.Add(this.txtDescripProduct);
            this.grpboxDetalleProduct.Controls.Add(this.txtNombreProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblPrecioProduct);
            this.grpboxDetalleProduct.Controls.Add(this.lblDescripProduc);
            this.grpboxDetalleProduct.Controls.Add(this.lblNombreProduc);
            this.grpboxDetalleProduct.Location = new System.Drawing.Point(24, 76);
            this.grpboxDetalleProduct.Name = "grpboxDetalleProduct";
            this.grpboxDetalleProduct.Size = new System.Drawing.Size(430, 251);
            this.grpboxDetalleProduct.TabIndex = 6;
            this.grpboxDetalleProduct.TabStop = false;
            this.grpboxDetalleProduct.Text = "Detalle";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Producto",
            "Materia Prima"});
            this.comboBox1.Location = new System.Drawing.Point(122, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // lblCategoriaProduct
            // 
            this.lblCategoriaProduct.AutoSize = true;
            this.lblCategoriaProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblCategoriaProduct.Location = new System.Drawing.Point(48, 201);
            this.lblCategoriaProduct.Name = "lblCategoriaProduct";
            this.lblCategoriaProduct.Size = new System.Drawing.Size(68, 19);
            this.lblCategoriaProduct.TabIndex = 11;
            this.lblCategoriaProduct.Text = "Categoria";
            // 
            // txtCostoProduct
            // 
            this.txtCostoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoProduct.Location = new System.Drawing.Point(122, 168);
            this.txtCostoProduct.Name = "txtCostoProduct";
            this.txtCostoProduct.Size = new System.Drawing.Size(264, 26);
            this.txtCostoProduct.TabIndex = 10;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblCosto.Location = new System.Drawing.Point(71, 168);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(45, 19);
            this.lblCosto.TabIndex = 9;
            this.lblCosto.Text = "Costo";
            // 
            // txtPrecioProduct
            // 
            this.txtPrecioProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProduct.Location = new System.Drawing.Point(122, 136);
            this.txtPrecioProduct.Name = "txtPrecioProduct";
            this.txtPrecioProduct.Size = new System.Drawing.Size(264, 26);
            this.txtPrecioProduct.TabIndex = 8;
            // 
            // txtDescripProduct
            // 
            this.txtDescripProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripProduct.Location = new System.Drawing.Point(122, 68);
            this.txtDescripProduct.Multiline = true;
            this.txtDescripProduct.Name = "txtDescripProduct";
            this.txtDescripProduct.Size = new System.Drawing.Size(264, 62);
            this.txtDescripProduct.TabIndex = 7;
            // 
            // txtNombreProduct
            // 
            this.txtNombreProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProduct.Location = new System.Drawing.Point(122, 36);
            this.txtNombreProduct.Name = "txtNombreProduct";
            this.txtNombreProduct.Size = new System.Drawing.Size(264, 26);
            this.txtNombreProduct.TabIndex = 6;
            // 
            // lblPrecioProduct
            // 
            this.lblPrecioProduct.AutoSize = true;
            this.lblPrecioProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblPrecioProduct.Location = new System.Drawing.Point(69, 136);
            this.lblPrecioProduct.Name = "lblPrecioProduct";
            this.lblPrecioProduct.Size = new System.Drawing.Size(47, 19);
            this.lblPrecioProduct.TabIndex = 5;
            this.lblPrecioProduct.Text = "Precio";
            // 
            // lblDescripProduc
            // 
            this.lblDescripProduc.AutoSize = true;
            this.lblDescripProduc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lblDescripProduc.Location = new System.Drawing.Point(65, 68);
            this.lblDescripProduc.Name = "lblDescripProduc";
            this.lblDescripProduc.Size = new System.Drawing.Size(51, 19);
            this.lblDescripProduc.TabIndex = 4;
            this.lblDescripProduc.Text = "Detalle";
            // 
            // lblNombreProduc
            // 
            this.lblNombreProduc.AutoSize = true;
            this.lblNombreProduc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProduc.Location = new System.Drawing.Point(60, 36);
            this.lblNombreProduc.Name = "lblNombreProduc";
            this.lblNombreProduc.Size = new System.Drawing.Size(60, 19);
            this.lblNombreProduc.TabIndex = 3;
            this.lblNombreProduc.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Proyecto_01.Properties.Resources.playera_negra;
            this.pictureBox1.Location = new System.Drawing.Point(478, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarNewPRodc
            // 
            this.btnCancelarNewPRodc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarNewPRodc.BackColor = System.Drawing.Color.Gray;
            this.btnCancelarNewPRodc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNewPRodc.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNewPRodc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarNewPRodc.Location = new System.Drawing.Point(184, 333);
            this.btnCancelarNewPRodc.Name = "btnCancelarNewPRodc";
            this.btnCancelarNewPRodc.Size = new System.Drawing.Size(132, 42);
            this.btnCancelarNewPRodc.TabIndex = 20;
            this.btnCancelarNewPRodc.Text = "Cancelar";
            this.btnCancelarNewPRodc.UseVisualStyleBackColor = false;
            this.btnCancelarNewPRodc.Click += new System.EventHandler(this.btnCancelarNewPRodc_Click);
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarNewPRodc);
            this.Controls.Add(this.btnGuardarProduc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpboxDetalleProduct);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProducto";
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.grpboxDetalleProduct.ResumeLayout(false);
            this.grpboxDetalleProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnGuardarProduc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpboxDetalleProduct;
        private System.Windows.Forms.TextBox txtPrecioProduct;
        private System.Windows.Forms.TextBox txtDescripProduct;
        private System.Windows.Forms.TextBox txtNombreProduct;
        private System.Windows.Forms.Label lblPrecioProduct;
        private System.Windows.Forms.Label lblDescripProduc;
        private System.Windows.Forms.Label lblNombreProduc;
        private System.Windows.Forms.TextBox txtCostoProduct;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategoriaProduct;
        private System.Windows.Forms.Button btnCancelarNewPRodc;
    }
}