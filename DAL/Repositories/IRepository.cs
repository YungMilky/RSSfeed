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
        void SparaUppdatering(int index, T newEntity); //method overloading, har samma metod-namn men har olika parametrar
        void SparaUppdatering(); //method overloading, har samma metod-namn men har olika parametrar
        void TaBort(int index);
        int HamtaIndex(string namn);
        List<T> HamtaAlla();

    }
    
}
