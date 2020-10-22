using Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Controller
{
    public class PodcastController
    {
        IPodcastRepository<Podcast> podcastRepository;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }

        public void SkapaPodcastObjekt() //vilka parametrar?
        {
            Podcast newPodcast;
            //skriv kod

        }

        public List<Podcast> HamtaAllaPodcasts() //ska det vara en lista av avsnitt?
        {
            return podcastRepository.HamtaAlla();
        }

        public void TaBortPodcast(string namn)
        {
            int index = podcastRepository.GetIndex(namn);
            podcastRepository.TaBortPodcast(index);
        }
    }
}
