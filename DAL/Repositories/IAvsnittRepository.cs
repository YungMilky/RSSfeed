using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models; 

namespace DAL.Repositories
{
    public interface IAvsnittRepository<T> where T : Avsnitt
    {
        List<T> HamtaAlla();
    }
}
