namespace Proyecto_01
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new Bunifu.Framework.UI.BunifuTextbox();
            this.GridVEntasProduct = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.grpboxUltiVenta = new System.Windows.Forms.GroupBox();
            this.lblPrecioProduct = new System.Windows.Forms.Label();
            this.lblNombreProduc = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.imgUltiVenta = new System.Windows.Forms.PictureBox();
            this.grpboxMasVendido = new System.Windows.Forms.GroupBox();
            this.lblPrecioProdMas = new System.Windows.Forms.Label();
            this.lblNomProduc = new System.Windows.Forms.Label();
            this.btnVenderMas = new System.Windows.Forms.Button();
            this.lblPrecioMas = new System.Windows.Forms.Label();
            this.lblNombreMas = new System.Windows.Forms.Label();
            this.imgMasVendido = new System.Windows.Forms.PictureBox();
            this.lblProduct = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarventas = new System.Windows.Forms.TextBox();
            this.labelaux = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVEntasProduct)).BeginInit();
            this.grpboxUltiVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUltiVenta)).BeginInit();
            this.grpboxMasVendido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasVendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.labelaux);
            this.groupBox3.Controls.Add(this.txtBuscarventas);
            this.groupBox3.Controls.Add(this.btnBuscarVenta);
            this.groupBox3.Controls.Add(this.txtBuscarProducto);
            this.groupBox3.Controls.Add(this.GridVEntasProduct);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(398, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 628);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarVenta.Location = new System.Drawing.Point(334, 54);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(68, 33);
            this.btnBuscarVenta.TabIndex = 29;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarProducto.BackgroundImage")));
            this.txtBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBuscarProducto.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarProducto.Icon")));
            this.txtBuscarProducto.Location = new System.Drawing.Point(78, 54);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(250, 33);
            this.txtBuscarProducto.TabIndex = 28;
            this.txtBuscarProducto.text = "";
            this.txtBuscarProducto.OnTextChange += new System.EventHandler(this.txtBuscarProducto_OnTextChange);
            // 
            // GridVEntasProduct
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridVEntasProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridVEntasProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVEntasProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridVEntasProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVEntasProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVEntasProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVEntasProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridVEntasProduct.DoubleBuffered = true;
            this.GridVEntasProduct.EnableHeadersVisualStyles = false;
            this.GridVEntasProduct.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.GridVEntasProduct.HeaderForeColor = System.Drawing.Color.White;
            this.GridVEntasProduct.Location = new System.Drawing.Point(19, 93);
            this.GridVEntasProduct.Name = "GridVEntasProduct";
            this.GridVEntasProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridVEntasProduct.RowHeadersWidth = 20;
            this.GridVEntasProduct.Size = new System.Drawing.Size(678, 522);
            this.GridVEntasProduct.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(546, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpboxUltiVenta
            // 
            this.grpboxUltiVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxUltiVenta.AutoSize = true;
            this.grpboxUltiVenta.Controls.Add(this.lblPrecioProduct);
            this.grpboxUltiVenta.Controls.Add(this.lblNombreProduc);
            this.grpboxUltiVenta.Controls.Add(this.btnVender);
            this.grpboxUltiVenta.Controls.Add(this.lblPrecio);
            this.grpboxUltiVenta.Controls.Add(this.lblNombre);
            this.grpboxUltiVenta.Controls.Add(this.imgUltiVenta);
            this.grpboxUltiVenta.Location = new System.Drawing.Point(87, 48);
            this.grpboxUltiVenta.Name = "grpboxUltiVenta";
            this.grpboxUltiVenta.Size = new System.Drawing.Size(256, 304);
            this.grpboxUltiVenta.TabIndex = 2;
            this.grpboxUltiVenta.TabStop = false;
            this.grpboxUltiVenta.Text = "Ultima Venta";
            // 
            // lblPrecioProduct
            // 
            this.lblPrecioProduct.AutoSize = true;
            this.lblPrecioProduct.Location = new System.Drawing.Point(124, 197);
            this.lblPrecioProduct.Name = "lblPrecioProduct";
            this.lblPrecioProduct.Size = new System.Drawing.Size(19, 13);
            this.lblPrecioProduct.TabIndex = 5;
            this.lblPrecioProduct.Text = "$$";
            // 
            // lblNombreProduc
            // 
            this.lblNombreProduc.AutoSize = true;
            this.lblNombreProduc.Location = new System.Drawing.Point(121, 162);
            this.lblNombreProduc.Name = "lblNombreProduc";
            this.lblNombreProduc.Size = new System.Drawing.Size(129, 13);
            this.lblNombreProduc.TabIndex = 4;
            this.lblNombreProduc.Text = "Nombre del producto aqui";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Gray;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVender.Location = new System.Drawing.Point(68, 243);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(132, 42);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(29, 193);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 157);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Producto:";
            // 
            // imgUltiVenta
            // 
            this.imgUltiVenta.Image = global::Proyecto_01.Properties.Resources.playera_negra;
            this.imgUltiVenta.Location = new System.Drawing.Point(67, 19);
            this.imgUltiVenta.Name = "imgUltiVenta";
            this.imgUltiVenta.Size = new System.Drawing.Size(124, 116);
            this.imgUltiVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUltiVenta.TabIndex = 0;
            this.imgUltiVenta.TabStop = false;
            // 
            // grpboxMasVendido
            // 
            this.grpboxMasVendido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxMasVendido.AutoSize = true;
            this.grpboxMasVendido.Controls.Add(this.lblPrecioProdMas);
            this.grpboxMasVendido.Controls.Add(this.lblNomProduc);
            this.grpboxMasVendido.Controls.Add(this.btnVenderMas);
            this.grpboxMasVendido.Controls.Add(this.lblPrecioMas);
            this.grpboxMasVendido.Controls.Add(this.lblNombreMas);
            this.grpboxMasVendido.Controls.Add(this.imgMasVendido);
            this.grpboxMasVendido.Location = new System.Drawing.Point(87, 372);
            this.grpboxMasVendido.Name = "grpboxMasVendido";
            this.grpboxMasVendido.Size = new System.Drawing.Size(256, 291);
            this.grpboxMasVendido.TabIndex = 7;
            this.grpboxMasVendido.TabStop = false;
            this.grpboxMasVendido.Text = "Mas Vendido";
            // 
            // lblPrecioProdMas
            // 
            this.lblPrecioProdMas.AutoSize = true;
            this.lblPrecioProdMas.Location = new System.Drawing.Point(124, 190);
            this.lblPrecioProdMas.Name = "lblPrecioProdMas";
            this.lblPrecioProdMas.Size = new System.Drawing.Size(19, 13);
            this.lblPrecioProdMas.TabIndex = 5;
            this.lblPrecioProdMas.Text = "$$";
            // 
            // lblNomProduc
            // 
            this.lblNomProduc.AutoSize = true;
            this.lblNomProduc.Location = new System.Drawing.Point(121, 155);
            this.lblNomProduc.Name = "lblNomProduc";
            this.lblNomProduc.Size = new System.Drawing.Size(129, 13);
            this.lblNomProduc.TabIndex = 4;
            this.lblNomProduc.Text = "Nombre del producto aqui";
            // 
            // btnVenderMas
            // 
            this.btnVenderMas.BackColor = System.Drawing.Color.Gray;
            this.btnVenderMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVenderMas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVenderMas.Location = new System.Drawing.Point(68, 230);
            this.btnVenderMas.Name = "btnVenderMas";
            this.btnVenderMas.Size = new System.Drawing.Size(132, 42);
            this.btnVenderMas.TabIndex = 3;
            this.btnVenderMas.Text = "Vender";
            this.btnVenderMas.UseVisualStyleBackColor = false;
            // 
            // lblPrecioMas
            // 
            this.lblPrecioMas.AutoSize = true;
            this.lblPrecioMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMas.Location = new System.Drawing.Point(29, 186);
            this.lblPrecioMas.Name = "lblPrecioMas";
            this.lblPrecioMas.Size = new System.Drawing.Size(62, 18);
            this.lblPrecioMas.TabIndex = 2;
            this.lblPrecioMas.Text = "Precio:";
            // 
            // lblNombreMas
            // 
            this.lblNombreMas.AutoSize = true;
            this.lblNombreMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMas.Location = new System.Drawing.Point(29, 150);
            this.lblNombreMas.Name = "lblNombreMas";
            this.lblNombreMas.Size = new System.Drawing.Size(82, 18);
            this.lblNombreMas.TabIndex = 1;
            this.lblNombreMas.Text = "Producto:";
            // 
            // imgMasVendido
            // 
            this.imgMasVendido.Image = global::Proyecto_01.Properties.Resources.Tasa;
            this.imgMasVendido.Location = new System.Drawing.Point(67, 19);
            this.imgMasVendido.Name = "imgMasVendido";
            this.imgMasVendido.Size = new System.Drawing.Size(124, 116);
            this.imgMasVendido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMasVendido.TabIndex = 0;
            this.imgMasVendido.TabStop = false;
            // 
            // lblProduct
            // 
            this.lblProduct.Appearance.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblProduct.Appearance.Options.UseFont = true;
            this.lblProduct.Location = new System.Drawing.Point(497, 12);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(69, 25);
            this.lblProduct.TabIndex = 10;
            this.lblProduct.Text = "Venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Proyecto_01.Properties.Resources.No_iniciada;
            this.pictureBox1.Location = new System.Drawing.Point(770, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBuscarventas
            // 
            this.txtBuscarventas.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarventas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscarventas.Location = new System.Drawing.Point(119, 60);
            this.txtBuscarventas.Name = "txtBuscarventas";
            this.txtBuscarventas.Size = new System.Drawing.Size(200, 17);
            this.txtBuscarventas.TabIndex = 37;
            this.txtBuscarventas.Text = "Buscar \"Nombre\"";
            this.txtBuscarventas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarTareass_MouseClick);
            this.txtBuscarventas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarventas_KeyPress);
            // 
            // labelaux
            // 
            this.labelaux.AutoSize = true;
            this.labelaux.Location = new System.Drawing.Point(16, 43);
            this.labelaux.Name = "labelaux";
            this.labelaux.Size = new System.Drawing.Size(35, 13);
            this.labelaux.TabIndex = 38;
            this.labelaux.Text = "label1";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.grpboxMasVendido);
            this.Controls.Add(this.grpboxUltiVenta);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVEntasProduct)).EndInit();
            this.grpboxUltiVenta.ResumeLayout(false);
            this.grpboxUltiVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUltiVenta)).EndInit();
            this.grpboxMasVendido.ResumeLayout(false);
            this.grpboxMasVendido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasVendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpboxUltiVenta;
        private System.Windows.Forms.Label lblPrecioProduct;
        private System.Windows.Forms.Label lblNombreProduc;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox imgUltiVenta;
        private System.Windows.Forms.GroupBox grpboxMasVendido;
        private System.Windows.Forms.Label lblPrecioProdMas;
        private System.Windows.Forms.Label lblNomProduc;
        private System.Windows.Forms.Button btnVenderMas;
        private System.Windows.Forms.Label lblPrecioMas;
        private System.Windows.Forms.Label lblNombreMas;
        private System.Windows.Forms.PictureBox imgMasVendido;
        private DevExpress.XtraEditors.LabelControl lblProduct;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridVEntasProduct;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarventas;
        private System.Windows.Forms.Label labelaux;
    }
}