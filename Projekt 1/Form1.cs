using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Controller;
using BL.Validator;
using FluentValidation.Results;

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

        private void uppdateraPodcastLista() 
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
            try 
            {
                cbKategori.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
            
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

            try 
            { 
                cbKategori.SelectedIndex = 0; 
            }
            catch (ArgumentOutOfRangeException)
            {

            }
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
            //konvertera user input av frekvens till int32 och tilldela värdet till frek
            Int32.TryParse(cbFrekvens.Text.ToString(), out int frek);

            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Namn", txtNamn.Text },
                { "URL", txtURL.Text },
                { "Uppdateringsfrekvens", frek },
                { "Kategori", cbKategori.Text.ToString() }
            };

            InputValidator validator = new InputValidator();
            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                podcastController.SkapaPodcastObjekt(userInput);
            } else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLaggTill2_Click(object sender, EventArgs e)
        {

            kategoriController.SkapaKategoritObjekt(txtKategori.Text);
            uppdateraKategoriLista();
            txtKategori.Text = "";
        }

        private void btnTaBort2_Click(object sender, EventArgs e)
        {
            if (lbKategorier.SelectedItems.Count == 1)
            {
                string titel = lbKategorier.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort kategorin " + titel + " och alla tillhörande podcasts?", "Varning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kategoriController.TaBortKategori(lbKategorier.SelectedItem.ToString());
                    uppdateraKategoriLista();
                    txtKategori.Text = ""; 
                }
                else
                {

                }
            }
        }


        private void btnSpara2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTaBort1_Click(object sender, EventArgs e)
        {
            if (lwAvsnitt.SelectedItems.Count == 1)
            {
                string titel = lwAvsnitt.SelectedItems[0].Text;
                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort podcasten " + titel + "?", "Varning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    podcastController.TaBortPodcast(titel);
                    uppdateraPodcastLista();
                }
                else
                {

                }
            }
        }

        private void btnSpara2_Click_1(object sender, EventArgs e)
        {

        }

        private void lwAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
