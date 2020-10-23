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

        public Podcast (string namn, string url, int uppdateringsFrekvens, string kategori)
        {
            Namn = namn;
            URL = url;
            UppdateringsFrekvens = uppdateringsFrekvens;
            Kategori = kategori;
        }

        public Podcast()
        {

        }

        public override string EntitetsTyp()
        {
            return "Det här är en podcast";
        }
        //public override List<object> getProperties()
        //{
        //    var propertyList = new List<object>();

        //    foreach (var prop in this.GetType().GetProperties())
        //    {
        //        propertyList.Add(prop.Name, prop.GetValue(this.GetType()));
        //    }

        //    this.GetType().GetProperties());
        //    return propertyList;
        //}
    }
}

