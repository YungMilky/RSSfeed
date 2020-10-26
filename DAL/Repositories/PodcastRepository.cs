using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void Skapa(Podcast entity)
        {
            podcastList.Add(entity);
            Spara();    
        }

        public void Spara()
        {
            dataManager.SerializePodcast(podcastList);
        }

        public Podcast HamtaPodcastEnligtNamn(string namn)
        {
            return HamtaAlla().First(p => p.Namn.Equals(namn));
        }

        public List<Podcast> HamtaAlla()
        {
            List<Podcast> podcastListToBeReturned = new List<Podcast>();
            podcastListToBeReturned = dataManager.DeserializePodcast();
            return podcastListToBeReturned;
        }

        //public void Uppdatera(int index, Podcast newEntity)
        //{
        //    if (index >= 0)
        //    {
        //        podcastList[index] = newEntity;
        //    }
        //    Spara();
        //} //funkar inte 
        public int HamtaIndex(string namn)
        {
            return HamtaAlla().FindIndex(e => e.Namn.Equals(namn));
        }

        public void TaBort(int index)
        {
            podcastList.RemoveAt(index);
            Spara();
        }

        public void Uppdatera(int index, Podcast newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
    

