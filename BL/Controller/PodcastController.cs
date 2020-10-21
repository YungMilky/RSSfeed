using Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Controller
{
    public class PodcastController
    {
        IPodcastRepository<Podcast> podcastRepository;

        public PodcastController()
        {
            podcastRepository = new PodcastRepository();
        }
    }
}
