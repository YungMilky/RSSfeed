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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.lwAvsnitt.Location = new System.Drawing.Point(55, 76);
            this.lwAvsnitt.Name = "lwAvsnitt";
            this.lwAvsnitt.Size = new System.Drawing.Size(878, 249);
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
            this.txtURL.Location = new System.Drawing.Point(55, 388);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(251, 31);
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
            this.lwKategorier.Location = new System.Drawing.Point(986, 107);
            this.lwKategorier.Name = "lwKategorier";
            this.lwKategorier.Size = new System.Drawing.Size(623, 218);
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
            this.lblKategorier.Location = new System.Drawing.Point(987, 76);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(128, 25);
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
            this.listView3.Location = new System.Drawing.Point(55, 572);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(878, 249);
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
            this.lblURL.Location = new System.Drawing.Point(50, 360);
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
            this.lblUppdateringsFrekvens.Location = new System.Drawing.Point(364, 360);
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
            this.lblKategori.Location = new System.Drawing.Point(680, 360);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(107, 25);
            this.lblKategori.TabIndex = 8;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.UseWaitCursor = true;
            // 
            // btnLaggTill1
            // 
            this.btnLaggTill1.Location = new System.Drawing.Point(520, 486);
            this.btnLaggTill1.Name = "btnLaggTill1";
            this.btnLaggTill1.Size = new System.Drawing.Size(118, 37);
            this.btnLaggTill1.TabIndex = 9;
            this.btnLaggTill1.Text = "Lägg till";
            this.btnLaggTill1.UseVisualStyleBackColor = true;
            this.btnLaggTill1.Click += new System.EventHandler(this.btnLaggTill1_Click);
            // 
            // btnSpara1
            // 
            this.btnSpara1.Location = new System.Drawing.Point(669, 486);
            this.btnSpara1.Name = "btnSpara1";
            this.btnSpara1.Size = new System.Drawing.Size(118, 37);
            this.btnSpara1.TabIndex = 10;
            this.btnSpara1.Text = "Spara";
            this.btnSpara1.UseVisualStyleBackColor = true;
            // 
            // btnTaBort1
            // 
            this.btnTaBort1.Location = new System.Drawing.Point(815, 486);
            this.btnTaBort1.Name = "btnTaBort1";
            this.btnTaBort1.Size = new System.Drawing.Size(118, 37);
            this.btnTaBort1.TabIndex = 11;
            this.btnTaBort1.Text = "Ta bort";
            this.btnTaBort1.UseVisualStyleBackColor = true;
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(1487, 468);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(118, 37);
            this.btnTaBort2.TabIndex = 14;
            this.btnTaBort2.Text = "Ta bort";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(1329, 468);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(118, 37);
            this.btnSpara2.TabIndex = 13;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            // 
            // btnLaggTill2
            // 
            this.btnLaggTill2.Location = new System.Drawing.Point(1177, 468);
            this.btnLaggTill2.Name = "btnLaggTill2";
            this.btnLaggTill2.Size = new System.Drawing.Size(118, 37);
            this.btnLaggTill2.TabIndex = 12;
            this.btnLaggTill2.Text = "Lägg till";
            this.btnLaggTill2.UseVisualStyleBackColor = true;
            this.btnLaggTill2.Click += new System.EventHandler(this.btnLaggTill2_Click);
            // 
            // cbUppdFrekvens
            // 
            this.cbUppdFrekvens.FormattingEnabled = true;
            this.cbUppdFrekvens.Location = new System.Drawing.Point(1063, 525);
            this.cbUppdFrekvens.Name = "cbUppdFrekvens";
            this.cbUppdFrekvens.Size = new System.Drawing.Size(244, 33);
            this.cbUppdFrekvens.TabIndex = 15;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(1383, 525);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(244, 33);
            this.cbKategori.TabIndex = 16;
            // 
            // avsnittsBeskrivningTextruta
            // 
            this.avsnittsBeskrivningTextruta.Location = new System.Drawing.Point(954, 632);
            this.avsnittsBeskrivningTextruta.Margin = new System.Windows.Forms.Padding(6);
            this.avsnittsBeskrivningTextruta.Multiline = true;
            this.avsnittsBeskrivningTextruta.Name = "avsnittsBeskrivningTextruta";
            this.avsnittsBeskrivningTextruta.ReadOnly = true;
            this.avsnittsBeskrivningTextruta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.avsnittsBeskrivningTextruta.Size = new System.Drawing.Size(718, 189);
            this.avsnittsBeskrivningTextruta.TabIndex = 27;
            // 
            // lblAvsnittsbeskrivning
            // 
            this.lblAvsnittsbeskrivning.AutoSize = true;
            this.lblAvsnittsbeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittsbeskrivning.Location = new System.Drawing.Point(949, 572);
            this.lblAvsnittsbeskrivning.Name = "lblAvsnittsbeskrivning";
            this.lblAvsnittsbeskrivning.Size = new System.Drawing.Size(224, 25);
            this.lblAvsnittsbeskrivning.TabIndex = 28;
            this.lblAvsnittsbeskrivning.Text = "Avsnittsbeskrivning:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(1177, 388);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(444, 31);
            this.txtKategori.TabIndex = 29;
            // 
            // lblKategori2
            // 
            this.lblKategori2.AutoSize = true;
            this.lblKategori2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori2.Location = new System.Drawing.Point(1172, 346);
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
            this.lblAvsnitt.Location = new System.Drawing.Point(57, 528);
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
            this.lblPodcastNamn.Location = new System.Drawing.Point(50, 444);
            this.lblPodcastNamn.Name = "lblPodcastNamn";
            this.lblPodcastNamn.Size = new System.Drawing.Size(79, 25);
            this.lblPodcastNamn.TabIndex = 32;
            this.lblPodcastNamn.Text = "Namn:";
            this.lblPodcastNamn.UseWaitCursor = true;
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(55, 472);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(251, 31);
            this.txtNamn.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 31);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(682, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 31);
            this.textBox2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 866);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

