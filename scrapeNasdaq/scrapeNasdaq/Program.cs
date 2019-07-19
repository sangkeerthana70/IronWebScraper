using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrapeNasdaq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("In main scraping NASDAQ");
            var scraper = new Nasdaq();
            scraper.Start();
        }
    }
}
