using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraerWithIronWebScraper
{
    class Stock
    {
       
        public string companyName;
        public string symbol;
        public string price;
        public string change;
        public string percentChange;
        public DateTime scrapeTime;


        public Stock()
        {
        }

        public Stock(string cN, string sym, string p, string change, string pC, DateTime scrapeTime)
        {           
            this.companyName = cN;
            this.symbol = sym;
            this.price = p;
            this.change = change;
            this.percentChange = pC;
            this.scrapeTime = scrapeTime;
        }

        public void DisplayStockInfo()
        {           
            Console.WriteLine("Name: {0}", this.companyName); 
            Console.WriteLine("Symbol: {0}", this.symbol);
            Console.WriteLine("Price: {0}", this.price);
            Console.WriteLine("Change: {0}", this.change);
            Console.WriteLine("Change percent: {0}", this.percentChange);          
        }
    }
}
