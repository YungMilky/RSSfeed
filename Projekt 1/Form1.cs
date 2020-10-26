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
            uppdateringsFrekvens();
            uppdateraPodcastLista(); 
        }

        private void uppdateraPodcastLista() //går inte att välja när det subitems - kanske får ändra? 
        {
            lwAvsnitt.Items.Clear();
            foreach (var item in podcastController.HamtaAllaPodcasts())
            {
                if (item != null)
                {
                    ListViewItem newList = new ListViewItem(item.Namn);
                    newList.SubItems.Add("Antalet avsnitt");//skriv in hur många avsnitt det finns
                    newList.SubItems.Add(item.UppdateringsFrekvens.ToString());
                    newList.SubItems.Add(item.Kategori);
                    lwAvsnitt.Items.Add(newList);
                    lwAvsnitt.FullRowSelect = true;
                }

            }
            cbKategori.SelectedIndex = 0;
        }

        private void uppdateraKategoriLista()
        {
            lbKategorier.Items.Clear();
            cbKategori.Items.Clear(); 
            foreach (var item in kategoriController.HamtaAllaKategorier())
            {
                if (item != null)
                {
                    lbKategorier.Items.Add(item.Titel);
                    cbKategori.Items.Add(item.Titel);
                }
            }
            cbKategori.SelectedIndex = 0;
        }

        private void uppdateringsFrekvens()
        {
            cbFrekvens.Items.Add("10");
            cbFrekvens.Items.Add("30");
            cbFrekvens.Items.Add("60");
            cbFrekvens.SelectedIndex = 0; 
        }

        private void btnLaggTill1_Click(object sender, EventArgs e)
        {
            podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, Convert.ToInt32(cbFrekvens.SelectedItem), cbKategori.SelectedItem.ToString());
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

        private void btnSpara2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaBort1_Click(object sender, EventArgs e)
        {
            string titel = lwAvsnitt.SelectedItems[0].Text;
            podcastController.TaBortPodcast(titel);
                uppdateraPodcastLista(); //funkar inte
        }

        private void btnSpara2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
