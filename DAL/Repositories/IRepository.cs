using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity); //ska man även lägga till kategori och uppdateringsfrekvens som parametrar?
        void Delete(string valdKategori, string valdFeed);
       // void DeleteKategori;//(vad ska den ta för parameter?)
        void Update(string URL, string nyttKategoriNamn, int uppdateringsFrekvens, string kategori); //stämmer parametrarna?
        void SaveChanges();
        List<T> GetAll();
    
}
