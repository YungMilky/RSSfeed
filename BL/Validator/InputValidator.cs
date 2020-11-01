using FluentValidation;
using FluentValidation.Results;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validator
{
    public class InputValidator : AbstractValidator<Dictionary<string, object>>
    {
        public InputValidator()
        {
            When(pod => pod != null, () => { 
            //Regler för validering
            RuleFor(pod => pod["Namn"].ToString())
                .Cascade(CascadeMode.Stop) //stoppar validering (async) så fort en regel bryts
                .NotEmpty().WithMessage("Fältet '{PropertyName}' är tomt.")
                .Length(2, 30).WithMessage("Fältet 'Namn' kräver 2-30 bokstäver/symboler.");

            RuleFor(pod => pod["Kategori"].ToString())
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Fältet 'Kategori' är tomt.")
                .Length(2, 30).WithMessage("Fältet 'Kategori' kräver 2-30 bokstäver/symboler.");

            RuleFor(pod => pod["URL"].ToString())
                .Cascade(CascadeMode.Stop) 
                .NotEmpty().WithMessage("Fältet 'URL' är tomt.")
                .Must(ValidURLLength).WithMessage("Fältet 'URL' kräver minst 17 symboler.") //inuti Must() är metoden ValidURLLength(), som hittas längre ner
                .Must(ValidURL).WithMessage("Felaktig URL. Måste börja med http(s) och sluta med .xml .");
            
            });
        }

        /*
         * validURL och autoFormatURL är två olika tillvägagångssätt. Antingen gör man det lättare för användaren att
         * skriva ofullständiga urler genom att autoformattera dem, med risken att användaren lägger in icke xml-filer,
         * eller så avbryter man användaren om den skriver fel. XMLReader kanske får exception om man försöker mata in icke-xml,
         * så autoFormatURL verkar bäst imo
         */
        protected bool ValidURL(string url)
        {
            url = url.Replace(" ", "");

            if (!(url.StartsWith("http://") || url.StartsWith("https://")) && !(url.EndsWith(".xml")))
            {
                return true;
            }
            else return false;
        }

        protected bool ValidURLLength(string url)
        {
            //minsta möjliga urlen är egentligen 17 symboler; "http://.x.x/x.xml", och Length index börjar ju på 0
            return url.Length > 16; 
        }
        
        protected string AutoFormatURL(string url)
        {
            url = url.Replace(" ", "");
            string prefix = "http://";
            string prefixSecure = "https://";
            string suffix = ".xml";

            //det finns egentligen fler webb-protokoll än http och https,
            //men de är mer esoteriska, så för enkelhetens skull togs de inte med

            if (!(url.StartsWith(prefix) || url.StartsWith(prefixSecure)))
            {
                url = $"{prefix}{url}";
            }

            if (!url.EndsWith(suffix))
            {
                url = $"{url}{suffix}";
            }

            return url;
        }

        public string LogValidationErrors(ValidationResult results)
        {
            List<string> errorList;
            string errorMessage = "";

            if (results.IsValid == false)
            {
                errorList = new List<string>();

                foreach (ValidationFailure fail in results.Errors)
                {
                    errorList.Add(fail.ErrorMessage);
                }

                foreach (string err in errorList)
                {
                    errorMessage = string.Join(Environment.NewLine, err);
                }
            }
            return errorMessage;

        }

        public string CreateUniqueFilename(string filePath)
        {
            string newFilePath = filePath;

            if (File.Exists(filePath))
            {
                string dir = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExt = Path.GetExtension(filePath);

                for (int i = 1; ; ++i)
                {
                    newFilePath = Path.Combine($"({dir}({fileName}({i}({fileExt})");
                }
            }

            return newFilePath;
        }
    }

}
