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
            kategoriRepository.TaBort(index);
            List<Podcast> podcastLista = podcastController.HamtaAllaPodcasts();
            foreach (var item in podcastLista)
            {
                if(titel.Equals(item.Kategori))
                {
                    string podcastNamn = item.Namn;
                    podcastController.TaBortPodcast(podcastNamn);
                }
            }
        }

        public void UppdateraKategoriLista(string nyTitel, int index)
        {
            Kategori kategori = new Kategori(nyTitel);
            kategoriRepository.Uppdatera(index, kategori);
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
