using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        public string Name { get; set; }
        public int Avsnitt { get; set; }
        public Kategori Kategori { get; set; } //bör nog ändra datatyp
        public int Frekvens { get; set; } //bör nog ändra datatyp
    }
}
