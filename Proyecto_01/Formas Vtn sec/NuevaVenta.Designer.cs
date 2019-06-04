namespace Proyecto_01.Formas_Vtn_sec
{
    partial class NuevaVenta
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
            this.grpboxUltiVenta = new System.Windows.Forms.GroupBox();
            this.txtCAntidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCategoriaVantPro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioVentProduct = new System.Windows.Forms.Label();
            this.lblNombreVentaProduc = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVenderVenta = new System.Windows.Forms.Button();
            this.imgUltiVenta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProduc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalTodo = new System.Windows.Forms.Label();
            this.btnCancelVenta = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.grpboxUltiVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUltiVenta)).BeginInit();
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
            this.TitleBar.Size = new System.Drawing.Size(843, 31);
            this.TitleBar.TabIndex = 17;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = global::Proyecto_01.Properties.Resources.minimazar;
            this.BtnMin.Location = new System.Drawing.Point(784, 3);
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
            this.btnCerrar.Location = new System.Drawing.Point(815, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // grpboxUltiVenta
            // 
            this.grpboxUltiVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxUltiVenta.AutoSize = true;
            this.grpboxUltiVenta.Controls.Add(this.txtCAntidad);
            this.grpboxUltiVenta.Controls.Add(this.label9);
            this.grpboxUltiVenta.Controls.Add(this.labelID);
            this.grpboxUltiVenta.Controls.Add(this.label3);
            this.grpboxUltiVenta.Controls.Add(this.lblCategoriaVantPro);
            this.grpboxUltiVenta.Controls.Add(this.label2);
            this.grpboxUltiVenta.Controls.Add(this.lblPrecioVentProduct);
            this.grpboxUltiVenta.Controls.Add(this.lblNombreVentaProduc);
            this.grpboxUltiVenta.Controls.Add(this.lblPrecioUnitario);
            this.grpboxUltiVenta.Controls.Add(this.lblNombre);
            this.grpboxUltiVenta.Location = new System.Drawing.Point(91, 68);
            this.grpboxUltiVenta.Name = "grpboxUltiVenta";
            this.grpboxUltiVenta.Size = new System.Drawing.Size(473, 195);
            this.grpboxUltiVenta.TabIndex = 18;
            this.grpboxUltiVenta.TabStop = false;
            this.grpboxUltiVenta.Text = "Venta";
            // 
            // txtCAntidad
            // 
            this.txtCAntidad.Location = new System.Drawing.Point(120, 110);
            this.txtCAntidad.Name = "txtCAntidad";
            this.txtCAntidad.Size = new System.Drawing.Size(100, 20);
            this.txtCAntidad.TabIndex = 28;
            this.txtCAntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCAntidad_KeyPress);
            this.txtCAntidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Id";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Stencil", 15.75F);
            this.labelID.Location = new System.Drawing.Point(373, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(34, 25);
            this.labelID.TabIndex = 26;
            this.labelID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad:";
            // 
            // lblCategoriaVantPro
            // 
            this.lblCategoriaVantPro.AutoSize = true;
            this.lblCategoriaVantPro.Location = new System.Drawing.Point(124, 157);
            this.lblCategoriaVantPro.Name = "lblCategoriaVantPro";
            this.lblCategoriaVantPro.Size = new System.Drawing.Size(23, 13);
            this.lblCategoriaVantPro.TabIndex = 7;
            this.lblCategoriaVantPro.Text = "Cat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Categoria:";
            // 
            // lblPrecioVentProduct
            // 
            this.lblPrecioVentProduct.AutoSize = true;
            this.lblPrecioVentProduct.Location = new System.Drawing.Point(124, 74);
            this.lblPrecioVentProduct.Name = "lblPrecioVentProduct";
            this.lblPrecioVentProduct.Size = new System.Drawing.Size(19, 13);
            this.lblPrecioVentProduct.TabIndex = 5;
            this.lblPrecioVentProduct.Text = "$$";
            // 
            // lblNombreVentaProduc
            // 
            this.lblNombreVentaProduc.AutoSize = true;
            this.lblNombreVentaProduc.Location = new System.Drawing.Point(124, 32);
            this.lblNombreVentaProduc.Name = "lblNombreVentaProduc";
            this.lblNombreVentaProduc.Size = new System.Drawing.Size(129, 13);
            this.lblNombreVentaProduc.TabIndex = 4;
            this.lblNombreVentaProduc.Text = "Nombre del producto aqui";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(49, 69);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(62, 18);
            this.lblPrecioUnitario.TabIndex = 2;
            this.lblPrecioUnitario.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Producto:";
            // 
            // btnVenderVenta
            // 
            this.btnVenderVenta.BackColor = System.Drawing.Color.Gray;
            this.btnVenderVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVenderVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVenderVenta.Location = new System.Drawing.Point(246, 444);
            this.btnVenderVenta.Name = "btnVenderVenta";
            this.btnVenderVenta.Size = new System.Drawing.Size(132, 42);
            this.btnVenderVenta.TabIndex = 3;
            this.btnVenderVenta.Text = "Vender";
            this.btnVenderVenta.UseVisualStyleBackColor = false;
            this.btnVenderVenta.Click += new System.EventHandler(this.btnVenderVenta_Click);
            // 
            // imgUltiVenta
            // 
            this.imgUltiVenta.Image = global::Proyecto_01.Properties.Resources.playera_negra;
            this.imgUltiVenta.Location = new System.Drawing.Point(570, 68);
            this.imgUltiVenta.Name = "imgUltiVenta";
            this.imgUltiVenta.Size = new System.Drawing.Size(239, 238);
            this.imgUltiVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUltiVenta.TabIndex = 0;
            this.imgUltiVenta.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Necesito poder registrar varios productos para una misma venta";
            // 
            // btnAgregarProduc
            // 
            this.btnAgregarProduc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnAgregarProduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProduc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProduc.Location = new System.Drawing.Point(384, 444);
            this.btnAgregarProduc.Name = "btnAgregarProduc";
            this.btnAgregarProduc.Size = new System.Drawing.Size(132, 42);
            this.btnAgregarProduc.TabIndex = 20;
            this.btnAgregarProduc.Text = "Agregar mas";
            this.btnAgregarProduc.UseVisualStyleBackColor = false;
            this.btnAgregarProduc.Click += new System.EventHandler(this.btnAgregarProduc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // lblTotalTodo
            // 
            this.lblTotalTodo.AutoSize = true;
            this.lblTotalTodo.Location = new System.Drawing.Point(513, 320);
            this.lblTotalTodo.Name = "lblTotalTodo";
            this.lblTotalTodo.Size = new System.Drawing.Size(23, 13);
            this.lblTotalTodo.TabIndex = 11;
            this.lblTotalTodo.Text = "Cat";
            // 
            // btnCancelVenta
            // 
            this.btnCancelVenta.BackColor = System.Drawing.Color.Gray;
            this.btnCancelVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelVenta.Location = new System.Drawing.Point(522, 444);
            this.btnCancelVenta.Name = "btnCancelVenta";
            this.btnCancelVenta.Size = new System.Drawing.Size(132, 42);
            this.btnCancelVenta.TabIndex = 21;
            this.btnCancelVenta.Text = "Cancelar";
            this.btnCancelVenta.UseVisualStyleBackColor = false;
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 498);
            this.Controls.Add(this.btnCancelVenta);
            this.Controls.Add(this.lblTotalTodo);
            this.Controls.Add(this.btnAgregarProduc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpboxUltiVenta);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.btnVenderVenta);
            this.Controls.Add(this.imgUltiVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NuevaVenta";
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.grpboxUltiVenta.ResumeLayout(false);
            this.grpboxUltiVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUltiVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox grpboxUltiVenta;
        private System.Windows.Forms.Label lblPrecioVentProduct;
        private System.Windows.Forms.Label lblNombreVentaProduc;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVenderVenta;
        private System.Windows.Forms.PictureBox imgUltiVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoriaVantPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarProduc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalTodo;
        private System.Windows.Forms.Button btnCancelVenta;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtCAntidad;
    }
}