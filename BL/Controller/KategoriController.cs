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

        public void UppdateraKategoriLista(string titel)
        {
            //funkar inte
            //int index = kategoriRepository.HamtaIndex(titel);
            //kategoriRepository.Uppdatera(index);
        }

        //public string HamtaAllaEnligtKategori(string kategoriNamn)
        //{
        //    return HamtaAlla().First(p => p.KategoriNamn.Equals(kategoriNamn)); 
        //    hur hämtar man KategoriNamn från klassen Kategori?

        //}

        //public string HamtaPodcastEnligtNamn(string titel)
        //{
        //    return HamtaAlla().First(p => p.Titel.Equals(titel)); 
        //    hur hämtar man Titel från klassen Feed?
        //}
    }
}
