using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL.Repositories
{
    public class AvsnittRepository : IAvsnittRepository<Avsnitt>
    {
        List<Avsnitt> avsnittsLista; 

        public AvsnittRepository()
        {
            avsnittsLista = new List<Avsnitt>(); 
        }
        public List<Avsnitt> HamtaAllaAvsnitt(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            List<Avsnitt> allaAvsnitt = new List<Avsnitt>();
            foreach (var item in feed.Items)
            {
                Avsnitt avsnitt = new Avsnitt();
                avsnitt.Titel = item.Title.Text;
                avsnitt.Beskrivning = item.Summary.Text;
                allaAvsnitt.Add(avsnitt);
            }
            return allaAvsnitt; 
        }
    }
}
