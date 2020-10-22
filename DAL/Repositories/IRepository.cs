﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Skapa(T Entity);
        void Uppdatera(int index);
        void TaBort(int index);
        void Spara();
        List<T> HamtaAlla();

    }
    
}
