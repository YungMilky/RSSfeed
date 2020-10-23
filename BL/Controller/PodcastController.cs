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

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        public void SkapaPodcastObjekt(string namn, string url, int uppdateringsFrekvens, string kategori)
        {
            Podcast newPodcast = new Podcast(namn, url, uppdateringsFrekvens, kategori);
            podcastRepository.Skapa(newPodcast);
        }

        public List<Podcast> HamtaAllaPodcasts() //ska det vara en lista av avsnitt?
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
