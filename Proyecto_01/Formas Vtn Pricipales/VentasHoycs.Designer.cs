namespace Proyecto_01.Formas_Vtn_sec
{
    partial class VentasHoycs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VtnVEntasTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VtnVentaVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VtnVentasPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VtnHoyNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla_VentasHoy = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColmFechaReportHoy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanVEntasHoy = new DevExpress.XtraEditors.PanelControl();
            this.btnImprimirHoy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_VentasHoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanVEntasHoy)).BeginInit();
            this.PanVEntasHoy.SuspendLayout();
            this.SuspendLayout();
            // 
            // VtnVEntasTotal
            // 
            this.VtnVEntasTotal.HeaderText = "Total";
            this.VtnVEntasTotal.Name = "VtnVEntasTotal";
            // 
            // VtnVentaVentas
            // 
            this.VtnVentaVentas.HeaderText = "Ventas";
            this.VtnVentaVentas.Name = "VtnVentaVentas";
            // 
            // VtnVentasPrecio
            // 
            this.VtnVentasPrecio.HeaderText = "Precio";
            this.VtnVentasPrecio.Name = "VtnVentasPrecio";
            // 
            // VtnHoyNombre
            // 
            this.VtnHoyNombre.HeaderText = "Nombre";
            this.VtnHoyNombre.Name = "VtnHoyNombre";
            // 
            // Tabla_VentasHoy
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tabla_VentasHoy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Tabla_VentasHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tabla_VentasHoy.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Tabla_VentasHoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_VentasHoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_VentasHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabla_VentasHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_VentasHoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VtnHoyNombre,
            this.VtnVentasPrecio,
            this.VtnVentaVentas,
            this.VtnVEntasTotal,
            this.ColmFechaReportHoy});
            this.Tabla_VentasHoy.DoubleBuffered = true;
            this.Tabla_VentasHoy.EnableHeadersVisualStyles = false;
            this.Tabla_VentasHoy.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.Tabla_VentasHoy.HeaderForeColor = System.Drawing.Color.White;
            this.Tabla_VentasHoy.Location = new System.Drawing.Point(51, 29);
            this.Tabla_VentasHoy.Name = "Tabla_VentasHoy";
            this.Tabla_VentasHoy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_VentasHoy.Size = new System.Drawing.Size(957, 547);
            this.Tabla_VentasHoy.TabIndex = 0;
            this.Tabla_VentasHoy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_VentasHoy_CellContentClick);
            // 
            // ColmFechaReportHoy
            // 
            this.ColmFechaReportHoy.HeaderText = "Fecha";
            this.ColmFechaReportHoy.Name = "ColmFechaReportHoy";
            // 
            // PanVEntasHoy
            // 
            this.PanVEntasHoy.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.PanVEntasHoy.Appearance.Options.UseBackColor = true;
            this.PanVEntasHoy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanVEntasHoy.Controls.Add(this.btnImprimirHoy);
            this.PanVEntasHoy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanVEntasHoy.Location = new System.Drawing.Point(0, 610);
            this.PanVEntasHoy.Name = "PanVEntasHoy";
            this.PanVEntasHoy.Size = new System.Drawing.Size(1093, 73);
            this.PanVEntasHoy.TabIndex = 23;
            // 
            // btnImprimirHoy
            // 
            this.btnImprimirHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimirHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnImprimirHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirHoy.Font = new System.Drawing.Font("Quicksand Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirHoy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimirHoy.Location = new System.Drawing.Point(482, 19);
            this.btnImprimirHoy.Name = "btnImprimirHoy";
            this.btnImprimirHoy.Size = new System.Drawing.Size(132, 42);
            this.btnImprimirHoy.TabIndex = 9;
            this.btnImprimirHoy.Text = "Imprimir";
            this.btnImprimirHoy.UseVisualStyleBackColor = false;
            // 
            // VentasHoycs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 683);
            this.Controls.Add(this.PanVEntasHoy);
            this.Controls.Add(this.Tabla_VentasHoy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentasHoycs";
            this.Text = "VentasHoycs";
            this.Load += new System.EventHandler(this.VentasHoycs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_VentasHoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanVEntasHoy)).EndInit();
            this.PanVEntasHoy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn VtnVEntasTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn VtnVentaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn VtnVentasPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn VtnHoyNombre;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Tabla_VentasHoy;
        private DevExpress.XtraEditors.PanelControl PanVEntasHoy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColmFechaReportHoy;
        private System.Windows.Forms.Button btnImprimirHoy;
    }
}