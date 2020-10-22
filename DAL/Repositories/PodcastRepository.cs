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

        public void TaBort(int index)
        {
            podcastList.RemoveAt(index);
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

        public int GetIndex(string namn)
        {
            return HamtaAlla().FindIndex(e => e.Namn.Equals(namn));

            //funkar det?
        }

        public void Uppdatera(int index)//stämmer parametern?
        {
            //skriv kod
        }

        public List<Podcast> HamtaAlla()
        {
            List<Podcast> podcastsToBeReturned = new List<Podcast>();
            podcastsToBeReturned = dataManager.Deserialize();
            return podcastsToBeReturned;
        }
    }
}
