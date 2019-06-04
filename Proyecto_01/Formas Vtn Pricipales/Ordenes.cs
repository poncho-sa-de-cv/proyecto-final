using Proyecto_01.Formas_Vtn_sec;
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
    public partial class Ordenes : Form
    {
        //Inicializa el objeto Base de Datos de la biblioteca de clases 
        BaseDeDatos bd = new BaseDeDatos();
        string idSeleccionado;
        public Ordenes()
        {
            InitializeComponent();
        }
        //Muestra la pantalla emergente de actualizar
        private void btnNuevoOrd_Click(object sender, EventArgs e)
        {
            
            NuevaOrden vtnNuevoOrdn = new NuevaOrden();
            vtnNuevoOrdn.ShowDialog();
        }


        //Manda llamar al metodo cargar 
        public void Ordenes_Load(object sender, EventArgs e)
        {
            Cargar_GridOrdn();
        }
        //Carga Todas las tareas 
        public void Cargar_GridOrdn()
        {
            GridTareas.DataSource = bd.SelectDataTable("select `id_orden`,`nombre_cliente` as Cliente,`descripcion`,`fecha`,`Prioriedad`,`cestados`.`Estado` from ordenes left join `cestados` on `cestados`.`idEstados` = `ordenes`.`Id_Estado_Status` left join `cprioridad` on `cprioridad`.`idcprioridad` = `ordenes`.`prioridad`; ");
        }
        //seleccionar el ide de la tarea y ponerlo en la ventana de actualizar.
        private void btnEditarOrd_Click(object sender, EventArgs e)
        {

            Ventana_Actualizar Actualizar = new Ventana_Actualizar();
            Actualizar.labelID.Text = Convert.ToString(GridTareas.CurrentRow.Cells["id_orden"].Value);
            Actualizar.ShowDialog();
            
            

        }
        //Pasar a una variable string el ID seleccionado
        public void seleccionar()
        {
            
            if (GridTareas.SelectedRows.Count>0)
            {
                idSeleccionado = Convert.ToString(GridTareas.CurrentRow.Cells["id_orden"].Value);
                
            }
          
        }
        //Borrar Una Orden
        private void btnElimOrd_Click(object sender, EventArgs e)
        {
            seleccionar();

            DialogResult EliminarYORN = MessageBox.Show("¿Realmente quiere eliminar el registro?", "Eliminar Orden",  MessageBoxButtons.YesNo);
            if (EliminarYORN == DialogResult.Yes)
            {
                MessageBox.Show(idSeleccionado);
                bd.executecommand("DELETE FROM `frerama2`.`ordenes` WHERE (`id_orden` =" + idSeleccionado + ");");
            }
            Cargar_GridOrdn();
        }
        //Filtro de en en proceso
        private void btnFiltroEnProces_Click(object sender, EventArgs e)
        {
            GridTareas.DataSource = bd.SelectDataTable("call frerama2.FLTREnProceso(" + 2 + ");");
        }
        //Filtro de en almacen
        private void btnFiltroNoInic_Click(object sender, EventArgs e)
        {
            GridTareas.DataSource = bd.SelectDataTable("call frerama2.FLTREnProceso(" + 1 + ");");

        }
        //Filtro de terminado
        private void btnFiltroEnd_Click(object sender, EventArgs e)
        {
            GridTareas.DataSource =  bd.SelectDataTable("call frerama2.FLTREnProceso(" + 3 + ");");
        }
        //Filtro de TODO
        private void btnFiltroTodosTar_Click(object sender, EventArgs e)
        {
            GridTareas.DataSource = bd.SelectDataTable("select `id_orden`,`nombre_cliente` as Cliente,`descripcion`,`fecha`,`Prioriedad`,`cestados`.`Estado` from ordenes left join `cestados` on `cestados`.`idEstados` = `ordenes`.`Id_Estado_Status` left join `cprioridad` on `cprioridad`.`idcprioridad` = `ordenes`.`prioridad`; ");
        }

        private void txtBuscarTarea_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscarTarea.text = "";
        }

        //Buscar Un Nombre
        private void btnBuscarTareas_Click(object sender, EventArgs e)
        {
            Buscar_orden();
        }

        private void txtBuscarTarea_Click(object sender, EventArgs e)
        {
            txtBuscarTarea.text = "";
        }

        private void txtBuscarProducto_MouseClick(object sender, MouseEventArgs e)
        {           
                txtBuscarTareass.Text = "";
                txtBuscarTareass.ForeColor = Color.DimGray;            
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar_orden();
                label2.Focus();
            }
        }
        public void Buscar_orden()
        {
            String Busqueda = txtBuscarTareass.Text.Trim();
            GridTareas.DataSource = bd.SelectDataTable("call frerama2.Buscar_Orden('" + Busqueda + "');");
        }
    }
}
