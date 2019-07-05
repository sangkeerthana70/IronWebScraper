using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraerWithIronWebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("In Main");
            var scraper = new ScrapeStocks();
            scraper.Start();
        }
    }
}
