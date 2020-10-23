﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Kategori> HamtaAlla()
        {
            List<Kategori> categoriesToBeReturned = new List<Kategori>();
            categoriesToBeReturned = dataManager.DeserializeKategori();
            return categoriesToBeReturned;
        }

        public Kategori HamtaAllaEnligtKategori(string namn)
        {
            return null; //ta bort när kod skrivs. koden nedan stämmer inte
            //return HamtaAlla().First(p => p.Namn.Equals(namn));
        }

        public int HamtaIndex(string titel)
        {
            return HamtaAlla().FindIndex(e => e.Titel.Equals(titel));
        }

        public void Skapa(Kategori entity)
        {
            kategoriList.Add(entity);
            Spara();
        }

        public void Spara()
        {
            dataManager.SerializeKategori(kategoriList);
        }

        public void TaBort(int index)
        {
            kategoriList.RemoveAt(index);
            Spara();
        }

        public void Uppdatera(int index, Kategori newEntity)
        {
            if (index >= 0)
            {
                kategoriList[index] = newEntity;
            }
            Spara();
        }

    }
}
