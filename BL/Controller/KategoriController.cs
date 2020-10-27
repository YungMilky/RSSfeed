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

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }
        public void SkapaKategoritObjekt(string titel)
        {
            Kategori newKategori = new Kategori(titel);
            kategoriRepository.Skapa(newKategori);
        }

        public List<Kategori> HamtaAllaKategorier()
        {
            return kategoriRepository.HamtaAlla(); 
        }

        public void TaBortKategori(string titel)
        {
            int index = kategoriRepository.HamtaIndex(titel);
            kategoriRepository.TaBort(index);
        }

        public void UppdateraKategoriLista(string nyTitel, int index)
        {
            //List<Kategori> kategoriLista = kategoriLista.HamtaAllaKategorier();
            Kategori kategori = new Kategori(nyTitel);
            kategoriRepository.Uppdatera(index, kategori);

        }

        public int HamtaKategoriIndex(string titel)
        {
            int index = kategoriRepository.HamtaIndex(titel);
            return index;
        }

        //public void UppdateraPodcast(string podcastNamn, string url, int frekvens, string kategori, int index)
        //{
        //    List<Avsnitt> avsnittsLista = avsnittRepository.HamtaAllaAvsnitt(url);
        //    Podcast podcast = new Podcast(podcastNamn, url, frekvens, kategori, avsnittsLista);
        //    podcastRepository.Uppdatera(index, podcast);

        //}

        //public string HamtaAllaEnligtKategori(string kategoriNamn)
        //{
        //    return HamtaAlla().First(p => p.KategoriNamn.Equals(kategoriNamn)); 
        //    hur hämtar man KategoriNamn från klassen Kategori?

        //}
    }
}
