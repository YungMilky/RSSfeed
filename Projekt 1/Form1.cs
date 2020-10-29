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
using BL.Controller;
using BL.Validator;
using FluentValidation.Results;

namespace Projekt_1
{
    public partial class Podcast : Form
    {
        PodcastController podcastController;
        KategoriController kategoriController;

        public Podcast()
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
            podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, Convert.ToInt32(cbFrekvens.SelectedItem), cbKategori.SelectedItem.ToString());
            uppdateraPodcastLista();
        }

        private void btnLaggTill2_Click(object sender, EventArgs e)
        {
            kategoriController.SkapaKategoritObjekt(txtKategori.Text);
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
            if (lwPodcast.SelectedItems.Count == 1)
            {
                string namn = txtNamn.Text;
                string url = txtURL.Text;
                int frekvens = Convert.ToInt32(cbFrekvens.Text);
                string kategori = cbKategori.Text;
                int index = podcastController.HamtaPodcastIndex(lwPodcast.SelectedItems[0].Text);

                podcastController.UppdateraPodcast(namn, url, frekvens, kategori, index);
                uppdateraPodcastLista();
                txtNamn.Text = "";
                txtURL.Text = "";
            }
            else
            {
                MessageBox.Show("Vänligen välj en podcast i listan.");
            }
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
        {
            if (lbKategorier.SelectedItems.Count == 1)
            {
                string namn = txtKategori.Text;
                int index = kategoriController.HamtaKategoriIndex(lbKategorier.SelectedItem.ToString());
                kategoriController.UppdateraKategoriLista(lbKategorier.SelectedItem.ToString(), namn, index);
                uppdateraKategoriLista();
                uppdateraPodcastLista(); 
                txtKategori.Text = "";
            }
            else
            {
                MessageBox.Show("Vänligen välj en kategori i listan.");
            }
        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {
            btnLaggTillKategori.Enabled = string.IsNullOrWhiteSpace(txtKategori.Text) ? false : true;
        }

        private void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, Convert.ToInt32(cbFrekvens.SelectedItem), cbKategori.SelectedItem.ToString());
            uppdateraPodcastLista();
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
        {
            if (lbKategorier.SelectedItems.Count == 1)
            {
                string titel = txtKategori.Text;
                DialogResult dialogResult = MessageBox.Show("Är du säker på att du vill ta bort kategorin " + titel + " och alla tillhörande podcasts?", "Varning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    kategoriController.TaBortKategori(titel);
                    uppdateraKategoriLista();
                    uppdateraPodcastLista();
                    txtKategori.Clear();
                }
            }
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            if (lwPodcast.SelectedItems.Count == 1)
            {
                string titel = lwPodcast.SelectedItems[0].Text;
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

        private void btnFiltrera_Click(object sender, EventArgs e)
        {
            lwPodcast.Items.Clear();
            foreach (var item in podcastController.HamtaAllaPodcasts())
            {
                if (item.Kategori.Equals(lbKategorier.SelectedItem.ToString()))
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
    }
}
