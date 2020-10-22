using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {

        //ska klassernas properties vara här och inte i respektive klass?
        public Podcast()
        {
        }
        public virtual string Display()
        {
            return "Det här är en podcast";
        }
    }
}
