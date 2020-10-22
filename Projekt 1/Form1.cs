using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Controller;

namespace Projekt_1
{
    public partial class Form1 : Form
    {
        PodcastController podcastController; 
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
        }

        private void btnLaggTill1_Click(object sender, EventArgs e)
        {
            //podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, Convert.ToInt32(cbUppdFrekvens.SelectedItem), cbKategori.SelectedItem.ToString());
            //det är den övre raden som gäller, med comboboxes. Den nedre ska tas bort sen när allt funkar

            podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, Int32.Parse(textBox1.Text), textBox2.Text);
        }
    }
}
