using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;
using Proyecto_01.Formas_Vtn_sec;

namespace Proyecto_01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();


            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            VtnMenu form = Application.OpenForms.OfType<VtnMenu>().FirstOrDefault();
            VtnMenu hijo1 = form ?? new VtnMenu();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
        }

        BaseDeDatos bd = new BaseDeDatos();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

                btnMaxi.Visible = true;
                BtnRes.Visible = false;
            
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(fh);
            this.splitContainerControl1.Panel2.Tag = fh;
            fh.Show();
        }
        

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            VtnMenu form = Application.OpenForms.OfType<VtnMenu>().FirstOrDefault();
            VtnMenu hijo1 = form ?? new VtnMenu();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
            
        }

        private void btnMenu_Click_2(object sender, EventArgs e)
        {

            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            VtnMenu form = Application.OpenForms.OfType<VtnMenu>().FirstOrDefault();
            VtnMenu hijo1 = form ?? new VtnMenu();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
        }
        
        private void imgVenta_Click_1(object sender, EventArgs e)
        {

            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            Venta form = Application.OpenForms.OfType<Venta>().FirstOrDefault();
            Venta hijo1 = form ?? new Venta();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
        }

        private void imgOrdenes_Click_1(object sender, EventArgs e)
        {
            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            Ordenes form = Application.OpenForms.OfType<Ordenes>().FirstOrDefault();
            Ordenes hijo1 = form ?? new Ordenes();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
        }

        private void imgProducto_Click_1(object sender, EventArgs e)
        {
            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            Productos form = Application.OpenForms.OfType<Productos>().FirstOrDefault();
            Productos hijo1 = form ?? new Productos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
        }

        private void imgProcesos_Click_1(object sender, EventArgs e)
        {
            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            Procesos form = Application.OpenForms.OfType<Procesos>().FirstOrDefault();
            Procesos hijo1 = form ?? new Procesos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();
        }

        private void imgReporte_Click_1(object sender, EventArgs e)
        {
            if (this.splitContainerControl1.Panel2.Controls.Count > 0)
                this.splitContainerControl1.Panel2.Controls.RemoveAt(0);
            Reporte form = Application.OpenForms.OfType<Reporte>().FirstOrDefault();
            Reporte hijo1 = form ?? new Reporte();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.splitContainerControl1.Panel2.Controls.Add(hijo1);
            this.splitContainerControl1.Panel2.Tag = hijo1;
            hijo1.Show();

            if (btnVentasHoy.Visible == false)
            {
                btnReporteProductos.Visible = true;
                btnReporteInvent.Visible = true;
                btnVentasHoy.Visible = true;
            }
            else
            {
                btnReporteProductos.Visible = false;
                btnReporteInvent.Visible = false;
                btnVentasHoy.Visible = false;
            }
            

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            BtnRes.Visible = true;

        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            BtnRes.Visible = false;
        }
        
        private void ShowPreview()
        {
            
        }
        private void btnVentasHoy_Click(object sender, EventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new ProductosReport());

            // Invocar el formulario Vista preliminar de la cinta de opciones    
            // y cargar el documento de informe en él. 
            printTool.ShowRibbonPreview();

            // Invocar el formulario Vista previa de impresión de la cinta de manera modal  
            // con la configuración de apariencia y tacto especificada. 
         //   printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default);

            // Invoque el formulario de Vista preliminar    
            // y cargue el documento de informe en él. 
           // printTool.ShowPreview();

            // Invocar el formulario de Vista preliminar de manera modal  
            // con la configuración de apariencia y tacto especificada. 
          //  printTool.ShowPreviewDialog(UserLookAndFeel.Default);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteInvent_Click(object sender, EventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new Alamacen());

            // Invocar el formulario Vista preliminar de la cinta de opciones    
            // y cargar el documento de informe en él. 
            printTool.ShowRibbonPreview();
        }

        private void btnReporteComple_Click(object sender, EventArgs e)
        {

            ReportPrintTool printTool = new ReportPrintTool(new ProductosReport());

            // Invocar el formulario Vista preliminar de la cinta de opciones    
            // y cargar el documento de informe en él. 
            printTool.ShowRibbonPreview();


        }
    }
}
