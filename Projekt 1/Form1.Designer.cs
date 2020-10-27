namespace Projekt_1
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
            this.SuspendLayout();
            // 
            // lwPodcast
            // 
            this.lwPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namn,
            this.avsnitt,
            this.frekvens,
            this.kategori});
<<<<<<< HEAD
            this.lwAvsnitt.HideSelection = false;
            this.lwAvsnitt.Location = new System.Drawing.Point(28, 40);
            this.lwAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.lwAvsnitt.Name = "lwAvsnitt";
            this.lwAvsnitt.Size = new System.Drawing.Size(441, 131);
            this.lwAvsnitt.TabIndex = 1;
            this.lwAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lwAvsnitt.View = System.Windows.Forms.View.Details;
            this.lwAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lwAvsnitt_SelectedIndexChanged);
            // 
            // avsnitt
            // 
            this.avsnitt.Text = "Avsnitt";
=======
            this.lwPodcast.HideSelection = false;
            this.lwPodcast.Location = new System.Drawing.Point(62, 80);
            this.lwPodcast.Name = "lwPodcast";
            this.lwPodcast.Size = new System.Drawing.Size(878, 249);
            this.lwPodcast.TabIndex = 1;
            this.lwPodcast.UseCompatibleStateImageBehavior = false;
            this.lwPodcast.View = System.Windows.Forms.View.Details;
            this.lwPodcast.SelectedIndexChanged += new System.EventHandler(this.lwPodcast_SelectedIndexChanged);
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
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
            this.txtURL.Location = new System.Drawing.Point(28, 202);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(128, 20);
            this.txtURL.TabIndex = 2;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(987, 71);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(69, 13);
            this.lblKategorier.TabIndex = 4;
            this.lblKategorier.Text = "Kategorier:";
            // 
<<<<<<< HEAD
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(28, 297);
            this.listView3.Margin = new System.Windows.Forms.Padding(2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(441, 131);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Avsnitt";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Namn";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Frekvens";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kategori";
            // 
=======
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(25, 187);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(36, 13);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL:";
            this.lblURL.UseWaitCursor = true;
            // 
            // lblUppdateringsFrekvens
            // 
            this.lblUppdateringsFrekvens.AutoSize = true;
            this.lblUppdateringsFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdateringsFrekvens.Location = new System.Drawing.Point(182, 187);
            this.lblUppdateringsFrekvens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUppdateringsFrekvens.Name = "lblUppdateringsFrekvens";
            this.lblUppdateringsFrekvens.Size = new System.Drawing.Size(135, 13);
            this.lblUppdateringsFrekvens.TabIndex = 7;
            this.lblUppdateringsFrekvens.Text = "Uppdateringsfrekvens:";
            this.lblUppdateringsFrekvens.UseWaitCursor = true;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(664, 360);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(58, 13);
            this.lblKategori.TabIndex = 8;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.UseWaitCursor = true;
            // 
<<<<<<< HEAD
            // btnLaggTill1
            // 
            this.btnLaggTill1.Location = new System.Drawing.Point(260, 253);
            this.btnLaggTill1.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaggTill1.Name = "btnLaggTill1";
            this.btnLaggTill1.Size = new System.Drawing.Size(59, 19);
            this.btnLaggTill1.TabIndex = 9;
            this.btnLaggTill1.Text = "Lägg till";
            this.btnLaggTill1.UseVisualStyleBackColor = true;
            this.btnLaggTill1.Click += new System.EventHandler(this.btnLaggTill1_Click);
            // 
            // btnSpara1
            // 
            this.btnSpara1.Location = new System.Drawing.Point(334, 253);
            this.btnSpara1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara1.Name = "btnSpara1";
            this.btnSpara1.Size = new System.Drawing.Size(59, 19);
            this.btnSpara1.TabIndex = 10;
            this.btnSpara1.Text = "Spara";
            this.btnSpara1.UseVisualStyleBackColor = true;
            this.btnSpara1.Click += new System.EventHandler(this.btnSpara2_Click);
            // 
            // btnTaBort1
            // 
            this.btnTaBort1.Location = new System.Drawing.Point(408, 253);
            this.btnTaBort1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort1.Name = "btnTaBort1";
            this.btnTaBort1.Size = new System.Drawing.Size(59, 19);
            this.btnTaBort1.TabIndex = 11;
            this.btnTaBort1.Text = "Ta bort";
            this.btnTaBort1.UseVisualStyleBackColor = true;
            this.btnTaBort1.Click += new System.EventHandler(this.btnTaBort1_Click);
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(744, 243);
            this.btnTaBort2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(59, 19);
            this.btnTaBort2.TabIndex = 14;
            this.btnTaBort2.Text = "Ta bort";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            this.btnTaBort2.Click += new System.EventHandler(this.btnTaBort2_Click);
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(664, 243);
            this.btnSpara2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(59, 19);
            this.btnSpara2.TabIndex = 13;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            this.btnSpara2.Click += new System.EventHandler(this.btnSpara2_Click_1);
            // 
            // btnLaggTill2
            // 
            this.btnLaggTill2.Location = new System.Drawing.Point(588, 243);
            this.btnLaggTill2.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaggTill2.Name = "btnLaggTill2";
            this.btnLaggTill2.Size = new System.Drawing.Size(59, 19);
            this.btnLaggTill2.TabIndex = 12;
            this.btnLaggTill2.Text = "Lägg till";
            this.btnLaggTill2.UseVisualStyleBackColor = true;
            this.btnLaggTill2.Click += new System.EventHandler(this.btnLaggTill2_Click);
=======
            // btnLaggTillPodcast
            // 
            this.btnLaggTillPodcast.Location = new System.Drawing.Point(520, 486);
            this.btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            this.btnLaggTillPodcast.Size = new System.Drawing.Size(118, 37);
            this.btnLaggTillPodcast.TabIndex = 9;
            this.btnLaggTillPodcast.Text = "Lägg till";
            this.btnLaggTillPodcast.UseVisualStyleBackColor = true;
            this.btnLaggTillPodcast.Click += new System.EventHandler(this.btnLaggTillPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(669, 486);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(118, 37);
            this.btnSparaPodcast.TabIndex = 10;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            this.btnSparaPodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(815, 486);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(118, 37);
            this.btnTaBortPodcast.TabIndex = 11;
            this.btnTaBortPodcast.Text = "Ta bort";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBort1_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1487, 468);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(118, 37);
            this.btnTaBortKategori.TabIndex = 14;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBort2_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(1329, 468);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(118, 37);
            this.btnSparaKategori.TabIndex = 13;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Location = new System.Drawing.Point(1177, 468);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(118, 37);
            this.btnLaggTillKategori.TabIndex = 12;
            this.btnLaggTillKategori.Text = "Lägg till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTill2_Click);
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
            // 
            // cbFrekvens
            // 
            this.cbFrekvens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrekvens.FormattingEnabled = true;
            this.cbFrekvens.Location = new System.Drawing.Point(369, 388);
            this.cbFrekvens.Name = "cbFrekvens";
            this.cbFrekvens.Size = new System.Drawing.Size(244, 33);
            this.cbFrekvens.TabIndex = 15;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(669, 388);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(124, 21);
            this.cbKategori.TabIndex = 16;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
<<<<<<< HEAD
            // avsnittsBeskrivningTextruta
            // 
            this.avsnittsBeskrivningTextruta.Location = new System.Drawing.Point(477, 329);
            this.avsnittsBeskrivningTextruta.Multiline = true;
            this.avsnittsBeskrivningTextruta.Name = "avsnittsBeskrivningTextruta";
            this.avsnittsBeskrivningTextruta.ReadOnly = true;
            this.avsnittsBeskrivningTextruta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.avsnittsBeskrivningTextruta.Size = new System.Drawing.Size(361, 100);
            this.avsnittsBeskrivningTextruta.TabIndex = 27;
            // 
=======
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
            // lblAvsnittsbeskrivning
            // 
            this.lblAvsnittsbeskrivning.AutoSize = true;
            this.lblAvsnittsbeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblAvsnittsbeskrivning.Location = new System.Drawing.Point(474, 297);
            this.lblAvsnittsbeskrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
=======
            this.lblAvsnittsbeskrivning.Location = new System.Drawing.Point(949, 528);
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
            this.lblAvsnittsbeskrivning.Name = "lblAvsnittsbeskrivning";
            this.lblAvsnittsbeskrivning.Size = new System.Drawing.Size(121, 13);
            this.lblAvsnittsbeskrivning.TabIndex = 28;
            this.lblAvsnittsbeskrivning.Text = "Avsnittsbeskrivning:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(588, 202);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(224, 20);
            this.txtKategori.TabIndex = 29;
            this.txtKategori.TextChanged += new System.EventHandler(this.txtKategori_TextChanged);
            // 
            // lblKategori2
            // 
            this.lblKategori2.AutoSize = true;
            this.lblKategori2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori2.Location = new System.Drawing.Point(586, 180);
            this.lblKategori2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori2.Name = "lblKategori2";
            this.lblKategori2.Size = new System.Drawing.Size(58, 13);
            this.lblKategori2.TabIndex = 30;
            this.lblKategori2.Text = "Kategori:";
            this.lblKategori2.UseWaitCursor = true;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(28, 275);
            this.lblAvsnitt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(54, 13);
            this.lblAvsnitt.TabIndex = 31;
            this.lblAvsnitt.Text = "Avsnitt: ";
            this.lblAvsnitt.UseWaitCursor = true;
            // 
            // lblPodcastNamn
            // 
            this.lblPodcastNamn.AutoSize = true;
            this.lblPodcastNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcastNamn.Location = new System.Drawing.Point(25, 231);
            this.lblPodcastNamn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPodcastNamn.Name = "lblPodcastNamn";
            this.lblPodcastNamn.Size = new System.Drawing.Size(43, 13);
            this.lblPodcastNamn.TabIndex = 32;
            this.lblPodcastNamn.Text = "Namn:";
            this.lblPodcastNamn.UseWaitCursor = true;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(28, 245);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(128, 20);
            this.txtNamn.TabIndex = 33;
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.ItemHeight = 25;
            this.lbKategorier.Location = new System.Drawing.Point(992, 100);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(629, 229);
            this.lbKategorier.TabIndex = 34;
            this.lbKategorier.SelectedIndexChanged += new System.EventHandler(this.lbKategorier_SelectedIndexChanged);
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.FormattingEnabled = true;
            this.lbAvsnitt.ItemHeight = 25;
            this.lbAvsnitt.Location = new System.Drawing.Point(62, 572);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(871, 254);
            this.lbAvsnitt.TabIndex = 35;
            this.lbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbAvsnitt_SelectedIndexChanged_1);
            // 
            // txtAvsnittsBeskrivning
            // 
            this.txtAvsnittsBeskrivning.Location = new System.Drawing.Point(954, 572);
            this.txtAvsnittsBeskrivning.Name = "txtAvsnittsBeskrivning";
            this.txtAvsnittsBeskrivning.ReadOnly = true;
            this.txtAvsnittsBeskrivning.Size = new System.Drawing.Size(667, 254);
            this.txtAvsnittsBeskrivning.TabIndex = 36;
            this.txtAvsnittsBeskrivning.Text = "";
            // 
            // Podcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 866);
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
<<<<<<< HEAD
            this.Controls.Add(this.lwAvsnitt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
=======
            this.Controls.Add(this.lwPodcast);
            this.Name = "Podcast";
            this.Text = "Podcast RSS Feed";
>>>>>>> 8c7df9574f7d169d4cf99bb21b87584c46522503
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
    }
}

