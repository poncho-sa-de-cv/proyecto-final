namespace Proyecto_01
{
    partial class Ordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimOrd = new System.Windows.Forms.Button();
            this.btnNuevoOrd = new System.Windows.Forms.Button();
            this.btnEditarOrd = new System.Windows.Forms.Button();
            this.btnFiltroTodosTar = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFiltroEnd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFiltroNoInic = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFiltroEnProces = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblProduCategorias = new System.Windows.Forms.Label();
            this.GridTareas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscarTarea = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnBuscarTareas = new System.Windows.Forms.Button();
            this.txtBuscarTareass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tareas";
            // 
            // btnElimOrd
            // 
            this.btnElimOrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElimOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnElimOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimOrd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElimOrd.Location = new System.Drawing.Point(373, 19);
            this.btnElimOrd.Name = "btnElimOrd";
            this.btnElimOrd.Size = new System.Drawing.Size(132, 42);
            this.btnElimOrd.TabIndex = 10;
            this.btnElimOrd.Text = "Eliminar";
            this.btnElimOrd.UseVisualStyleBackColor = false;
            this.btnElimOrd.Click += new System.EventHandler(this.btnElimOrd_Click);
            // 
            // btnNuevoOrd
            // 
            this.btnNuevoOrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevoOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnNuevoOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoOrd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoOrd.Location = new System.Drawing.Point(649, 19);
            this.btnNuevoOrd.Name = "btnNuevoOrd";
            this.btnNuevoOrd.Size = new System.Drawing.Size(132, 42);
            this.btnNuevoOrd.TabIndex = 9;
            this.btnNuevoOrd.Text = "Nuevo";
            this.btnNuevoOrd.UseVisualStyleBackColor = false;
            this.btnNuevoOrd.Click += new System.EventHandler(this.btnNuevoOrd_Click);
            // 
            // btnEditarOrd
            // 
            this.btnEditarOrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarOrd.BackColor = System.Drawing.Color.Gray;
            this.btnEditarOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarOrd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarOrd.Location = new System.Drawing.Point(511, 19);
            this.btnEditarOrd.Name = "btnEditarOrd";
            this.btnEditarOrd.Size = new System.Drawing.Size(132, 42);
            this.btnEditarOrd.TabIndex = 8;
            this.btnEditarOrd.Text = "Editar";
            this.btnEditarOrd.UseVisualStyleBackColor = false;
            this.btnEditarOrd.Click += new System.EventHandler(this.btnEditarOrd_Click);
            // 
            // btnFiltroTodosTar
            // 
            this.btnFiltroTodosTar.BackColor = System.Drawing.Color.Gray;
            this.btnFiltroTodosTar.color = System.Drawing.Color.Gray;
            this.btnFiltroTodosTar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnFiltroTodosTar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroTodosTar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFiltroTodosTar.ForeColor = System.Drawing.Color.White;
            this.btnFiltroTodosTar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltroTodosTar.Image")));
            this.btnFiltroTodosTar.ImagePosition = 20;
            this.btnFiltroTodosTar.ImageZoom = 20;
            this.btnFiltroTodosTar.LabelPosition = 41;
            this.btnFiltroTodosTar.LabelText = "Todas las Tareas";
            this.btnFiltroTodosTar.Location = new System.Drawing.Point(51, 88);
            this.btnFiltroTodosTar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltroTodosTar.Name = "btnFiltroTodosTar";
            this.btnFiltroTodosTar.Size = new System.Drawing.Size(196, 98);
            this.btnFiltroTodosTar.TabIndex = 21;
            this.btnFiltroTodosTar.Click += new System.EventHandler(this.btnFiltroTodosTar_Click);
            // 
            // btnFiltroEnd
            // 
            this.btnFiltroEnd.BackColor = System.Drawing.Color.Gray;
            this.btnFiltroEnd.color = System.Drawing.Color.Gray;
            this.btnFiltroEnd.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnFiltroEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroEnd.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFiltroEnd.ForeColor = System.Drawing.Color.White;
            this.btnFiltroEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltroEnd.Image")));
            this.btnFiltroEnd.ImagePosition = 20;
            this.btnFiltroEnd.ImageZoom = 20;
            this.btnFiltroEnd.LabelPosition = 41;
            this.btnFiltroEnd.LabelText = "Completadas";
            this.btnFiltroEnd.Location = new System.Drawing.Point(51, 418);
            this.btnFiltroEnd.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltroEnd.Name = "btnFiltroEnd";
            this.btnFiltroEnd.Size = new System.Drawing.Size(196, 98);
            this.btnFiltroEnd.TabIndex = 20;
            this.btnFiltroEnd.Click += new System.EventHandler(this.btnFiltroEnd_Click);
            // 
            // btnFiltroNoInic
            // 
            this.btnFiltroNoInic.BackColor = System.Drawing.Color.Gray;
            this.btnFiltroNoInic.color = System.Drawing.Color.Gray;
            this.btnFiltroNoInic.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnFiltroNoInic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroNoInic.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFiltroNoInic.ForeColor = System.Drawing.Color.White;
            this.btnFiltroNoInic.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltroNoInic.Image")));
            this.btnFiltroNoInic.ImagePosition = 20;
            this.btnFiltroNoInic.ImageZoom = 20;
            this.btnFiltroNoInic.LabelPosition = 41;
            this.btnFiltroNoInic.LabelText = "No iniciadas";
            this.btnFiltroNoInic.Location = new System.Drawing.Point(51, 308);
            this.btnFiltroNoInic.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltroNoInic.Name = "btnFiltroNoInic";
            this.btnFiltroNoInic.Size = new System.Drawing.Size(196, 98);
            this.btnFiltroNoInic.TabIndex = 19;
            this.btnFiltroNoInic.Click += new System.EventHandler(this.btnFiltroNoInic_Click);
            // 
            // btnFiltroEnProces
            // 
            this.btnFiltroEnProces.BackColor = System.Drawing.Color.Gray;
            this.btnFiltroEnProces.color = System.Drawing.Color.Gray;
            this.btnFiltroEnProces.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnFiltroEnProces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroEnProces.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFiltroEnProces.ForeColor = System.Drawing.Color.White;
            this.btnFiltroEnProces.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltroEnProces.Image")));
            this.btnFiltroEnProces.ImagePosition = 20;
            this.btnFiltroEnProces.ImageZoom = 20;
            this.btnFiltroEnProces.LabelPosition = 41;
            this.btnFiltroEnProces.LabelText = "En procesos";
            this.btnFiltroEnProces.Location = new System.Drawing.Point(51, 198);
            this.btnFiltroEnProces.Margin = new System.Windows.Forms.Padding(6);
            this.btnFiltroEnProces.Name = "btnFiltroEnProces";
            this.btnFiltroEnProces.Size = new System.Drawing.Size(196, 98);
            this.btnFiltroEnProces.TabIndex = 18;
            this.btnFiltroEnProces.Click += new System.EventHandler(this.btnFiltroEnProces_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnEditarOrd);
            this.panelControl1.Controls.Add(this.btnElimOrd);
            this.panelControl1.Controls.Add(this.btnNuevoOrd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 620);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1133, 73);
            this.panelControl1.TabIndex = 22;
            // 
            // lblProduCategorias
            // 
            this.lblProduCategorias.AutoSize = true;
            this.lblProduCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblProduCategorias.Location = new System.Drawing.Point(155, 63);
            this.lblProduCategorias.Name = "lblProduCategorias";
            this.lblProduCategorias.Size = new System.Drawing.Size(44, 20);
            this.lblProduCategorias.TabIndex = 23;
            this.lblProduCategorias.Text = "Filtro";
            // 
            // GridTareas
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTareas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTareas.DoubleBuffered = true;
            this.GridTareas.EnableHeadersVisualStyles = false;
            this.GridTareas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.GridTareas.HeaderForeColor = System.Drawing.Color.White;
            this.GridTareas.Location = new System.Drawing.Point(256, 88);
            this.GridTareas.Name = "GridTareas";
            this.GridTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridTareas.Size = new System.Drawing.Size(815, 496);
            this.GridTareas.TabIndex = 24;
            // 
            // txtBuscarTarea
            // 
            this.txtBuscarTarea.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarTarea.BackgroundImage")));
            this.txtBuscarTarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBuscarTarea.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBuscarTarea.Icon = ((System.Drawing.Image)(resources.GetObject("txtBuscarTarea.Icon")));
            this.txtBuscarTarea.Location = new System.Drawing.Point(280, 50);
            this.txtBuscarTarea.Name = "txtBuscarTarea";
            this.txtBuscarTarea.Size = new System.Drawing.Size(250, 33);
            this.txtBuscarTarea.TabIndex = 28;
            this.txtBuscarTarea.text = "";
            this.txtBuscarTarea.Click += new System.EventHandler(this.txtBuscarTarea_Click);
            this.txtBuscarTarea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarTarea_MouseClick);
            // 
            // btnBuscarTareas
            // 
            this.btnBuscarTareas.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTareas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarTareas.Location = new System.Drawing.Point(536, 49);
            this.btnBuscarTareas.Name = "btnBuscarTareas";
            this.btnBuscarTareas.Size = new System.Drawing.Size(68, 33);
            this.btnBuscarTareas.TabIndex = 31;
            this.btnBuscarTareas.Text = "Buscar";
            this.btnBuscarTareas.UseVisualStyleBackColor = false;
            this.btnBuscarTareas.Click += new System.EventHandler(this.btnBuscarTareas_Click);
            // 
            // txtBuscarTareass
            // 
            this.txtBuscarTareass.BackColor = System.Drawing.Color.Silver;
            this.txtBuscarTareass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarTareass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTareass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBuscarTareass.Location = new System.Drawing.Point(320, 55);
            this.txtBuscarTareass.Name = "txtBuscarTareass";
            this.txtBuscarTareass.Size = new System.Drawing.Size(200, 17);
            this.txtBuscarTareass.TabIndex = 36;
            this.txtBuscarTareass.Text = "Buscar \"Nombre\"";
            this.txtBuscarTareass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscarProducto_MouseClick);
            this.txtBuscarTareass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 37;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarTareass);
            this.Controls.Add(this.btnBuscarTareas);
            this.Controls.Add(this.txtBuscarTarea);
            this.Controls.Add(this.GridTareas);
            this.Controls.Add(this.lblProduCategorias);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnFiltroTodosTar);
            this.Controls.Add(this.btnFiltroEnd);
            this.Controls.Add(this.btnFiltroNoInic);
            this.Controls.Add(this.btnFiltroEnProces);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElimOrd;
        private System.Windows.Forms.Button btnNuevoOrd;
        private System.Windows.Forms.Button btnEditarOrd;
        private Bunifu.Framework.UI.BunifuTileButton btnFiltroTodosTar;
        private Bunifu.Framework.UI.BunifuTileButton btnFiltroEnd;
        private Bunifu.Framework.UI.BunifuTileButton btnFiltroNoInic;
        private Bunifu.Framework.UI.BunifuTileButton btnFiltroEnProces;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblProduCategorias;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridTareas;
        private Bunifu.Framework.UI.BunifuTextbox txtBuscarTarea;
        private System.Windows.Forms.Button btnBuscarTareas;
        private System.Windows.Forms.TextBox txtBuscarTareass;
        private System.Windows.Forms.Label label2;
    }
}