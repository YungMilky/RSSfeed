using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast : Entitet
    {
        public string Namn { get; set; }
        public string URL { get; set; }
        public int UppdateringsFrekvens { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AvsnittsLista { get; set; }
        public DateTime NextUpdate { get; set; }

        public Podcast (string namn, string url, int uppdateringsFrekvens, string kategori, List<Avsnitt> avsnittsLista)
        {
            Namn = namn;
            URL = url;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Kategori = kategori;
            AvsnittsLista = avsnittsLista;
            Uppdatera();
        }

        public Podcast()
        {

        }

        public override string EntitetsTyp()
        {
            return "Det här är en podcast";
        }

        public void Uppdatera()
        {
            NextUpdate = DateTime.Now.AddMinutes(UppdateringsFrekvens);
            Console.WriteLine($"Podcast updated. Next update in {NextUpdate} minutes.");
        }
        public bool NeedsUpdate
        {
            get
            {
                return NextUpdate <= DateTime.Now;
            }
        }
    }
}

