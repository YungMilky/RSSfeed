using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        void LaggTill(T entity); //ska man även lägga till kategori och uppdateringsfrekvens som parametrar? Eller ska det vara egna metoder?
        void TaBortPodcast(int index);
        void TaBortKategori (int index);//(ska den ta denna parameter?
        void Uppdatera(string URL, string nyttKategoriNamn, int uppdateringsFrekvens, string kategori); //stämmer parametrarna?
        void Spara();
        List<T> HamtaAlla();

    }
    
}
