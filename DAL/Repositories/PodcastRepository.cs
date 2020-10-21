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
            podcastList = GetAll();
        }

        public void Add(Podcast entity)
        {
            podcastList.Add(entity);
            SaveChanges();    
        }

        public void Delete(string valdKategori, string valdFeed)
        {
            //skriv kod
        }

        public void DeleteKategori(string mapp)
        {
            //skriv kod
        }

        public List<Podcast> GetAll()
        {
            List<Podcast> podcastsToBeReturned = new List<Podcast>();
            podcastsToBeReturned = dataManager.Deserialize();
            return podcastsToBeReturned;
        }

        public void SaveChanges()
        {
            dataManager.Serialize(podcastList);
        }

        public void Update(string URL, string nyttKategoriNamn, int uppdateringsFrekvens, string kategori)
        {
            //skriv kod, stämmer parametrarna??
        }
    }
}
