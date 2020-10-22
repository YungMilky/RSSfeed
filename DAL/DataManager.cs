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
        public void Serialize(List<Podcast> podcastList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(podcastList.GetType());
                using (FileStream Outfile = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(Outfile, podcastList);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Podcasts.xml", "Could not serialize file");
            }
        }

        public List<Podcast> Deserialize()
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
    }
}
