using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feed : Podcast 
    {
        public string URL { get; set; }
        public string Titel { get; set; }
        public string Kategori { get; set; }
        public int UppdateraFrekvens { get; set; }
        public List<Avsnitt> Avsnitt { get; set; }

        public Feed()//måste man ha en konstruktor?
        {
        }
        public override string Display()
        {
            return "Det här är en podcast feed.";
        }
    }
}
