namespace Projekt_1
{
    partial class Form1
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
            this.lwAvsnitt = new System.Windows.Forms.ListView();
            this.avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lwKategorier = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKategorier = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUppdateringsFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnLaggTill1 = new System.Windows.Forms.Button();
            this.btnSpara1 = new System.Windows.Forms.Button();
            this.btnTaBort1 = new System.Windows.Forms.Button();
            this.btnTaBort2 = new System.Windows.Forms.Button();
            this.btnSpara2 = new System.Windows.Forms.Button();
            this.btnLaggTill2 = new System.Windows.Forms.Button();
            this.cbUppdFrekvens = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.avsnittsBeskrivningTextruta = new System.Windows.Forms.TextBox();
            this.lblAvsnittsbeskrivning = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblKategori2 = new System.Windows.Forms.Label();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lblPodcastNamn = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtFrekvens = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lwAvsnitt
            // 
            this.lwAvsnitt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.avsnitt,
            this.namn,
            this.frekvens,
            this.kategori});
            this.lwAvsnitt.HideSelection = false;
            this.lwAvsnitt.Location = new System.Drawing.Point(28, 40);
            this.lwAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.lwAvsnitt.Name = "lwAvsnitt";
            this.lwAvsnitt.Size = new System.Drawing.Size(441, 131);
            this.lwAvsnitt.TabIndex = 1;
            this.lwAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lwAvsnitt.View = System.Windows.Forms.View.Details;
            // 
            // avsnitt
            // 
            this.avsnitt.Text = "Avsnitt";
            // 
            // namn
            // 
            this.namn.Text = "Namn";
            // 
            // frekvens
            // 
            this.frekvens.Text = "Frekvens";
            // 
            // kategori
            // 
            this.kategori.Text = "Kategori";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(28, 202);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(128, 20);
            this.txtURL.TabIndex = 2;
            // 
            // lwKategorier
            // 
            this.lwKategorier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lwKategorier.HideSelection = false;
            this.lwKategorier.Location = new System.Drawing.Point(493, 56);
            this.lwKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.lwKategorier.Name = "lwKategorier";
            this.lwKategorier.Size = new System.Drawing.Size(314, 115);
            this.lwKategorier.TabIndex = 3;
            this.lwKategorier.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Avsnitt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(494, 40);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(69, 13);
            this.lblKategorier.TabIndex = 4;
            this.lblKategorier.Text = "Kategorier:";
            // 
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
            this.lblKategori.Location = new System.Drawing.Point(340, 187);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(58, 13);
            this.lblKategori.TabIndex = 8;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.UseWaitCursor = true;
            // 
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
            // 
            // cbUppdFrekvens
            // 
            this.cbUppdFrekvens.FormattingEnabled = true;
            this.cbUppdFrekvens.Location = new System.Drawing.Point(532, 273);
            this.cbUppdFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.cbUppdFrekvens.Name = "cbUppdFrekvens";
            this.cbUppdFrekvens.Size = new System.Drawing.Size(124, 21);
            this.cbUppdFrekvens.TabIndex = 15;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(692, 273);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(124, 21);
            this.cbKategori.TabIndex = 16;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
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
            // lblAvsnittsbeskrivning
            // 
            this.lblAvsnittsbeskrivning.AutoSize = true;
            this.lblAvsnittsbeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittsbeskrivning.Location = new System.Drawing.Point(474, 297);
            this.lblAvsnittsbeskrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            // txtFrekvens
            // 
            this.txtFrekvens.Location = new System.Drawing.Point(181, 206);
            this.txtFrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrekvens.Name = "txtFrekvens";
            this.txtFrekvens.Size = new System.Drawing.Size(128, 20);
            this.txtFrekvens.TabIndex = 34;
            this.txtFrekvens.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(341, 206);
            this.txtKat.Margin = new System.Windows.Forms.Padding(2);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(128, 20);
            this.txtKat.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtFrekvens);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblPodcastNamn);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.lblKategori2);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lblAvsnittsbeskrivning);
            this.Controls.Add(this.avsnittsBeskrivningTextruta);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbUppdFrekvens);
            this.Controls.Add(this.btnTaBort2);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnLaggTill2);
            this.Controls.Add(this.btnTaBort1);
            this.Controls.Add(this.btnSpara1);
            this.Controls.Add(this.btnLaggTill1);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdateringsFrekvens);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lwKategorier);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lwAvsnitt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwAvsnitt;
        private System.Windows.Forms.ColumnHeader avsnitt;
        private System.Windows.Forms.ColumnHeader namn;
        private System.Windows.Forms.ColumnHeader frekvens;
        private System.Windows.Forms.ColumnHeader kategori;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ListView lwKategorier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblUppdateringsFrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnLaggTill1;
        private System.Windows.Forms.Button btnSpara1;
        private System.Windows.Forms.Button btnTaBort1;
        private System.Windows.Forms.Button btnTaBort2;
        private System.Windows.Forms.Button btnSpara2;
        private System.Windows.Forms.Button btnLaggTill2;
        private System.Windows.Forms.ComboBox cbUppdFrekvens;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox avsnittsBeskrivningTextruta;
        private System.Windows.Forms.Label lblAvsnittsbeskrivning;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblKategori2;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.Label lblPodcastNamn;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtFrekvens;
        private System.Windows.Forms.TextBox txtKat;
    }
}

