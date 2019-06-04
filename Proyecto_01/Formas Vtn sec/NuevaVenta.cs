using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_01.Formas_Vtn_sec
{
    public partial class NuevaVenta : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        
        Productos nv = new Productos();

        Venta obj = new Venta();
        public NuevaVenta() 
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        ///
        //Boton Cerrar
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Minimizar
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            CargarVal();
        }
        public void CargarVal()
        {
            lblNombreVentaProduc.Text = bd.selectstring("select `nombre` from `productos` where `id_producto` = " + labelID.Text + ";");
            lblPrecioVentProduct.Text = bd.selectstring("select `precio_venta` from `productos` where `id_producto` = " + labelID.Text + ";");
            lblCategoriaVantPro.Text = bd.selectstring("select `Cat`  from `productos`  right join `ccategorias` on `ccategorias`.`idcCategorias` = `productos`.`Id_categoria` where `id_producto` = " + labelID.Text + ";");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lblTotalTodo.Text = Convert.ToString(Convert.ToDouble(lblPrecioVentProduct.Text) * Convert.ToDouble(txtCAntidad.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique la cantidad");
                lblTotalTodo.Text = "0";
                
            }
        }

        private void txtCAntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                         e.Handled = false;
            }
               else if (Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
               {
                       e.Handled = false;
               }
                else if (Char.IsSeparator(e.KeyChar))
                {
                       e.Handled = false;
                }
              else
              {
                        e.Handled = true;
              }
        }

        private void btnAgregarProduc_Click(object sender, EventArgs e)
        {
            
            Venta.Iserts.Add("INSERT INTO `frerama2`.`productos_venta` (`Id_Producto_Productos`, `Id_Venta_Total`, `Cantidad`) VALUES ('"+Convert.ToInt16(labelID.Text) + "', (select max(`idVenta`) from `venta_total`) + 1 , '"+ txtCAntidad.Text+ "');");
            
            this.Close();
        }
        //Agregar los productos a la base de datos detalle de la venta
        private void btnVenderVenta_Click(object sender, EventArgs e)
        {
            //Agregar a la tabla Venta
           
            //Agregar el producto acual a la lista de inserciones
            Venta.Iserts.Add("INSERT INTO `frerama2`.`productos_venta` (`Id_Producto_Productos`, `Id_Venta_Total`, `Cantidad`) VALUES ('" + Convert.ToInt16(labelID.Text) + "', (select max(`idVenta`) from `venta_total`) + 1 , '" + txtCAntidad.Text + "');");
            //Agregar los productos a la base de datos detalle de la venta 
            foreach (var item in Venta.Iserts)
            {
                if (bd.executecommand(Convert.ToString(item)))
                {
                    MessageBox.Show("Exito al agregar productos ");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto...");
                    MessageBox.Show(Convert.ToString(item));
                }
               
            }
            //Borra todos los registros de el arreglo de inserciones
            Venta.Iserts.Clear();
            this.Close();


        }
    }
}
