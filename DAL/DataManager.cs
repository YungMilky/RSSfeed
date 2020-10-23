using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Exceptions;
using System.Xml.Serialization;
using Models;
using System.IO;

namespace DAL
{
    internal class DataManager
    {
        public void SerializePodcast(List<Podcast> podcastList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(podcastList.GetType());
                using (FileStream Outfile = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(Outfile, podcastList);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Could not serialize file");
            }
        }

        public List<Podcast> DeserializePodcast()
        {
            try
            {

                List<Podcast> listOfPodcastsToBeReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                    listOfPodcastsToBeReturned = (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
                return listOfPodcastsToBeReturned;

            }
            catch (Exception)
            {
                throw new SerializerException("Podcasts.xml", "Could not deserialize file");
            }
        }

        public void SerializeKategori(List<Kategori> kategoriList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(kategoriList.GetType());
                using (FileStream Outfile = new FileStream("Kategori.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(Outfile, kategoriList);
                }
            }
            catch (Exception)
            {
                throw new SerializerException("Kategori.xml", "Could not serialize file");
            }
        }

        public List<Kategori> DeserializeKategori()
        {
            try
            {

                List<Kategori> listOfCategoriesToBeReturned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));
                using (FileStream inFile = new FileStream("Kategori.xml", FileMode.Open, FileAccess.Read))
                {
                    listOfCategoriesToBeReturned = (List<Kategori>)xmlSerializer.Deserialize(inFile);
                }
                return listOfCategoriesToBeReturned;

            }
            catch (Exception)
            {
                throw new SerializerException("Kategori.xml", "Could not deserialize file");
            }
        }
    }
}
