using FluentValidation;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validator
{
    public class InputValidator : AbstractValidator<Podcast>
    {
        public InputValidator()
        {
            //Regler för validering
            RuleFor(pod => pod.Namn)
                .Cascade(CascadeMode.Stop) //stoppar validering (async) så fort en regel bryts
                .NotEmpty().WithMessage("Fältet '{PropertyName}' är tomt.")
                .Length(2, 30).WithMessage("Fältet '{PropertyName}' kräver 2-30 bokstäver/symboler.");

            RuleFor(pod => pod.Kategori)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Fältet '{PropertyName}' är tomt.")
                .Length(2, 30).WithMessage("Fältet '{PropertyName}' kräver 2-30 bokstäver/symboler.");
            
            RuleFor(pod => pod.UppdateringsFrekvens)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Fältet '{PropertyName}' är tomt.");

            RuleFor(pod => pod.URL)
                .Cascade(CascadeMode.Stop) 
                .NotEmpty().WithMessage("Fältet '{PropertyName}' är tomt.")
                .Must(pod=> pod.Length > 16).WithMessage("Fältet '{PropertyName}' kräver minst 13 bokstäver/symboler.") 
                //minsta möjliga urlen är egentligen 17 symboler; "http://.x.x/x.xml", men Length index börjar ju på 0
                .Must(validURL).WithMessage("Felaktig {PropertyName}. Måste börja med http(s) och sluta med .xml ."); //validURL måste returnera true
        }

        /*
         * validURL och autoFormatURL är två olika tillvägagångssätt. Antingen gör man det lättare för användaren att
         * skriva ofullständiga urler genom att autoformattera dem, med risken att användaren lägger in icke xml-filer,
         * eller så avbryter man användaren om den skriver fel. XMLReader kanske får exception om man försöker mata in icke-xml,
         * så autoFormatURL verkar bäst imo
         */
        protected bool validURL(string url)
        {
            url = url.Replace(" ", ""); //tar bort mellanrum

            if (!(url.StartsWith("http://") || url.StartsWith("https://")) && !(url.EndsWith(".xml")))
            {
                return true;
            }
            else return false; //finare utan brackets
        }

        protected string autoFormatURL(string url)
        {
            url = url.Replace(" ", ""); //tar bort mellanrum
            string prefix = "http://";
            string prefixSecure = "https://";
            string suffix = ".xml";

            //om urlen inte börjar med http:// eller https://
            if (!(url.StartsWith(prefix) || url.StartsWith(prefixSecure)))
            {
                url = $"{prefix}{url}";
            }
            //om urlen inte slutar med .xml
            if (!url.EndsWith(suffix))
            {
                url = $"{url}{suffix}";
            }

            return url;
        }
    }

}
