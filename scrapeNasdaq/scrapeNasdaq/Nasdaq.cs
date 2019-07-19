using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronWebScraper;

namespace scrapeNasdaq
{
    public class Nasdaq : WebScraper
    {
        public override void Init()
        {
            License.LicenseKey = "LicenseKey"; // Write License Key
            this.LoggingLevel = WebScraper.LogLevel.All;
            Console.WriteLine("before request");
            this.Request("https://markets.financialcontent.com/stocks/stocks/dashboard/mostactive", Parse);
            Console.WriteLine("after request");
        }

        public override void Parse(Response response)
        {
            Console.WriteLine("inside Parse method");
            /*
            foreach(HtmlNode row in response.Css(".watchlist_dynamic1"))
            {
                //Console.WriteLine(row.InnerText);

                Stock stock = new Stock();
                stock.companyName = row.Css("td > a")[0].InnerText;
                Console.WriteLine("symbol " + stock.companyName);
                stock.symbol = row.Css("td.col_symbol")[0].InnerText;
                Console.WriteLine("stock.symbol " + stock.symbol);
                stock.price = row.Css(".col_price")[1].InnerText;
                Console.WriteLine("stock.price " + stock.price);
                stock.changePercent = row.Css(".col_changecompound")[1].InnerText;
                Console.WriteLine("stock.changePercent " + stock.changePercent);
                stock.volume = row.Css(".col_volume")[1].InnerText;
                Console.WriteLine("stock.volume " + stock.volume);
                stock.percentVolume = row.Css(".col_dollarvolume")[1].InnerText;
                Console.WriteLine("stock.percentVolume " + stock.percentVolume);
            }
            */

            // britt 
            /*
            foreach(HtmlNode row in response.Css(".watchlist_dynamic1"))
            {
                Stock stock = new Stock();
                
                foreach(var cName in row.Css("td > a"))
                {
                    stock.companyName = cName.InnerText;
                    Console.WriteLine("stock.companyName " + stock.companyName);
                }
                

            }
            */

            foreach(HtmlNode row in  response.Css("div.watchlist_dynamic1 > table > tbody > tr").Skip(1))
            {
                Console.WriteLine("test " + row.InnerText);
                Stock stock = new Stock();


            }
            
        }
    }
}
