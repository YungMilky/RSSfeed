using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Models; 

namespace DAL.Repositories
{
    public interface IKategoriRepository<T> : IRepository<T> where T : Kategori
    {
        T HamtaAllaEnligtKategori(string namn);

    }
}
