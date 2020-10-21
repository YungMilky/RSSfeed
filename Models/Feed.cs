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
        public Kategori Kategori { get; set; }
        public int AntaletAvsnitt { get; set; }
        public AvsnittLista avsnitt { get; set; }
        public int UppdateraFrekvens { get; set; }

        public override string EntitetsTyp()
        {
            return "Podcast feed.";
        }
    }
}
