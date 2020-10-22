using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Skapa(T Entity);
        void Uppdatera(string namn);
        void TaBort(string namn);
        void Spara();
        List<T> HamtaAlla();

    }
    
}
