using IronWebScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraerWithIronWebScraper
{
    public class ScrapeStocks : WebScraper
    {
        //List<Stock> listOfStocks = new List<Stock>();
        public override void Init()
        {
            License.LicenseKey = "LicenseKey"; // Write License Key
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("https://money.cnn.com/data/hotstocks/index.html", Parse);
        }

        public override void Parse(Response response)
        {
            List<Stock> stockList = new List<Stock>();

            var testData = response.Css("#wsod_hotStocks > div.clearfix.wsod_StockHeader > div.wsod_fLeft > h1 ")[0].InnerHtml;

            Console.WriteLine(testData);
            foreach(HtmlNode stockData in response.Css("#wsod_hotStocks > table:nth-child(5)"))
            {
                Console.WriteLine("in foreach");
                Stock stock = new Stock();

                foreach(var name in stockData.Css("a.wsod_symbol"))
                {
                    Console.WriteLine("in table data");
                    stock.companyName = name.InnerText;
                    Console.WriteLine("companyName " + stock.companyName);
                }

                foreach(var price in stockData.Css(" "))
                {
                    stock.price = price.InnerHtml;
                    Console.WriteLine("stockPrice " + stock.price);
                }

                //foreach(var )
            }

            
        }
    }
}
