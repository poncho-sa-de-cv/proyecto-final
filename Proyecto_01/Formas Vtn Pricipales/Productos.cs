using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_01
{
    
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();

        // variable que determina que se va a visualizar, true = productos, false = materia prima    
        public Boolean que_mostrar = true;     

        //carga los registros del datagridview
        public void Cargar_GridProductos()
        {
            if (que_mostrar==true)
            {
                GridProductos.DataSource = bd.SelectDataTable("select * from vista_productos; ");
            }
            else
            {
                GridProductos.DataSource = bd.SelectDataTable("select * from vista_mp; ");
            }
        }      

        //al abrir productos se carga el datagridview con los datos por default (productos);
        private void Productos_Load(object sender, EventArgs e)
        {
            Cargar_GridProductos();
        }


        //Conjunto de metodos que cargan la vista correspondiente al seleccionar un filtro sehgun la opción marcada (optionbuton)
        int idFiltro;// contiene el id del filtro que se buscará
        private void btnFiltroTodos_Click(object sender, EventArgs e)
        {
            GridProductos.DataSource = null;
            if (que_mostrar == true)
            {
                GridProductos.DataSource = bd.SelectDataTable("select * from vista_productos; ");
            }
            else
            {
                GridProductos.DataSource = bd.SelectDataTable("select * from vista_mp; ");
            }
        }
        private void btnFiltroRopa_Click(object sender, EventArgs e)
        {
            GridProductos.DataSource = null;
            idFiltro = 1;
            if (que_mostrar == true)
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_prod`(" + idFiltro + ");");
            }
            else
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_mp`(" + idFiltro + ");");

            }
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            GridProductos.DataSource = null;
            idFiltro = 2;
            if (que_mostrar == true)
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_prod`(" + idFiltro + ");");
            }
            else
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_mp`(" + idFiltro + ");");
            }
        }
        private void btnPapeleriaFiltro_Click(object sender, EventArgs e)
        {
            GridProductos.DataSource = null;
            idFiltro = 4;
            if (que_mostrar == true)
            {
                GridProductos.DataSource =bd.SelectDataTable("call `vista_segun_cat_prod`(" + idFiltro + ");");
            }
            else
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_mp`(" + idFiltro + ");");
            }
        }         
        private void btnFiltroOtros_Click(object sender, EventArgs e)
        {
            GridProductos.DataSource = null;
            idFiltro = 3;
            if (que_mostrar == true)
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_prod`(" + idFiltro + ");");
            }
            else
            {
                GridProductos.DataSource = bd.SelectDataTable("call `vista_segun_cat_mp`(" + idFiltro + ");");
            }
        }


        //al darle clic en buscar comprueva que no este vacio el campo de "buscar" y ejecuta el metodo para buscar
        private void BtnBuscarProduct_Click(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text.Trim() == "")
            {
                // no pasará nada solo el foco pasara al label auxiliar
            }
            else
            {
                Buscar_Product();
            }

        }

        // procedimiento para bucar un proucto por su nombre
        public void Buscar_Product()
        {
            DataTable dt = new DataTable();
            if (que_mostrar == true)
            {
                dt = bd.SelectDataTable("call `Buscar_Nombre_prod`('" + txtBuscarProducto.Text.Trim() + "');");
            }
            else
            {
                dt = bd.SelectDataTable("call `Buscar_Nombre_MateriaP`('" + txtBuscarProducto.Text.Trim() + "');");
            }                                                     
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarProducto.Text = "Buscar `Nombre`";
                    txtBuscarProducto.ForeColor = Color.DodgerBlue;
                }
                else
                {
                    txtBuscarProducto.Text = "Buscar `Nombre`";
                    txtBuscarProducto.ForeColor = Color.DodgerBlue;
                    GridProductos.DataSource = dt;
                }
                        
        }
        //almacena el id del registro a editar
        int id_product;

        //al dar nuevo producto se carga la ventana de nuevo producto
        private void BtnNuevoProduct_Click(object sender, EventArgs e)
        {
            
            NuevoProducto vtnNuevoProduc = new NuevoProducto();
            vtnNuevoProduc.ShowDialog();
        }
       
        private void BtnEditarProduct_Click(object sender, EventArgs e)
        {
           
            // verifica que se haya seleccionado un registro y obtiene su id
            if (GridProductos.SelectedRows.Count == 1)
            {
                //se ejecuta el procedimiento almacenado y el resultado se almacena en un datatable
                Boolean editar_producto = true;
                id_product = Convert.ToInt32(GridProductos.CurrentRow.Cells[0].Value);
                DataTable dataTable = new DataTable();
                if (que_mostrar == true)
                {
                    dataTable = bd.SelectDataTable("call `Obtener_Producto`(" + id_product + ");");
                }
                else
                {
                    dataTable = bd.SelectDataTable("call `obtener_materia`(" + id_product + ");");
                }

                //llamo al metodo para recuperar los datos y los muestro en el from de nuevo producto
                NuevoProducto editar = new NuevoProducto();
                editar.recuperar(dataTable, editar_producto, que_mostrar);
                editar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarProduct_Click(object sender, EventArgs e)
        {
            // verifica que se haya seleccionado un registro y obtiene su id
            if (GridProductos.SelectedRows.Count == 1)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    int id_producto_aEliminar = Convert.ToInt32(GridProductos.CurrentRow.Cells[0].Value);
                    if (que_mostrar == true)
                    {
                        bd.executecommand("delete from productos where id_producto = " + id_producto_aEliminar + ";");
                    }
                    else
                    {
                        bd.executecommand("delete from almacen_materia_prima where id_MP = " + id_producto_aEliminar + ";");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cargar_GridProductos();

        } 

        //pasa el foco al label de auxilio
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_Product();
                lblauxiliar.Focus();
            }
        }

        // al dar clic en el campo de buscar producto, este modificara su texto dejando lo en blanco y cambiando su color
        private void TxtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarProducto.Text = "";
            txtBuscarProducto.ForeColor = Color.DimGray;
        }

        //metodos para definir que mostrar en el datagridview
        private void RdbtProductos_CheckedChanged(object sender, EventArgs e)
        {
            que_mostrar = true;
            Cargar_GridProductos();
        }
        private void RdbtMateriPrima_CheckedChanged(object sender, EventArgs e)
        {
            que_mostrar = false;
            Cargar_GridProductos();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Cargar_GridProductos();
        }

       
    }
}
