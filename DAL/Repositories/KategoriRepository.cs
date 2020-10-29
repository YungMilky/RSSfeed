using DAL.Exceptions;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL.Repositories
{
    public class KategoriRepository : IKategoriRepository<Kategori>
    {
        DataManager dataManager;
        List<Kategori> kategoriList;

        public KategoriRepository()
        {
            kategoriList = new List<Kategori>();
            dataManager = new DataManager();
            kategoriList = HamtaAlla();
        }

        public void BytaKategori(int index, string nyTitel, List<Podcast> podcastIKategori)
        {
            Kategori enKategori = kategoriList.ElementAt(index);
            enKategori.Titel = nyTitel;
            PodcastRepository podcastRepository = new PodcastRepository();
            foreach (Podcast item in podcastIKategori)
            {
                Podcast podcast = new Podcast();
                podcast.Namn = item.Namn;
                podcast.URL = item.URL;
                podcast.UppdateringsFrekvens = item.UppdateringsFrekvens;
                podcast.Kategori = nyTitel; 
                int i = podcastRepository.HamtaIndex(podcast.Namn);
                podcastRepository.SparaUppdatering(i, podcast); 
            }
            SparaUppdatering(); 
        }

        public List<Kategori> HamtaAlla()
        {
            List<Kategori> categoriesToBeReturned = new List<Kategori>();
            try
            {
                categoriesToBeReturned = dataManager.DeserializeKategori();
            }
            catch (SerializerException e)
            {
                Console.WriteLine(DateTime.Now + " " + e.Message);
            }
            return categoriesToBeReturned;
        }

        public int HamtaIndex(string titel)
        {
            return HamtaAlla().FindIndex(e => e.Titel.Equals(titel));
        }

        public void Skapa(Kategori entity)
        {
            kategoriList.Add(entity);
            SparaUppdatering();
        }

        public void SparaUppdatering()
        {
            dataManager.SerializeKategori(kategoriList);
        }

        public void TaBort(int index)
        {
            kategoriList.RemoveAt(index);
            SparaUppdatering();
        }

        public void SparaUppdatering(int index, Kategori newEntity)
        {
            if (index >= 0)
            {
                kategoriList[index] = newEntity;
            }
            SparaUppdatering();
        }

    }
}
