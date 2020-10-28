using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repositories;


namespace BL.Controller
{
    public class KategoriController
    {
        IKategoriRepository<Kategori> kategoriRepository;

        private PodcastController podcastController;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
            podcastController = new PodcastController(); 
        }
        public void SkapaKategoritObjekt(string titel)
        {
            Kategori nyKategori = new Kategori(titel);
            kategoriRepository.Skapa(nyKategori);
        }

        public List<Kategori> HamtaAllaKategorier()
        {
            return kategoriRepository.HamtaAlla(); 
        }

        public void TaBortKategori(string titel) //funkar inte att ta bort podcast som tillhör en kategori än
        {
            int index = kategoriRepository.HamtaIndex(titel);
            List<Podcast> podcastLista = podcastController.HamtaAllaPodcasts();
            foreach (var item in podcastLista)
            {
                if(titel.Equals(item.Kategori.ToString()))
                {
                    string podcastNamn = item.Namn;
                    podcastController.TaBortPodcast(podcastNamn);
                    
                }
            }
            kategoriRepository.TaBort(index);
        }

        public void UppdateraKategoriLista(string gammalTitel, string nyTitel, int index)
        {
            Console.WriteLine(gammalTitel + nyTitel + index);
            Kategori kategori = new Kategori(nyTitel);
            kategoriRepository.Uppdatera(index, kategori);

            List<Podcast> allaPodcasts = podcastController.HamtaAllaPodcasts();
            List<Podcast> allaPodcastIKategori = new List<Podcast>(); 
            foreach (Podcast item in allaPodcasts)
            {
                if (gammalTitel.Equals(item.Kategori))
                {
                    allaPodcastIKategori.Add(item);
                }
            }
            kategoriRepository.BytaKategori(index, nyTitel, allaPodcastIKategori);
        }

        public int HamtaKategoriIndex(string titel)
        {
            int index = kategoriRepository.HamtaIndex(titel);
            return index;
        }

        //public string HamtaAllaEnligtKategori(string kategoriNamn)
        //{
        //    return HamtaAlla().First(p => p.KategoriNamn.Equals(kategoriNamn)); 
        //    hur hämtar man KategoriNamn från klassen Kategori?

        //}
    }
}
