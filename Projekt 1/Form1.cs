﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BL.Controller;
using BL.Validator;
using FluentValidation.Results;

namespace Projekt_1
{
    public partial class Podcast : Form
    {
        private Timer podcastTimer = new Timer();

        PodcastController podcastController;
        KategoriController kategoriController;
        AvsnittController avsnittController;

        InputValidator validator;

        public Podcast()
        {
            podcastTimer.Interval = 1000;
            podcastTimer.Tick += PodcastTimer_Tick;
            podcastTimer.Start();

            InitializeComponent();
            validator = new InputValidator();
            podcastController = new PodcastController();
            kategoriController = new KategoriController();
            avsnittController = new AvsnittController();
            uppdateraKategoriLista();
            uppdateringsFrekvens();
            uppdateraPodcastLista();
        }

        private void uppdateraPodcastLista()
        {
            lwPodcast.Items.Clear();
            foreach (var item in podcastController.HamtaAllaPodcasts())
            {
                if (item != null)
                {
                    string antalAvsnitt = item.AvsnittsLista.Count.ToString(); 

                    ListViewItem newList = new ListViewItem(item.Namn);
                    newList.SubItems.Add(antalAvsnitt);
                    newList.SubItems.Add(item.UppdateringsFrekvens.ToString());
                    newList.SubItems.Add(item.Kategori);
                    lwPodcast.Items.Add(newList);
                    lwPodcast.FullRowSelect = true;
                }
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
        }

        async Task UseDelay()
        {
            await Task.Delay(100);
            uppdateraPodcastLista();
        }

        private void clearTextFaltPodcast()
        {
            txtNamn.Clear();
            txtURL.Clear();
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
            string namn = txtNamn.Text ?? "";
            string URL = validator.AutoFormatURL(txtURL.Text) ?? "";
            string Kategori = cbKategori.SelectedItem?.ToString() ?? "";

            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Namn", namn },
                { "URL", URL },
                { "Uppdateringsfrekvens", Convert.ToInt32(cbFrekvens.SelectedItem) },
                { "Kategori", Kategori }
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                podcastController.SkapaPodcastObjekt(userInput);
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            uppdateraPodcastLista();
        }

        private void btnLaggTill2_Click(object sender, EventArgs e)
        {
            string kategoriNamn = txtKategori.Text ?? "";
            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "KatNamn", kategoriNamn },
                { "Preexisting categories", kategoriController.HamtaAllaKategorier() }
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                kategoriController.SkapaKategoritObjekt(txtKategori.Text);
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            uppdateraKategoriLista();
            txtKategori.Clear();
        }

        private void lbAvsnitt_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            txtAvsnittsBeskrivning.Clear();
            if (lbAvsnitt.SelectedItems.Count == 1)
            {
                var valtAvsnitt = lbAvsnitt.SelectedItems[0];
                foreach (var item in podcastController.HamtaAllaPodcasts())
                {
                    foreach (var ettAvsnitt in item.AvsnittsLista)
                    {
                        if (ettAvsnitt.Titel.Equals(valtAvsnitt))
                        {
                            txtAvsnittsBeskrivning.Text = (ettAvsnitt.Beskrivning);
                        }
                    }
                }
            }
        }

        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text ?? "";
            string URL = validator.AutoFormatURL(txtURL.Text) ?? "";
            string Kategori = cbKategori.SelectedItem?.ToString() ?? "";

            var isSelected = lwPodcast.SelectedItems.Count > 0; //0 == nothing selected
#nullable enable
            string? Index = isSelected ? lwPodcast.SelectedItems[0].Text : null;
#nullable disable
            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Namn", namn },
                { "URL", URL },
                { "Uppdateringsfrekvens", Convert.ToInt32(cbFrekvens.SelectedItem) },
                { "Kategori", Kategori },
                { "Index", podcastController.HamtaPodcastIndex(Index) }
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                podcastController.UppdateraPodcast(userInput);
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                clearTextFaltPodcast();
            _ = UseDelay();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            btnLaggTillPodcast.Enabled = string.IsNullOrWhiteSpace(txtURL.Text) ? false : true;
        }

        private void lbKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((lbKategorier.SelectedItems.Count == 1))
            {
                string namn = lbKategorier.SelectedItem.ToString();
                txtKategori.Text = namn;
                btnLaggTillKategori.Enabled = false;
                btnSparaKategori.Enabled = true;
                btnTaBortKategori.Enabled = true;
                txtURL.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori i listan.");
            }
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
            //namnet på gamla kategorin kommer tillbaka när man lagt till en ny podcast. Funkar om man startar om programmet.
        {
            var isSelected = lbKategorier.SelectedItems.Count > 0;
            string namn = isSelected ? txtKategori.Text : "";

            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Cat to be saved", namn }
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                int index = kategoriController.HamtaKategoriIndex(lbKategorier.SelectedItem.ToString());
                kategoriController.UppdateraKategoriLista(lbKategorier.SelectedItem.ToString(), namn, index);
                uppdateraKategoriLista();
                uppdateraPodcastLista();
                txtKategori.Text = "";
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {
            btnLaggTillKategori.Enabled = string.IsNullOrWhiteSpace(txtKategori.Text) ? false : true;
        }

        private void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text ?? "";
            string URL = validator.AutoFormatURL(txtURL.Text) ?? "";
            string Kategori = cbKategori.SelectedItem?.ToString() ?? "";

            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Namn", namn},
                { "URL", URL },
                { "Uppdateringsfrekvens", Convert.ToInt32(cbFrekvens.SelectedItem) },
                { "Kategori", Kategori }
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                podcastController.SkapaPodcastObjekt(userInput);
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            uppdateraPodcastLista();
            _ = UseDelay();
            clearTextFaltPodcast();
        }

        private void lwPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (lwPodcast.SelectedItems.Count == 1)
                {
                    string namn = lwPodcast.SelectedItems[0].Text;
                    txtNamn.Text = namn;
                    txtURL.Text = podcastController.HamtaUrl(namn);
                    cbKategori.SelectedItem = lwPodcast.SelectedItems[0].SubItems[3].Text;
                    cbFrekvens.SelectedItem = lwPodcast.SelectedItems[0].SubItems[2].Text;
                    btnLaggTillPodcast.Enabled = false;
                    btnSparaPodcast.Enabled = true;
                    btnTaBortPodcast.Enabled = true;
                    txtURL.Enabled = true;
                }

                lbAvsnitt.Items.Clear();
                if (lwPodcast.SelectedItems.Count == 1)
                {
                    var selectedEpisode = lwPodcast.SelectedItems[0].Text;

                    foreach (var item in podcastController.HamtaAllaPodcasts())
                    {
                        if (item.Namn.Equals(selectedEpisode))
                        {
                            foreach (var avsnitt in item.AvsnittsLista)
                            {
                                lbAvsnitt.Items.Add(avsnitt.Titel);
                            }
                        }
                    }
                }
            }
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e) 
            //podcasten i en viss kategori kommer tillbaka när man skapar en ny podcast. Funkar om man startar om programmet.
        {
            var isSelected = lbKategorier.SelectedItems.Count > 0;
            string kategori = isSelected ? txtKategori.Text : "";

            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "SelectedCat", kategori }
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort kategorin " + kategori + " och alla tillhörande podcasts?", "Varning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kategoriController.TaBortKategori(kategori);
                    uppdateraKategoriLista();
                    uppdateraPodcastLista();
                    txtKategori.Clear();
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            var isSelected = lwPodcast.SelectedItems.Count > 0;
            string namn = isSelected ? lwPodcast.SelectedItems[0].Text : "";
            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Podcast to remove", namn}
            };

            ValidationResult results = validator.Validate(userInput);
            string errorMessage = validator.LogValidationErrors(results);

            if (string.IsNullOrEmpty(errorMessage))
            {
                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort podcasten " + namn + "?", "Varning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    podcastController.TaBortPodcast(namn);
                    uppdateraPodcastLista();
                }
            }
            else
            {
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearTextFaltPodcast();
        }

        private void btnFiltrera_Click(object sender, EventArgs e)
        {
            lwPodcast.Items.Clear();
            var isSelected = lbKategorier.SelectedItems.Count > 0;
#nullable enable
            string? selectedCategory = isSelected ? lbKategorier.SelectedItem.ToString() : null;
#nullable disable

            foreach (var item in podcastController.HamtaAllaPodcasts())
            {
                if (item.Kategori.Equals(selectedCategory))
                {
                        string antalAvsnitt = item.AvsnittsLista.Count.ToString();

                        ListViewItem newList = new ListViewItem(item.Namn);
                        newList.SubItems.Add(antalAvsnitt);
                        newList.SubItems.Add(item.UppdateringsFrekvens.ToString());
                        newList.SubItems.Add(item.Kategori);
                        lwPodcast.Items.Add(newList);
                        lwPodcast.FullRowSelect = true;
                }
            }
        }

        private void btnVisaAllaPodcasts_Click(object sender, EventArgs e)
        {
            uppdateraPodcastLista(); 
        }
        private void PodcastTimer_Tick(object sender, EventArgs e)
        {
            foreach (var pod in podcastController.HamtaAllaPodcasts())
            {
                if (pod.NeedsUpdate)
                {
                    int index = podcastController.HamtaPodcastIndex(pod.Namn);
                    podcastController.UppdateraPodcast(pod.Namn, pod.URL, pod.UppdateringsFrekvens, pod.Kategori, index, pod.NextUpdate);
                    pod.Uppdatera();

                    for (int i = 0; i < lwPodcast.Items.Count; i++)
                    {
                        if (pod.Namn.Equals(lwPodcast.Items[i].SubItems[0].Text))
                        {
                            var antalAvsnitt = Convert.ToString(pod.AvsnittsLista.Count());
                            lwPodcast.Items[i].SubItems[1].Text = antalAvsnitt;
                        }
                    }
                }
            }
        }
    }
}
