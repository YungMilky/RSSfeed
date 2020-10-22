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
    //error på rad 11 eftersom två metoder är bortkommenterade
    {
        DataManager dataManager;
        List<Podcast> podcastList; 

        public PodcastRepository()
        {
            podcastList = new List<Podcast>();
            dataManager = new DataManager();
            podcastList = HamtaAlla();
        }

        public void Skapa(Podcast entity)
        {
            podcastList.Add(entity);
            Spara();    
        }

        public void Spara()
        {
            dataManager.Serialize(podcastList);
        }

        public Podcast HamtaPodcastEnligtNamn(string namn)
        {
            return null; //ta bort denna rad sen när koden skrivs
            //skriv kod
        }

        public List<Podcast> HamtaAlla()
        {
            List<Podcast> podcastsToBeReturned = new List<Podcast>();
            podcastsToBeReturned = dataManager.Deserialize();
            return podcastsToBeReturned;
        }

        public void Uppdatera(string namn)
        {
            // skriv kod för att uppdatera en podcast
        }

        public void TaBort(string namn)
        {
            //skriv kod för att ta bort en podcast
        }
    }
}
