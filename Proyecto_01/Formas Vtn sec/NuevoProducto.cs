using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using MySql.Data.MySqlClient;

namespace Proyecto_01
{
    public partial class NuevoProducto : Form
    {

        //metodo para saber si una cadena es entero
        public bool EsEntero(string cadena)
        {
            int numero;
            try
            {
                numero = Convert.ToInt32(cadena);
                if (numero > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //metodo para saber si una cadena es double
        public bool EsDouble(string cadena)
        {
            double numero;
            try
            {
                numero = Convert.ToDouble(cadena);
                if (numero > 0)
                {
                    return true;
                }
                else
                {                    
                    return false;
                }                
            }
            catch (Exception e)
            {
                return false;
            }
        }

        BaseDeDatos bd = new BaseDeDatos();

        public NuevoProducto()
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
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelarNewPRodc_Click(object sender, EventArgs e)
        {
            Close();
        }

        // almacena la ruta
        String ruta_img;

        //define si se mostrarán los productos o materias
        Boolean mostrar = true;
        private void BtnGuardarProduc_Click(object sender, EventArgs e)
        {
            int intstock;
            double dobprecio, dobcosto;
            if (txtNombreProduct.TextLength == 0)
            {
                MessageBox.Show("El Campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (EsDouble(txtPrecioProduct.Text) != true)
                {
                    MessageBox.Show("Error en el campo Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (EsDouble(txtCostoProduct.Text) != true)
                    {
                        MessageBox.Show("Error en el Campo Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (EsEntero(txtStockProduct.Text) != true)
                        {
                            MessageBox.Show("Error en el Campo Stock ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            if(esta_vacio_mi_combobox(cmbEstatus,lblestatus)==true || esta_vacio_mi_combobox(cmbCategoria, lblCategoriaProduct) == true)
                            {
                                //muestra mensaje del metodo
                            }
                            else
                            {
                                if (picImagen.Image == null)
                                {
                                    MessageBox.Show("Se debe ingresar una imagen ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    // conversion de valores una vez verificados
                                    dobprecio = Convert.ToDouble(txtPrecioProduct.Text);
                                    dobcosto = Convert.ToDouble(txtCostoProduct.Text);
                                    intstock = int.Parse(txtStockProduct.Text);
                                    Boolean continuar = true;

                                    // switch para deteerminar cual es la categoria seleccionada
                                    int id_categoria = 0;
                                    switch (cmbCategoria.SelectedItem.ToString())
                                    {
                                        case "Ropa":
                                            id_categoria = 1;
                                            break;
                                        case "Recipientes":
                                            id_categoria = 2;
                                            break;
                                        case "Otros":
                                            id_categoria = 3;
                                            break;
                                        case "Papeleria":
                                            id_categoria = 4;
                                            break;
                                        default:
                                            MessageBox.Show("No puedes dejar el campo categoria vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            continuar = false;
                                            break;
                                    }

                                    if (continuar == true)
                                    {
                                        //switch para determinar cual es el status seleccionado
                                        int id_estatus = 0;
                                        switch (cmbEstatus.SelectedItem.ToString())
                                        {
                                            case "Habilitado":
                                                id_estatus = 4;
                                                break;
                                            case "Deshabilitado":
                                                id_estatus = 5;
                                                break;
                                            default:
                                                MessageBox.Show("No puedes dejar el campo Estatus vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                continuar = false;
                                                break;
                                        }
                                        if (continuar == true)
                                        {
                                            ruta_img = examinar.FileName.Replace("\\", "\\\\");
                                            if (se_Modifico_UnRegistro == true)
                                            {

                                                if (mostrar == true)
                                                {
                                                    if (bd.executecommand("call `Actualizar_Registro_prod` (" + id_aModificar + ",'" + txtNombreProduct.Text.Trim() + "', '" + txtDescripProduct.Text.Trim() + "','" + ruta_img + "'," + dobprecio + "," + dobcosto + "," + intstock + "," + id_categoria + "," + id_estatus + ");"))
                                                    {
                                                        MessageBox.Show("Exito al Modificar", "agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    if (bd.executecommand("call `Actualizar_Registro_MateriaP` (" + id_aModificar + ",'" + txtNombreProduct.Text.Trim() + "', '" + txtMarca.Text.Trim() + "' , '" + ruta_img + "', '" + txtDescripProduct.Text.Trim() + "', " + intstock + "," + dobcosto + "," + dobprecio + "," + id_estatus + "," + id_categoria + ");"))
                                                    {
                                                        MessageBox.Show("Exito al Modificar", "agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                    }
                                                }
                                                se_Modifico_UnRegistro = false;
                                            }
                                            else
                                            {
                                                //Procedimiento almacenado para insertar los datos
                                                if (mostrar == true)
                                                {
                                                    if (bd.executecommand("call `nuevo_producto` ('" + txtNombreProduct.Text.Trim() + "', '" + txtDescripProduct.Text.Trim() + "','" + ruta_img + "'," + dobprecio + "," + dobcosto + "," + intstock + "," + id_categoria + "," + id_estatus + ");"))
                                                    {
                                                        MessageBox.Show("Exito al agregar", "agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    if (bd.executecommand("call `nueva_materia` ('" + txtNombreProduct.Text.Trim() + "', '" + txtMarca.Text.Trim() + "' , '" + ruta_img + "', '" + txtDescripProduct.Text.Trim() + "', " + intstock + "," + dobcosto + "," + dobprecio + "," + id_estatus + "," + id_categoria + ");"))
                                                    {
                                                        MessageBox.Show("Exito al agregar", "agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Error al agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }                                                        
                        }
                    }
                }
            }
        }
        Boolean se_Modifico_UnRegistro = false;

        //registra el id a actualizar
        int id_aModificar;

        // metodo para recuperar los datos de un producto registrado
        public void recuperar(DataTable dt, Boolean editar_product,Boolean que_mostrar)
        {
            lblImagen.Visible = false;

            if (editar_product == true)
            {
                // verifica que es lo que se va a editar y en bace a eso configura los controles de opcion para saber que se recuperará
                if (que_mostrar == true)
                {
                    txtMarca.Enabled = false;
                    optnProducto.Checked = true;
                    optnMateria.Enabled = false;
                }
                else
                {
                    txtMarca.Enabled = true;
                    optnMateria.Checked = true;
                    optnProducto.Enabled = false;
                    txtMarca.Text = Convert.ToString(dt.Rows[0]["Marca"]);
                }

                /* la tabla que se recibe como parametro está configurada para que arrojen las mismas columnas,
                   excepto cuando se trata de una materia prima, ahi se le añade una columna de Marca, de ahi en fuera todo es igual*/
                txtNombreProduct.Text = Convert.ToString(dt.Rows[0]["nombre"]);
                txtDescripProduct.Text = Convert.ToString(dt.Rows[0]["detalles"]);
                txtPrecioProduct.Text = Convert.ToString(dt.Rows[0]["precio_venta"]);
                txtCostoProduct.Text = Convert.ToString(dt.Rows[0]["costo_compra"]);
                txtStockProduct.Text = Convert.ToString(dt.Rows[0]["stock"]);
                id_aModificar = Convert.ToInt32(dt.Rows[0]["id_producto"]);
                ruta_img = Convert.ToString(dt.Rows[0]["ImagenProduct"]).Replace("\\", "\\\\");

                try
                {
                    picImagen.Image = Image.FromFile(Convert.ToString(dt.Rows[0]["ImagenProduct"]));
                }
                catch (Exception)
                {

                    picImagen.Image = null;
                }
               

                //determina cual es la categoria
                switch (Convert.ToInt32(dt.Rows[0]["cat"]))
                {
                    case 1:
                        cmbCategoria.SelectedItem = "Ropa";
                        break;
                    case 2:
                        cmbCategoria.SelectedItem = "Recipientes";
                        break;
                    case 3:
                        cmbCategoria.SelectedItem = "Otros";
                        break;
                    case 4:
                        cmbCategoria.SelectedItem = "Papeleria";
                        break;                    
                }

                //determina cual es el estatus
                switch (Convert.ToInt32(dt.Rows[0]["estado"]))
                {
                    case 4:
                        cmbEstatus.SelectedItem = "Habilitado";
                        break;
                    case 5:
                        cmbEstatus.SelectedItem = "Deshabilitado";
                        break;                   
                }

                //señala que se terminó de editar el registro
                editar_product = false;
                se_Modifico_UnRegistro = true;
            }
        }

        // metodo para cargar una imagen en el picturebox
        public OpenFileDialog examinar = new OpenFileDialog();
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            lblImagen.Visible = false;
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.OK)
            {
                picImagen.Image = Image.FromFile(examinar.FileName);
            }         
        }

        // al cargar el from se comprueva que se va a ingresar
        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            if (mostrar == true)
            {
                txtMarca.Enabled = false;
            }
            else
            {
                txtMarca.Enabled = true;

            }
        }

        // metodos que determinan que pasará al seleccionar una opción en los option buton de producto o materia
        private void OptnProducto_CheckedChanged(object sender, EventArgs e)
        {
            mostrar = true;
            txtMarca.Enabled = false;
        }

        private void OptnMateria_CheckedChanged(object sender, EventArgs e)
        {
            mostrar = false;
            txtMarca.Enabled = true;
        }
       
        public bool esta_vacio_mi_combobox(ComboBox combo, Label name)
        {
            if (combo.SelectedIndex > -1)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una opcion en " + name.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

        }

    }
}

