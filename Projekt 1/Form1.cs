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

            
            InputValidator validator = new InputValidator();

            Int32.TryParse(txtFrekvens.Text.ToString(), out int frek);

            ValidationResult results = validator.Validate(
                podcastController.SkapaPodcastObjekt(txtNamn.Text, txtURL.Text, frek, txtKat.Text.ToString()));

            if(results.IsValid == false)
            {
                foreach(ValidationFailure fail in results.Errors)
                {
                    errorList.Add($"Error: {fail.PropertyName}, {fail.ErrorMessage}");
                }

                string errorMessage = "";
                foreach (string err in errorList)
                {
                    errorMessage = string.Join(Environment.NewLine, err);
                }
                MessageBox.Show($"{errorMessage}", "Fel", //hitta på ett sätt att visa user friendly errors + lägg till console errors
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
