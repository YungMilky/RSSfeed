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

        public void TaBort(string namn)
        {
            //skriv kod för att ta bort en kategori
        }

        public void Uppdatera(int index)
        {
            //skriv kod 
        }

        public void Uppdatera(string namn)
        {
            //skriv kod för att uppdatera en kategori
        }
    }
}
