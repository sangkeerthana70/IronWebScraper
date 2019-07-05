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

            foreach(HtmlNode stockData in response.Css("#wsod_hotStocks > table:nth-child(5) > tbody > tr").Skip(1))
            {
                Stock stock = new Stock();

                stock.symbol = stockData.Css("td > a")[0].InnerText;
                Console.WriteLine("symbol " + stock.symbol);

                string data = stockData.Css("td > span")[0].InnerText;
                Console.WriteLine("data " + data);

                string price = stockData.Css("td > span")[1].InnerText;
                Console.WriteLine("price " + price);

                string change = stockData.Css("td > span")[2].InnerText;
                Console.WriteLine("change " + change);

                string percentChange = stockData.Css("td > span")[3].InnerText;
                Console.WriteLine("percentChange " + percentChange);


            }

            
        }
    }
}
