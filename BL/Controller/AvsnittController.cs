using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Controller
{

    public class AvsnittController
    {
        private AvsnittRepository avsnittRepository;

        public AvsnittController()
        {
            avsnittRepository = new AvsnittRepository();
        }

    }

}
