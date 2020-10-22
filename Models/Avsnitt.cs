using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt : Podcast
    {
        public string Beskrivning { get; set; }
        public string Titel { get; set; }

        public Avsnitt() //måste man ha en konstruktor?
        {

        }

    }
}
