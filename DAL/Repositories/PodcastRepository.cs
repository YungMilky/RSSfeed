﻿using DAL.Exceptions;
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
            SparaUppdatering();    
        }

        public void SparaUppdatering()
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
            try
            {
                podcastListToBeReturned = dataManager.DeserializePodcast();
            }
            catch (SerializerException e)
            {
                Console.WriteLine(DateTime.Now + " " + e.Message);
            }
            return podcastListToBeReturned;
        }

        public void SparaUppdatering(int index, Podcast newEntity)
        {
            if (index >= 0)
            {
                podcastList[index] = newEntity;
            }
            SparaUppdatering();
        } 
        public int HamtaIndex(string namn)
        {
            return HamtaAlla().FindIndex(e => e.Namn.Equals(namn));
        }

        public void TaBort(int index)
        {
                podcastList.RemoveAt(index);
                SparaUppdatering();
        }

    }
}
    

