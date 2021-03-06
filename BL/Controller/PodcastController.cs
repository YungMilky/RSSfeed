﻿using DAL.Repositories;
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
            DateTime nextUpdate = DateTime.Now; 
            Podcast newPodcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnitt, nextUpdate);
            podcastRepository.Skapa(newPodcast);
        }
        public async void SkapaPodcastObjekt(Dictionary<string, object> podcastProperties)
        {
            string namn = podcastProperties["Namn"].ToString();
            string url = podcastProperties["URL"].ToString();
            int uppdateringsFrekvens = (int)podcastProperties["Uppdateringsfrekvens"];
            string kategori = podcastProperties["Kategori"].ToString();

            List<Avsnitt> avsnitt = await avsnittRepository.HamtaAllaAvsnitt(url);
            DateTime nextUpdate = DateTime.Now;
            Podcast newPodcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnitt, nextUpdate);
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

        public async void UppdateraPodcast(string podcastNamn, string url, int frekvens, string kategori, int index, DateTime nextUpdate)
        {
            List<Avsnitt> avsnittsLista = await avsnittRepository.HamtaAllaAvsnitt(url);
            Podcast podcast = new Podcast(podcastNamn, url, frekvens, kategori, avsnittsLista, nextUpdate);
            podcastRepository.SparaUppdatering(index, podcast);
        }

        public async void UppdateraPodcast(Dictionary<string, object> podcastProperties)
        {
            string namn = podcastProperties["Namn"].ToString();
            string url = podcastProperties["URL"].ToString();
            int uppdateringsFrekvens = (int)podcastProperties["Uppdateringsfrekvens"];
            string kategori = podcastProperties["Kategori"].ToString();
            int index = (int)podcastProperties["Index"];

            List<Avsnitt> avsnitt = await avsnittRepository.HamtaAllaAvsnitt(url);
            DateTime nextUpdate = DateTime.Now;
            Podcast podcast = new Podcast(namn, url, uppdateringsFrekvens, kategori, avsnitt, nextUpdate);
            podcastRepository.SparaUppdatering(index, podcast);
        }
    }
}
