using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_01.Formas_Vtn_Pricipales;

namespace Proyecto_01.Formas_Vtn_sec
{
    public partial class Ventana_Actualizar : Form
    {
        public static String IdSeleccionado;
       public static ArrayList CAdenas_Materias = new ArrayList();
        Ordenes ord = new Ordenes();
        Double M2TotalLona;
        string insertMtLona, insertMtSd, insertMtRecip;
        BaseDeDatos bd = new BaseDeDatos();
        public Ventana_Actualizar()
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
        private void Ventana_Actualizar_Load(object sender, EventArgs e)
        {
            
            Recuperar();
            Actual_Ordn.DataSource = bd.SelectDataTable("call `Actual`(" + Convert.ToInt16(labelID.Text) + ");");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void ComboPrioridad_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void Recuperar()
        {
           

            txtNombreOrdn.Text = bd.selectstring("select `nombre_cliente` from `ordenes`where `ordenes`.`id_orden` =" + labelID.Text + ";");
            txtDescripOrden.Text = bd.selectstring("select `descripcion` from `ordenes`where `ordenes`.`id_orden` =" + labelID.Text + ";");
           // txtFechaOrden.Text = bd.selectstring("select `fecha` from `ordenes`where `ordenes`.`id_orden` =" + labelID.Text + ";");
            
          //  comboStatus.SelectedText = bd.selectstring("select `Estado` from `ordenes` right join `cestados` on `Id_Estado_Status`=`idEstados` where `ordenes`.`id_orden` =" + labelID.Text + ";");
           // ComboPrioridad.SelectedText = bd.selectstring("select `Prioriedad` from `ordenes` right join `cprioridad` on `prioridad`=`idcprioridad` where `ordenes`.`id_orden` =" + labelID.Text + ";");
            txtProgreso.Text = bd.selectstring("select `Progreso` from `ordenes` where `ordenes`.`id_orden` =" + labelID.Text + ";");
            if (txtProgreso.Text != null && txtProgreso.Text != "")
            {
                Avance.Position = Convert.ToInt32(txtProgreso.Text);
            }
            else
            {
                Avance.Position = 0;
            }
            
        }




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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Panel_OcultarLona.Visible = false;
                GridLona.DataSource = bd.SelectDataTable("select `id_MP`,`nombre`,`Stock`,`descripción` from `almacen_materia_prima` where `Id_Categoria_ccateg` = 5; ");
            }
            else
            {
                Panel_OcultarLona.Visible = true;
            }
        }

        private void checkBRecipint_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBRecipint.Checked == true)
            {
                Panel_OcultarRecipient.Visible = false;
                bunifuCustomDataGrid1.DataSource = bd.SelectDataTable("select `id_MP`,`nombre`,`Stock`,`descripción` from `almacen_materia_prima` where `Id_Categoria_ccateg` = 2; ");
            }
            else
            {
                Panel_OcultarRecipient.Visible = true;
            }
        }

        private void gridSuadera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TotalRopa();
        }
        private void txtCantidadSd_KeyUp(object sender, KeyEventArgs e)
        {
            TotalRopa();
        }

        private void GridLona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar_GridLona();
        }
        private void txtAnchoM_KeyUp(object sender, KeyEventArgs e)
        {
            Cargar_GridLona();
        }

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
                    if (StockSelect > 0)
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
        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TotalRecipient();
        }

        private void txtCAntidad_KeyUp(object sender, KeyEventArgs e)
        {
            TotalRecipient();
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
                    if (StockSelect > 0 && StockSelect >= Convert.ToInt16(txtCantidadSd.Text))
                    {
                        //Trael el precio unitario de la base de datos para lo seleccionado
                        PrecioUnitRopa.Text = bd.selectstring("select `PrecioUnitario_Venta` from `almacen_materia_prima` where `id_MP` = " + idSeleccionado + "; ");
                        //Optiene el total y lo muestra en un label
                        try
                        {
                            lblTotalSd.Text = Convert.ToString(Convert.ToInt16(this.txtCantidadSd.Text) * Convert.ToInt16(this.PrecioUnitRopa.Text));
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
        public void TotalRecipient()
        {
            string idSeleccionado;
            int StockSelect;
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                idSeleccionado = Convert.ToString(bunifuCustomDataGrid1.CurrentRow.Cells["id_MP"].Value);
                try
                {
                    StockSelect = Convert.ToInt16(bunifuCustomDataGrid1.CurrentRow.Cells["Stock"].Value);
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

        private void button2_Click(object sender, EventArgs e)
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

            if (checkBSuadaer.Checked == true && Convert.ToInt16(lblID.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(txtCantidadSd.Text);
                    insertMtSd = "INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES("+ Convert.ToInt16(labelID.Text) + ", '" + Convert.ToInt16(lblID.Text) + "', '" + Convert.ToInt16(txtCantidadSd.Text) + "');";
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
                    Convert.ToDouble(lblMetrosCuadrados.Text);
                    insertMtLona = "INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES("+ Convert.ToInt16(labelID.Text) + ", '" + Convert.ToInt16(lblLunaselect.Text) + "', '" + M2TotalLona + "');";
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
                    insertMtRecip = "INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES("+ Convert.ToInt16(labelID.Text) + ", '" + Convert.ToInt16(lblTazaSelect.Text) + "', '" + Convert.ToInt16(txtCAntidad.Text) + "');";
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Recipientes");

                }

            }
            if (Convert.ToDouble(txtPrecioOrdn.Text) > 1)
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

        private void calendarControl1_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaOrden.Text = calendarControl1.SelectionStart.ToString("yyyy-MM-dd");
            calendarControl1.Visible = false;
        }

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

        private void Elim_Materia_Click(object sender, EventArgs e)
        {
            String IdSeleccionActual;
            IdSeleccionActual = Convert.ToString(Actual_Ordn.CurrentRow.Cells["id_MP"].Value);
            DialogResult EliminarYORN = MessageBox.Show("¿Realmente quiere eliminar el registro?", "Eliminar Orden", MessageBoxButtons.YesNo);
            if (EliminarYORN == DialogResult.Yes)
            {
                MessageBox.Show(IdSeleccionActual);
                bd.executecommand("DELETE FROM `frerama2`.`materia_orden` WHERE(`Id_almacen_materia` = '" + Convert.ToInt16(IdSeleccionActual) + "' and `Id_ordenes` = '" + Convert.ToInt16(labelID.Text) + "');");
                Actual_Ordn.DataSource = bd.SelectDataTable("call `Actual`(" + Convert.ToInt16(labelID.Text) + ");");
            }
            

        }

        private void btnAgregarMatera_Click(object sender, EventArgs e)
        {

            txtPrecioOrdn.Text = Convert.ToString(Convert.ToDouble(txtPrecioOrdn.Text) + Convert.ToDouble(lblTotalLona.Text) + Convert.ToDouble(lblTotalSd.Text) + Convert.ToDouble(lblTotalRecip.Text));
            //Define la cadena para agregar la materia de la orden, asi esta cadena se actualizara cada ves que se le de clic al boton agregar materia prima y solo se guardara en la base de datos cuando se le da clic al boton guardar
            if (checkBSuadaer.Checked == true && Convert.ToInt16(lblID.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(txtCantidadSd.Text);
                    CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES("+Convert.ToInt16(labelID.Text)+", '" + Convert.ToInt16(lblID.Text) + "', '" + Convert.ToInt16(txtCantidadSd.Text) + "');");
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
                    CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES("+ Convert.ToInt16(labelID.Text) + ", '" + Convert.ToInt16(lblLunaselect.Text) + "', '" + M2TotalLona + "');");
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
                    CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES("+ Convert.ToInt16(labelID.Text)+", '" + Convert.ToInt16(lblTazaSelect.Text) + "', '" + Convert.ToInt16(txtCAntidad.Text) + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Recipientes");

                }

            }
            // Actualizar_Materia AM = new Actualizar_Materia();
            // AM.Show();
            /*
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

            }*/
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            string Actualizar_ordn;
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
                porcentaje = Convert.ToInt16(txtProgreso.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se asigno un porcentaje, Se guardo el valor por defecto 25% ");

            }


            //Ya jala este procedimiento
            //Procedimiento para agregar las ordenes a la base de datos
            Actualizar_ordn = "call `ActualizarOrden`('"+ Convert.ToInt16(labelID.Text)+ "','" + txtNombreOrdn.Text + "', '" + txtDescripOrden.Text + "','" + txtFechaOrden.Text + "'," + IntComboPrioridad + "," + IntEstado_StatusID + "," + porcentaje + ");";
            if (bd.executecommand(Actualizar_ordn))
            {
                MessageBox.Show("Exito al Actualizar la orden");
                if (checkBLona.Checked == true)
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
                if (checkBSuadaer.Checked == true)
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
                if (CAdenas_Materias.Count>0)
                {
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
                
            }
            else
            {
                MessageBox.Show("ERROR al agregar la orden");
                MessageBox.Show(Actualizar_ordn);
            }
            this.Close();

            ord.Cargar_GridOrdn();


        }
    }
}
