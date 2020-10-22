using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori : Podcast
    {
        public string KategoriNamn { get; set; } 
        // ska properties vara här eller i Podcast?

        public Kategori(string kategoriNamn)//måste man ha en konstruktor?
        {
            KategoriNamn = kategoriNamn; //måste det finnas en parameter?
        }
        public override string Display()
        {
            return "Det här är en kategori.";
        }
    }
}
