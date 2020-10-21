using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feed : Entitet 
    {
        public string URL { get; set; }
        public string Titel { get; set; }
        public string Kategori { get; set; }
        public int AntaletAvsnitt { get; set; }
        public AvsnittLista avsnitt { get; set; }
        public string UppdateraFrekvens { get; set; }

        public override string EntitetsTyp()
        {
            return "Podcast feed.";
        }
    }
}
