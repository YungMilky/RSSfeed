using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        public Podcast()
        {
        }
        public virtual string Display()
        {
            return "Det här är en podcast";
        }
    }
}
