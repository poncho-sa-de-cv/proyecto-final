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
         
        private void gridProducProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoProduc_Click(object sender, EventArgs e)
        {

            NuevoProducto vtnNuevoProduc = new NuevoProducto();
            vtnNuevoProduc.ShowDialog();
            
        }
        
    }
}
