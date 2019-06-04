using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_01.Formas_Vtn_sec
{
    public partial class VentasHoycs : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        public VentasHoycs()
        {
            InitializeComponent();
        }

        private void Tabla_VentasHoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void VentasHoycs_Load(object sender, EventArgs e)
        {
            Tabla_VentasHoy.DataSource = bd.SelectDataTable ("SELECT `frerama`.`productos`.`nombre` AS `nombrep`,`frerama`.`productos`.`detalles` AS `detallesp`,`frerama`.`productos`.`precio_venta` AS `precio_ventap`, `frerama`.`productos`.`Stock` AS `Stockp`,`frerama`.`cestados`.`Estado` AS `Estadop`FROm(`frerama`.`cestados`right JOIN `frerama`.`productos` ON((`frerama`.`cestados`.`idEstados` = `frerama`.`productos`.`Id_Estado_cEstados`))); ");
        }
    }
}
