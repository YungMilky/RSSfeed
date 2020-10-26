﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IPodcastRepository<T> : IRepository<T> where T : Podcast
    {
        T HamtaPodcastEnligtNamn(string namn);
        T HamtaDetaljerUrl(string url);

    }
}
