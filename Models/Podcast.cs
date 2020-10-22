using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {

        public string Namn { get; set; }
        public string URL { get; set; }
        public int Uppdateringsfrekvens { get; set; }
        public string Kategori { get; set; }

        //ska klassernas properties vara här och inte i respektive klass?
        public Podcast(string namn, string url, int uppdateringsFrekvens, string kategori)
        {
            Namn = namn;
            URL = url;
            Uppdateringsfrekvens = uppdateringsFrekvens;
            Kategori = kategori; 
        }
        public virtual string Display()
        {
            return "Det här är en podcast";
        }
    }
}
