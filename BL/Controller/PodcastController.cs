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

        public async void SkapaPodcastObjekt(string namn, string url, int uppdateringsFrekvens, string kategori)
        {
            List<Avsnitt> avsnitt = await avsnittRepository.HamtaAllaAvsnitt(url);
            Podcast newPodcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnitt);
            podcastRepository.Skapa(newPodcast);
        }

        public List<Podcast> HamtaAllaPodcasts()
        {
            return podcastRepository.HamtaAlla();
        }

        public int HamtaPodcastIndex(string titel)
        {
            int index = podcastRepository.HamtaIndex(titel);
            return index; 
        }

        public string HamtaUrl(string titel)
        {
            Podcast podcast = podcastRepository.HamtaPodcastEnligtNamn(titel);
            string url = podcast.URL;
            return url; 
        }

        public void TaBortPodcast(string namn)
        {
            int index = podcastRepository.HamtaIndex(namn);
            podcastRepository.TaBort(index);
        }

        public async void UppdateraPodcast(string podcastNamn, string url, int frekvens, string kategori, int index)
        {
            List<Avsnitt> avsnittsLista = await avsnittRepository.HamtaAllaAvsnitt(url);
            Podcast podcast = new Podcast(podcastNamn, url, frekvens, kategori, avsnittsLista);
            podcastRepository.SparaUppdatering(index, podcast);
        }
    }
}
