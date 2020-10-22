using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KategoriRepository : IKategoriRepository<Kategori>
    {
        public int GetIndex(string namn)
        {
            return 1; //ta bort raden när koden skrivs
            //behövs den här metoden?
        }

        public List<Kategori> HamtaAlla()
        {
            return null; //ta bort rad nör kod skrivs
            //skriv kod 
        }

        public Kategori HamtaAllaEnligtKategori(string namn)
        {
            return null; //ta bort när kod skrivs
            //skriv kod
        }

        public void Skapa(Kategori Entity)
        {
            //skriv kod 
        }

        public void Spara()
        {
            //skriv kod 
        }

        public void TaBort(int index)
        {
            //skriv kod 
        }

        public void Uppdatera(int index)
        {
            //skriv kod 
        }
    }
}
