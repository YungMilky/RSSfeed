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
        KategoriController kategoriController;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            kategoriController = new KategoriController();
            uppdateraKategoriLista(); 
        }

        private void uppdateraKategoriLista()
        {
            lbKategorier.Items.Clear();
            foreach (var item in kategoriController.HamtaAllaKategorier())
            {
                if (item != null)
                {
                    lbKategorier.Items.Add(item.Titel);
                }
            }
        }

        private void uppdateraPodcastLista()
        {
            lwAvsnitt.Items.Clear();
            foreach (var items in podcastController.HamtaAllaPodcasts())
            {
                if (items != null)
                {
                    lwAvsnitt.Items.Add(items.Namn);
                }
            }
        }

        private void btnLaggTill1_Click(object sender, EventArgs e)
        {
            podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, Convert.ToInt32(cbUppdFrekvens.SelectedItem), cbKategori.SelectedItem.ToString());
            uppdateraPodcastLista();
        }

        private void btnLaggTill2_Click(object sender, EventArgs e)
        {

            kategoriController.SkapaKategoritObjekt(txtKategori.Text);
            uppdateraKategoriLista();
        }

        private void btnTaBort2_Click(object sender, EventArgs e)
        {
            kategoriController.TaBortKategori(lbKategorier.SelectedItem.ToString());
            uppdateraKategoriLista(); 
        }
    }
}
