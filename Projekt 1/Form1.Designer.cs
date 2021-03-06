﻿namespace Projekt_1
{
    partial class Podcast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lwPodcast = new System.Windows.Forms.ListView();
            this.namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUppdateringsFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnLaggTillPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.cbFrekvens = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblAvsnittsbeskrivning = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblKategori2 = new System.Windows.Forms.Label();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lblPodcastNamn = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.lbKategorier = new System.Windows.Forms.ListBox();
            this.lbAvsnitt = new System.Windows.Forms.ListBox();
            this.txtAvsnittsBeskrivning = new System.Windows.Forms.RichTextBox();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.btnFiltrera = new System.Windows.Forms.Button();
            this.btnVisaAllaPodcasts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwPodcast
            // 
            this.lwPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namn,
            this.avsnitt,
            this.frekvens,
            this.kategori});
            this.lwPodcast.HideSelection = false;
            this.lwPodcast.Location = new System.Drawing.Point(28, 75);
            this.lwPodcast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lwPodcast.Name = "lwPodcast";
            this.lwPodcast.Size = new System.Drawing.Size(706, 292);
            this.lwPodcast.TabIndex = 37;
            this.lwPodcast.UseCompatibleStateImageBehavior = false;
            this.lwPodcast.View = System.Windows.Forms.View.Details;
            this.lwPodcast.SelectedIndexChanged += new System.EventHandler(this.lwPodcast_SelectedIndexChanged);
            // 
            // namn
            // 
            this.namn.Text = "Namn";
            this.namn.Width = 85;
            // 
            // avsnitt
            // 
            this.avsnitt.Text = "Avsnitt";
            this.avsnitt.Width = 85;
            // 
            // frekvens
            // 
            this.frekvens.Text = "Frekvens";
            this.frekvens.Width = 85;
            // 
            // kategori
            // 
            this.kategori.Text = "Kategori";
            this.kategori.Width = 85;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(40, 415);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(252, 31);
            this.txtURL.TabIndex = 2;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(768, 38);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(128, 25);
            this.lblKategorier.TabIndex = 4;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(36, 375);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(64, 25);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL:";
            this.lblURL.UseWaitCursor = true;
            // 
            // lblUppdateringsFrekvens
            // 
            this.lblUppdateringsFrekvens.AutoSize = true;
            this.lblUppdateringsFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdateringsFrekvens.Location = new System.Drawing.Point(308, 377);
            this.lblUppdateringsFrekvens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUppdateringsFrekvens.Name = "lblUppdateringsFrekvens";
            this.lblUppdateringsFrekvens.Size = new System.Drawing.Size(249, 25);
            this.lblUppdateringsFrekvens.TabIndex = 7;
            this.lblUppdateringsFrekvens.Text = "Uppdateringsfrekvens:";
            this.lblUppdateringsFrekvens.UseWaitCursor = true;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(568, 377);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(107, 25);
            this.lblKategori.TabIndex = 8;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.UseWaitCursor = true;
            // 
            // btnLaggTillPodcast
            // 
            this.btnLaggTillPodcast.Location = new System.Drawing.Point(368, 487);
            this.btnLaggTillPodcast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            this.btnLaggTillPodcast.Size = new System.Drawing.Size(104, 42);
            this.btnLaggTillPodcast.TabIndex = 9;
            this.btnLaggTillPodcast.Text = "Lägg till";
            this.btnLaggTillPodcast.UseVisualStyleBackColor = true;
            this.btnLaggTillPodcast.Click += new System.EventHandler(this.btnLaggTillPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(512, 487);
            this.btnSparaPodcast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(96, 42);
            this.btnSparaPodcast.TabIndex = 10;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            this.btnSparaPodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(628, 487);
            this.btnTaBortPodcast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(104, 42);
            this.btnTaBortPodcast.TabIndex = 11;
            this.btnTaBortPodcast.Text = "Ta bort";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1208, 488);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(116, 40);
            this.btnTaBortKategori.TabIndex = 14;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(1062, 488);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(118, 42);
            this.btnSparaKategori.TabIndex = 13;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Location = new System.Drawing.Point(928, 488);
            this.btnLaggTillKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(106, 40);
            this.btnLaggTillKategori.TabIndex = 12;
            this.btnLaggTillKategori.Text = "Lägg till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTill2_Click);
            // 
            // cbFrekvens
            // 
            this.cbFrekvens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrekvens.FormattingEnabled = true;
            this.cbFrekvens.Location = new System.Drawing.Point(314, 415);
            this.cbFrekvens.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbFrekvens.Name = "cbFrekvens";
            this.cbFrekvens.Size = new System.Drawing.Size(244, 33);
            this.cbFrekvens.TabIndex = 15;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(572, 415);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(162, 33);
            this.cbKategori.TabIndex = 16;
            // 
            // lblAvsnittsbeskrivning
            // 
            this.lblAvsnittsbeskrivning.AutoSize = true;
            this.lblAvsnittsbeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittsbeskrivning.Location = new System.Drawing.Point(776, 552);
            this.lblAvsnittsbeskrivning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAvsnittsbeskrivning.Name = "lblAvsnittsbeskrivning";
            this.lblAvsnittsbeskrivning.Size = new System.Drawing.Size(224, 25);
            this.lblAvsnittsbeskrivning.TabIndex = 28;
            this.lblAvsnittsbeskrivning.Text = "Avsnittsbeskrivning:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(1016, 415);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(298, 31);
            this.txtKategori.TabIndex = 29;
            this.txtKategori.TextChanged += new System.EventHandler(this.txtKategori_TextChanged);
            // 
            // lblKategori2
            // 
            this.lblKategori2.AutoSize = true;
            this.lblKategori2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori2.Location = new System.Drawing.Point(1014, 375);
            this.lblKategori2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori2.Name = "lblKategori2";
            this.lblKategori2.Size = new System.Drawing.Size(107, 25);
            this.lblKategori2.TabIndex = 30;
            this.lblKategori2.Text = "Kategori:";
            this.lblKategori2.UseWaitCursor = true;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(24, 552);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(98, 25);
            this.lblAvsnitt.TabIndex = 31;
            this.lblAvsnitt.Text = "Avsnitt: ";
            this.lblAvsnitt.UseWaitCursor = true;
            // 
            // lblPodcastNamn
            // 
            this.lblPodcastNamn.AutoSize = true;
            this.lblPodcastNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastNamn.Location = new System.Drawing.Point(34, 471);
            this.lblPodcastNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcastNamn.Name = "lblPodcastNamn";
            this.lblPodcastNamn.Size = new System.Drawing.Size(79, 25);
            this.lblPodcastNamn.TabIndex = 32;
            this.lblPodcastNamn.Text = "Namn:";
            this.lblPodcastNamn.UseWaitCursor = true;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(40, 498);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(252, 31);
            this.txtNamn.TabIndex = 33;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 25;
            this.lbKategorier.Location = new System.Drawing.Point(782, 88);
            this.lbKategorier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(530, 279);
            this.lbKategorier.TabIndex = 34;
            this.lbKategorier.SelectedIndexChanged += new System.EventHandler(this.lbKategorier_SelectedIndexChanged);
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 25;
            this.lbAvsnitt.Location = new System.Drawing.Point(28, 588);
            this.lbAvsnitt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(706, 279);
            this.lbAvsnitt.TabIndex = 35;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged_1);
            // 
            // txtAvsnittsBeskrivning
            // 
            this.txtAvsnittsBeskrivning.Location = new System.Drawing.Point(772, 588);
            this.txtAvsnittsBeskrivning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAvsnittsBeskrivning.Name = "txtAvsnittsBeskrivning";
            this.txtAvsnittsBeskrivning.ReadOnly = true;
            this.txtAvsnittsBeskrivning.Size = new System.Drawing.Size(540, 279);
            this.txtAvsnittsBeskrivning.TabIndex = 36;
            this.txtAvsnittsBeskrivning.Text = "";
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcast.Location = new System.Drawing.Point(24, 27);
            this.lblPodcast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(104, 25);
            this.lblPodcast.TabIndex = 38;
            this.lblPodcast.Text = "Podcast:";
            // 
            // btnFiltrera
            // 
            this.btnFiltrera.Location = new System.Drawing.Point(1208, 27);
            this.btnFiltrera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFiltrera.Name = "btnFiltrera";
            this.btnFiltrera.Size = new System.Drawing.Size(106, 40);
            this.btnFiltrera.TabIndex = 39;
            this.btnFiltrera.Text = "Filtrera";
            this.btnFiltrera.UseVisualStyleBackColor = true;
            this.btnFiltrera.Click += new System.EventHandler(this.btnFiltrera_Click);
            // 
            // btnVisaAllaPodcasts
            // 
            this.btnVisaAllaPodcasts.Location = new System.Drawing.Point(976, 27);
            this.btnVisaAllaPodcasts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVisaAllaPodcasts.Name = "btnVisaAllaPodcasts";
            this.btnVisaAllaPodcasts.Size = new System.Drawing.Size(204, 40);
            this.btnVisaAllaPodcasts.TabIndex = 40;
            this.btnVisaAllaPodcasts.Text = "Visa alla podcasts";
            this.btnVisaAllaPodcasts.UseVisualStyleBackColor = true;
            this.btnVisaAllaPodcasts.Click += new System.EventHandler(this.btnVisaAllaPodcasts_Click);
            // 
            // Podcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 898);
            this.Controls.Add(this.btnVisaAllaPodcasts);
            this.Controls.Add(this.btnFiltrera);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.txtAvsnittsBeskrivning);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.lbKategorier);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblPodcastNamn);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblKategori2);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lblAvsnittsbeskrivning);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbFrekvens);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnLaggTillKategori);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnLaggTillPodcast);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdateringsFrekvens);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lwPodcast);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Podcast";
            this.Text = "Podcast RSS Feed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwPodcast;
        private System.Windows.Forms.ColumnHeader avsnitt;
        private System.Windows.Forms.ColumnHeader namn;
        private System.Windows.Forms.ColumnHeader frekvens;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblUppdateringsFrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnLaggTillPodcast;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.ComboBox cbFrekvens;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblAvsnittsbeskrivning;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblKategori2;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblPodcastNamn;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.ListBox lbKategorier;
        private System.Windows.Forms.ListBox lbAvsnitt;
        private System.Windows.Forms.RichTextBox txtAvsnittsBeskrivning;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.Button btnFiltrera;
        private System.Windows.Forms.Button btnVisaAllaPodcasts;
    }
}

