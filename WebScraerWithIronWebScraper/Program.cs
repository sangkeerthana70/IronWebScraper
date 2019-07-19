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
            //System.Console.WriteLine("In Main scraping CNN money");
            //var scraper = new ScrapeStocksFromCNN();
            //scraper.Start();

            Console.WriteLine("In main scraping headlines");

            var scrapeMyHoldings = new ScrapeTopHadlines();
            scrapeMyHoldings.Start();
        }
    }
}
