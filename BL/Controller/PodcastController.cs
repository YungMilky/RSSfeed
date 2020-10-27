using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL.Controller
{
    public class PodcastController
    {
        IPodcastRepository<Podcast> podcastRepository;

        private AvsnittRepository avsnittRepository; 

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
            avsnittRepository = new AvsnittRepository();  
        }

        public Podcast SkapaPodcastObjekt(Dictionary<string, object> podcastProperties)
        {
            string namn = podcastProperties["Namn"].ToString();
            string url = podcastProperties["URL"].ToString();
            int uppdateringsFrekvens = (int)podcastProperties["Uppdateringsfrekvens"];
            string kategori = podcastProperties["Kategori"].ToString();

            Podcast newPodcast = new Podcast(namn, url, uppdateringsFrekvens, kategori);
            podcastRepository.Skapa(newPodcast);

            return newPodcast;
        }

        public List<Podcast> HamtaAllaPodcasts()
        {
            return podcastRepository.HamtaAlla();
        }

        public void TaBortPodcast(string namn)
        {
            int index = podcastRepository.HamtaIndex(namn);
            podcastRepository.TaBort(index);
        }

        public void UppdateraPodcast()
        {

        }
    }
}
