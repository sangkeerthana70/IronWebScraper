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
        public string priceChange;
        public string changePercent;
        public string volume;

        public Stock()
        {
        }

        public Stock(string cN, string sym, string p, string pC, string cP, string v)
        {
            this.companyName = cN;
            this.symbol = sym;
            this.price = p;
            this.priceChange = pC;
            this.changePercent = cP;
            this.volume = v;

        }

        public void DisplayStockInfo()
        {
            Console.WriteLine("Name: {0}", this.companyName);
            Console.WriteLine("----------------------");
            Console.WriteLine("Symbol: {0}", this.symbol);
            Console.WriteLine("Price: {0}", this.price);
            Console.WriteLine("Price change: {0}", this.priceChange);
            Console.WriteLine("Change percent: {0}", this.changePercent);
            Console.WriteLine("Volume: {0}", this.volume);
        }
    }
}
