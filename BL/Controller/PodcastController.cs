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

        public void SkapaPodcastObjekt(string namn, string url, int uppdateringsFrekvens, string kategori)
        {
            List<Avsnitt> avsnitt = avsnittRepository.HamtaAllaAvsnitt(url);
            Podcast newPodcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnitt);
            podcastRepository.Skapa(newPodcast);
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
    }
}
