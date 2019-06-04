using Proyecto_01.Formas_Vtn_sec;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_01
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        public static ArrayList Iserts = new ArrayList();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        public void Cargar_ProductosVenta()
        {
            // se cargan los datos del ultimo producto vendido
            string Ruta_Img = bd.selectstring("select ImagenProduct from ultimovendido;");
            imgUltiVenta.Image = Image.FromFile(Ruta_Img);
            lblNombreProduc.Text = bd.selectstring("select nombre from ultimovendido;");
            lblPrecioProduct.Text = bd.selectstring("select precio_venta from ultimovendido;");

            //  se cargan los datos del producto mas vendido
            Ruta_Img = bd.selectstring("select ImagenProduct from cantidadvendida;");
            imgMasVendido.Image = Image.FromFile(Ruta_Img);
            lblNomProduc.Text= bd.selectstring("select nombre from cantidadvendida;");
            lblPrecioProdMas.Text= bd.selectstring("select precio_venta from cantidadvendida;");

            GridVEntasProduct.DataSource = bd.SelectDataTable("select `id_producto`,`nombre`,`detalles`,`precio_venta`,`Stock` from productos left join `cestados` on `cestados`.`idEstados` = `Id_Estado_cEstados` where `productos`.`Id_Estado_cEstados` = 4; ");
        }

        private void Venta_Load(object sender, EventArgs e)
        {

            Cargar_ProductosVenta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaVenta vnt = new NuevaVenta();
            vnt.labelID.Text = Convert.ToString(GridVEntasProduct.CurrentRow.Cells["id_producto"].Value);
            vnt.ShowDialog();


        }

        private void txtBuscarProducto_OnTextChange(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cargar_ProductosVenta();
        }

        private void txtBuscarTareass_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarventas.Text = "";
            txtBuscarventas.ForeColor = Color.DimGray;
        }

        private void txtBuscarventas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_venta();
                labelaux.Focus();
            }
        }
        public void Buscar_venta()
        {
            // codigo para buscar
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
