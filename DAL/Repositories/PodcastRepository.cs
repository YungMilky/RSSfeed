using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PodcastRepository : IPodcastRepository<Podcast>
    {
        DataManager dataManager;
        List<Podcast> podcastList; 

        public PodcastRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new DataManager();
            podcastList = HamtaAlla();
        }

        public void LaggTill(Podcast entity)
        {
            podcastList.Add(entity);
            Spara();    
        }

        public void TaBort(string valdKategori, string valdFeed)
        {
            //skriv kod
        }

        public void TaBortKategori(string mapp)
        {
            //skriv kod
        }

        public List<Podcast> HamtaAlla() //eller är det en lista av avsnitt vi vill hämta?
        {
            List<Podcast> podcastsToBeReturned = new List<Podcast>();
            podcastsToBeReturned = dataManager.Deserialize();
            return podcastsToBeReturned;
        }

        public void Spara()
        {
            dataManager.Serialize(podcastList);
        }

        public void Uppdatera(string URL, string nyttKategoriNamn, int uppdateringsFrekvens, string kategori)
        {
            //skriv kod, stämmer parametrarna??
        }

        public Podcast HamtaAllaEnligtKategori(string kategoriNamn)
        {
            return HamtaAlla().First(p => p.KategoriNamn.Equals(kategoriNamn)); 
            //hur hämtar man KategoriNamn från klassen Kategori?
        }

        public Podcast HamtaPodcastEnligtNamn(string titel)
        {
            return HamtaAlla().First(p => p.Titel.Equals(titel)); 
            //hur hämtar man Titel från klassen Feed?
        }
    }
}
