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
    public partial class VtnMenu : Form
    {
        public VtnMenu()
        {
            InitializeComponent();
        }

        private void VtnMenu_Load(object sender, EventArgs e) 
        {
            contacto.Text = "Contáctanos";
            fecha.Text = DateTime.Now.ToLongDateString();
            contacto.Links.Add(0, 0, "https://www.facebook.com/daniel.gonzaleztalamantes"); //Direccion de contacto
        }


        private void Facebook_Click(object sender, EventArgs e) //Redireccionar a facebook
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/ImprentaFrerama2000/");
        }

        private void Twitter_Click(object sender, EventArgs e) //Redireccionar a twitter
        {
            System.Diagnostics.Process.Start("https://twitter.com/frerama2000");
        }

        private void Contacto_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) //Iniciar proceso de linklabel para contacto Punto sur
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Calculadora_Click(object sender, EventArgs e) //Abrir calculadora del sistema
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
