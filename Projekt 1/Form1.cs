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
        List<string> errorList;
        public Form1()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            kategoriController = new KategoriController();

            errorList = new List<string>();
        }

        private void btnLaggTill1_Click(object sender, EventArgs e)
        {
            //konvertera user input av frekvens till int32 och tilldela värdet till frek
            Int32.TryParse(txtFrekvens.Text.ToString(), out int frek);

            Dictionary<string, object> userInput = new Dictionary<string, object>
            {
                { "Namn", txtNamn.Text },
                { "URL", txtURL.Text },
                { "Uppdateringsfrekvens", frek },
                { "Kategori", txtKat.Text.ToString() }
            };

            InputValidator validator = new InputValidator();
            ValidationResult results = validator.Validate(userInput);

            if(results.IsValid == false)
            {
                foreach(ValidationFailure fail in results.Errors)
                {
                    errorList.Add(fail.ErrorMessage);
                }

                string errorMessage = "";
                foreach (string err in errorList)
                {
                    errorMessage = string.Join(Environment.NewLine, err); //samla error messages i en string, med nya rader emellan
                }
                Console.WriteLine(errorMessage);
                MessageBox.Show($"{errorMessage}", "Fel", //lägg till console errors
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, frek, txtKat.Text.ToString());
            }

            
        }

        private void btnLaggTill2_Click(object sender, EventArgs e)
        {
            kategoriController.SkapaKategoritObjekt(txtKategori.Text);
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
