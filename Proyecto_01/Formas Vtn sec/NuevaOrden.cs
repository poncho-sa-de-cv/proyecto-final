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
using Proyecto_01.Formas_Vtn_sec;
using Proyecto_01.Formas_Vtn_Pricipales;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Proyecto_01
{
    public partial class NuevaOrden : Form
    {
        ArrayList CAdenas_Materias = new ArrayList();
        BaseDeDatos bd = new BaseDeDatos();
        Ordenes ord = new Ordenes();
        Double M2TotalLona;
        string insertMtLona, insertMtSd, insertMtRecip; 
        public NuevaOrden()
        {
            InitializeComponent();
        }
        //Para poder mover la ventanda desde la barra de titulos creada 
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
        //Ocultar/mostrar Calendario
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (calendarControl1.Visible == true)
            {
                calendarControl1.Visible = false;
            }
            else if (calendarControl1.Visible == false)
            {
                calendarControl1.Visible = true;
            }
        }

        //Pasar la fecha al TXT en el formato de workBech
        private void calendarControl1_SelectionChanged(object sender, EventArgs e)
        {
            
            
            txtFechaOrden.Text = calendarControl1.SelectionStart.ToString("yyyy-MM-dd");
            calendarControl1.Visible = false;
        }

        private void ComboPrioridad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }
        //Cambia las imagenes que acompañan a el comboBox Status
        private void comboStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

            if ((String)comboStatus.SelectedItem == "No iniciada")
            {
                imgStatusCompl.Visible = false;
                imgStatusNoInic.Visible = true;
                imgStatusPRoces.Visible = false;
            }
            else if ((String)comboStatus.SelectedItem == "Completada")
            {
                imgStatusCompl.Visible = true;
                imgStatusNoInic.Visible = false;
                imgStatusPRoces.Visible = false;
            }
            else if ((String)comboStatus.SelectedItem == "En Proceso")
            {
                imgStatusCompl.Visible = false;
                imgStatusNoInic.Visible = false;
                imgStatusPRoces.Visible = true;
            }
        }
        //Cerrar si se preciona cancelar
        private void btnCancelarNewOrdn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Cambia las imagenes que acompañan a el comboBox Prioridad
        private void ComboPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ((String)ComboPrioridad.SelectedItem == "Normal")
            {
                imgPrioridadAlta.Visible = false;
                imgPrioridadBaja.Visible = false;
                ImgPrioridadNorma.Visible = true;

            }
            else if ((String)ComboPrioridad.SelectedItem == "Alta")
            {
                imgPrioridadAlta.Visible = true;
                imgPrioridadBaja.Visible = false;
                ImgPrioridadNorma.Visible = false;
            }
            else if ((String)ComboPrioridad.SelectedItem == "Baja")
            {
                imgPrioridadAlta.Visible = false;
                imgPrioridadBaja.Visible = true;
                ImgPrioridadNorma.Visible = false;
            }
        }

        //Cambia color de boton Nueva Materia
        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnAgregarMatera.ForeColor = Color.FromArgb(0, 120, 215);
        }
        //Cambia color de boton Agregar Materia
        private void btnAgregarMatera_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarMatera.ForeColor = Color.FromArgb(185, 209, 234);

        }
        //Agrega la materia a la tabla de Materia_Orden
        private void btnAgregarMatera_Click(object sender, EventArgs e)
        {
            //Muestra el total de la materia agregada
            txtPrecioOrdn.Text = Convert.ToString(Convert.ToDouble(lblTotalLona.Text) + Convert.ToDouble(lblTotalSd.Text) + Convert.ToDouble(lblTotalRecip.Text));
            //Elimina todas las cadenas de que contenga el Array de Materia AGREGADA
            CAdenas_Materias.Clear();
            /* foreach (var item in CAdenas_Materias)
             {
                 CAdenas_Materias.Remove(Convert.ToString(item));
             }*/
            //Define la cadena para agregar la materia de la orden, asi esta cadena se actualizara cada ves que se le de clic al boton agregar materia prima y solo se guardara en la base de datos cuando se le da clic al boton guardar
            
            if (checkBSuadaer.Checked == true && Convert.ToInt16(lblID.Text) >= 1 )
            {
                try
                {
                    Convert.ToInt16(txtCantidadSd.Text);
                    insertMtSd = "INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`) from Ordenes), '" + Convert.ToInt16(lblID.Text) + "', '" + Convert.ToInt16(txtCantidadSd.Text) + "');";
                }
                catch
                {
                    MessageBox.Show("Verifique la cantidad de Ropa");

                }
                

            }
            if (checkBLona.Checked == true && Convert.ToInt16(lblLunaselect.Text) >= 1 )
            {
                try
                {
                    Convert.ToDouble(lblMetrosCuadrados.Text);
                    insertMtLona = "INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`)  from Ordenes), '" + Convert.ToInt16(lblLunaselect.Text) + "', '" + M2TotalLona + "');";
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Lona");

                }
                
   
            }
            if (checkBRecipint.Checked == true && Convert.ToInt16(lblTazaSelect.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(txtCAntidad.Text);
                    insertMtRecip = "INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`) from Ordenes), '" + Convert.ToInt16(lblTazaSelect.Text) + "', '" + Convert.ToInt16(txtCAntidad.Text) + "');";
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Recipientes");

                }
                
            }
            if (Convert.ToDouble(txtPrecioOrdn.Text) >1)
            {
                btnAgregarMatera.Visible = true;
            }
            //Establece los Totales de nuevo en 0.0 Para que no de conflicto si se requiere modificar lo elegido
            lblTotalRecip.Text = "0.00";
            lblTotalLona.Text = "0.00";
            lblTotalSd.Text = "0.00";
            lblLunaselect.Text = "0";
            lblID.Text = "0";
            lblTazaSelect.Text = "0";
        }

        //Insertar la orden en la tabla de ordenes
        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            string AGregar_ordn;
            int IntComboPrioridad = 0, IntEstado_StatusID = 0;
            //Le da un valor anumerico a la prioridad elegida 
            try
            {
                switch (ComboPrioridad.SelectedItem.ToString())
                {

                    case "Normal":
                        IntComboPrioridad = 1;
                        break;
                    case "Alta":
                        IntComboPrioridad = 2;
                        break;
                    case "Baja":
                        IntComboPrioridad = 3;
                        break;

                    default:
                        IntComboPrioridad = 10;
                        break;
                }
            }
            catch (Exception)
            {

                
            }

            //le da un valor numerico a el status seleccionado
            try
            {
                switch (comboStatus.SelectedItem.ToString())
                {

                    case "No iniciada":
                        IntEstado_StatusID = 1;
                        break;
                    case "Completada":
                        IntEstado_StatusID = 2;
                        break;
                    case "En Proceso":
                        IntEstado_StatusID = 3;
                        break;

                    default:
                        IntEstado_StatusID = 10;
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique el campo de Status");
            }
            int porcentaje = 25;
            try
            {
                porcentaje = Convert.ToInt16(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se asigno un porcentaje, Se guardo el valor por defecto 25% ");
                
            }
            

            //Ya jala este procedimiento
            //Procedimiento para agregar las ordenes a la base de datos
            AGregar_ordn = "call `Insertar_Orden` ('"+txtNombreOrdn.Text+"', '"+txtDescripOrden.Text+"','" + txtFechaOrden.Text + "'," + IntComboPrioridad+","+ IntEstado_StatusID+","+ porcentaje + ");";
            if (bd.executecommand(AGregar_ordn))
            {
                MessageBox.Show("Exito al agregar la orden");
                if (checkBLona.Checked == true )
                {
                    //Introducir el iD de la materia en la tabla de oredenes y la cantidad de Lonas.                  
                    if (bd.executecommand(insertMtLona))
                    {
                        MessageBox.Show("Exito al agregar la materia LONA");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la materia LONA");
                    }
                    
                }
                if (checkBSuadaer.Checked == true )
                {
                    //Introducir el iD de la materia en la tabla de oredenes y la cantidad de Lonas.
                    //Estos 2 se deben de insrtar en una sola instruccion 
                    if (bd.executecommand(insertMtSd))
                    {
                        MessageBox.Show("Exito al agregar la materia ROPA");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la materia ROPA");
                    }
   
                }
                if (checkBRecipint.Checked == true)
                {
                    //Introducir el iD de la materia en la tabla de oredenes y la cantidad de Recipientes.
                    //Estos 2 se deben de insrtar en una sola instruccion 
                    if (bd.executecommand(insertMtRecip))
                    {
                        MessageBox.Show("Exito al agregar la materia RECIPIENTES");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la materia RECIPIENTES");
                    }

                }
                
                foreach (var item in CAdenas_Materias)
                {
                    if (bd.executecommand(Convert.ToString(item)))
                    {
                        MessageBox.Show("Exito al agregar la materia");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la materia Lista: " + item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error al agregar la orden");
                MessageBox.Show(AGregar_ordn);
            }
            this.Close();
            
            ord.Cargar_GridOrdn();

        }

        //Oculta la grid de recipientes 
        private void checkBRecipint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBRecipint.Checked == true)
            {
                Panel_OcultarRecipient.Visible = false;
                bunifuCustomDataGrid2.DataSource = bd.SelectDataTable("select `id_MP`,`nombre`,`Stock`,`descripción` from `almacen_materia_prima` where `Id_Categoria_ccateg` = 2; ");
            }
            else
            {
                Panel_OcultarRecipient.Visible = true;
            }
        }
        //Oculta la grid de Lona
        private void checkBLona_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBLona.Checked == true)
            {
                Panel_OcultarLona.Visible = false;
                GridLona.DataSource = bd.SelectDataTable("select `id_MP`,`nombre`,`Stock`,`descripción` from `almacen_materia_prima` where `Id_Categoria_ccateg` = 5; ");
            }
            else
            {
                Panel_OcultarLona.Visible = true;
            }
        }
        //Oculta la grid de Sudadera
        private void checkBSuadaer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBSuadaer.Checked == true)
            {
                Panel_OcultarRopa.Visible = false;
                gridSuadera.DataSource = bd.SelectDataTable("select `id_MP`,`nombre`,`Stock`,`descripción` from `almacen_materia_prima` where `Id_Categoria_ccateg` = 1; ");
            }
            else
            {
                Panel_OcultarRopa.Visible = true;
                
            }
        }

        //Manda llamar el metodo Para mostrar el total de la ropa
        public void gridSuadera_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TotalRopa();
           
        }

        public void TotalRopa()
        {
            string idSeleccionado;
            int StockSelect;
            //Determina si se ha seleccionado las celdas id_MO y Stock, y guarda estos valores 
            if (gridSuadera.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToString(gridSuadera.CurrentRow.Cells["id_MP"].Value);
                //Determina si hay Stock y si es asi muestra el precio unitario 
                try
                {
                    StockSelect = Convert.ToInt16(gridSuadera.CurrentRow.Cells["Stock"].Value);
                    if (StockSelect > 0 && StockSelect >= Convert.ToInt16( txtCantidadSd.Text))
                    {
                        //Trael el precio unitario de la base de datos para lo seleccionado
                        textPrecioUnitSuda.Text = bd.selectstring("select `PrecioUnitario_Venta` from `almacen_materia_prima` where `id_MP` = " + idSeleccionado + "; ");
                        //Optiene el total y lo muestra en un label
                        try
                        {
                            lblTotalSd.Text = Convert.ToString(Convert.ToInt16(this.txtCantidadSd.Text) * Convert.ToInt16(this.textPrecioUnitSuda.Text));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Verfique la cantidad (Solo numeros enteros)");

                        }

                        

                    }
                    else
                    {

                        MessageBox.Show("No hay suficiente Stock");
                    }
                }
                catch (Exception)
                {


                }

                lblID.Text = idSeleccionado;


            }
        }

        private void bunifuCustomDataGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TotalRecipient();
        }
        //Lo mismo de lo de ropa pero de los recipientes
        public void TotalRecipient()
        {
            string idSeleccionado;
            int StockSelect;
            if (bunifuCustomDataGrid2.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToString(bunifuCustomDataGrid2.CurrentRow.Cells["id_MP"].Value);
                try
                {
                    StockSelect = Convert.ToInt16(bunifuCustomDataGrid2.CurrentRow.Cells["Stock"].Value);
                    if (StockSelect > 0)
                    {

                        lblPRecioURecip.Text = bd.selectstring("select `PrecioUnitario_Venta` from `almacen_materia_prima` where `id_MP` = " + idSeleccionado + "; ");
                        //Optiene el total y lo muestra en un label
                        try
                        {
                            lblTotalRecip.Text = Convert.ToString((Convert.ToDouble(this.txtCAntidad.Text) * Convert.ToDouble(this.lblPRecioURecip.Text)));
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Verfique la cantidad (Solo numeros enteros)");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay Stock");
                    }
                }
                catch
                {
                    
                }

                lblTazaSelect.Text = idSeleccionado;

            }
        }

        private void GridLona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar_GridLona();
            
        }
        //Metodo para obtener los totales de la Lona
        public void Cargar_GridLona()
        {
            double StockSelect;
            string idSeleccionado;
            if (GridLona.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToString(GridLona.CurrentRow.Cells["id_MP"].Value);
                try
                {
                    StockSelect = Convert.ToDouble(GridLona.CurrentRow.Cells["Stock"].Value);
                    if (StockSelect > 0 )
                    {

                        lblPRecioM2.Text = bd.selectstring("select `PrecioUnitario_Venta` from `almacen_materia_prima` where `id_MP` = " + idSeleccionado + "; ");
                        //Optiene el total y lo muestra en un label
                        try
                        {
                            M2TotalLona = (Convert.ToDouble(TxtALtoM.Text) * Convert.ToDouble(txtAnchoM.Text));
                            lblMetrosCuadrados.Text = Convert.ToString(M2TotalLona);
                            if (StockSelect >= Convert.ToDouble(lblMetrosCuadrados.Text))
                            {
                                double TotalLona = M2TotalLona * Convert.ToDouble(lblPRecioM2.Text);
                               
                                lblTotalLona.Text = Convert.ToString(TotalLona);
                            }
                            else
                            {
                                //Poner la casilla en color rojo.
                            }
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Verfique la cantidad (Solo numeros enteros");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay Stock");
                    }
                }
                catch
                {
                    MessageBox.Show("Try Numero 1");
                }

                lblLunaselect.Text = idSeleccionado;



            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {


            txtPrecioOrdn.Text = Convert.ToString(Convert.ToDouble(txtPrecioOrdn.Text) + Convert.ToDouble(lblTotalLona.Text) + Convert.ToDouble(lblTotalSd.Text) + Convert.ToDouble(lblTotalRecip.Text));
            //Define la cadena para agregar la materia de la orden, asi esta cadena se actualizara cada ves que se le de clic al boton agregar materia prima y solo se guardara en la base de datos cuando se le da clic al boton guardar
            if (checkBSuadaer.Checked == true && Convert.ToInt16(lblID.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(txtCantidadSd.Text);
                    CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`) from Ordenes), '" + Convert.ToInt16(lblID.Text) + "', '" + Convert.ToInt16(txtCantidadSd.Text) + "');");
                }
                catch
                {
                    MessageBox.Show("Verifique la cantidad de Ropa");

                }
                

            }
            if (checkBLona.Checked == true && Convert.ToInt16(lblLunaselect.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(lblMetrosCuadrados.Text);
                    CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`)  from Ordenes), '" + Convert.ToInt16(lblLunaselect.Text) + "', '" + M2TotalLona + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Lona");

                }
                

            }
            if (checkBRecipint.Checked == true && Convert.ToInt16(lblTazaSelect.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(txtCAntidad.Text);
                    CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`) from Ordenes), '" + Convert.ToInt16(lblTazaSelect.Text) + "', '" + Convert.ToInt16(txtCAntidad.Text) + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Recipientes");

                }
                
            }
            lblTotalRecip.Text = "0.00";
            lblTotalLona.Text = "0.00";
            lblTotalSd.Text = "0.00";
            lblLunaselect.Text = "0";
            lblID.Text = "0";
            lblTazaSelect.Text = "0";

        }
        //Metodo para que cada que preciona una tecla en el texbox de cantidadad se actualice el total 
        private void txtCantidadSd_KeyUp(object sender, KeyEventArgs e)
        {
            TotalRopa();
        }

        private void NuevaOrden_Load(object sender, EventArgs e)
        {

        }

        private void txtFechaOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Metodo para que cada que preciona una tecla en el texbox de Ancho de la Lona se actualice el total
        private void txtAnchoM_KeyUp(object sender, KeyEventArgs e)
        {
            Cargar_GridLona();
        }
        //Metodo para que cada que preciona una tecla en el texbox de cantidadad se actualice el total 
        private void txtCAntidad_KeyUp(object sender, KeyEventArgs e)
        {
            TotalRecipient();
        }
    }
}
