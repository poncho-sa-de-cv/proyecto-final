using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_01.Formas_Vtn_sec
{
    public partial class Actualizar_Materia : Form
    {
        String IdSeleccionado;
        string insertMtLona, insertMtSd, insertMtRecip;
        Double M2TotalLona;
        public Actualizar_Materia()
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

        Ventana_Actualizar VA = new Ventana_Actualizar();
        BaseDeDatos bd = new BaseDeDatos();
       // ArrayList CAdenas_Materias = new ArrayList();
        private void Actualizar_Materia_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("call `Actual`('" + Convert.ToInt16(Ventana_Actualizar.IdSeleccionado) + "');");
            Actual_Ordn.DataSource = bd.SelectDataTable("call `Actual`(" + Convert.ToInt16(Ventana_Actualizar.IdSeleccionado) + ");");
            
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

        private void btnAgregarMatera_Click(object sender, EventArgs e)
        {
            VA.txtPrecioOrdn.Text = Convert.ToString(Convert.ToDouble(VA.txtPrecioOrdn.Text) + Convert.ToDouble(lblTotalLona.Text) + Convert.ToDouble(lblTotalSd.Text) + Convert.ToDouble(lblTotalRecip.Text));
            //Define la cadena para agregar la materia de la orden, asi esta cadena se actualizara cada ves que se le de clic al boton agregar materia prima y solo se guardara en la base de datos cuando se le da clic al boton guardar
            if (checkBSuadaer.Checked == true && Convert.ToInt16(lblID.Text) >= 1)
            {
                try
                {
                    Convert.ToInt16(txtCantidadSd.Text);
                    Ventana_Actualizar.CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`) from Ordenes), '" + Convert.ToInt16(lblID.Text) + "', '" + Convert.ToInt16(txtCantidadSd.Text) + "');");
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
                    Ventana_Actualizar.CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`)  from Ordenes), '" + Convert.ToInt16(lblLunaselect.Text) + "', '" + M2TotalLona + "');");
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
                    Ventana_Actualizar.CAdenas_Materias.Add("INSERT INTO `frerama2`.`materia_orden` (`Id_ordenes`,`Id_almacen_materia`, `Cantidad`) VALUES((Select max(`id_orden`) from Ordenes), '" + Convert.ToInt16(lblTazaSelect.Text) + "', '" + Convert.ToInt16(txtCAntidad.Text) + "');");
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique la cantidad de Recipientes");

                }

            }
        }
    }
}
