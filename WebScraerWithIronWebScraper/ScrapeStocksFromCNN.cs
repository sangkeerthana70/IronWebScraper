using IronWebScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraerWithIronWebScraper
{
    public class ScrapeStocksFromCNN : WebScraper
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

            Console.WriteLine("======scraping most active hot stocks=======");
            foreach(HtmlNode stockData in response.Css("#wsod_hotStocks > table:nth-child(5) > tbody > tr").Skip(1))
            {
                Stock stock = new Stock();

                stock.symbol = stockData.Css("td > a")[0].InnerText;
                Console.WriteLine("symbol: " + stock.symbol);

                stock.companyName = stockData.Css("td > span")[0].InnerText;
                Console.WriteLine("company name: " + stock.companyName);

                stock.price = stockData.Css("td > span")[1].InnerText;
                Console.WriteLine("price: " + stock.price);

                stock.change = stockData.Css("td > span")[2].InnerText;
                Console.WriteLine("change: " + stock.change);

                stock.percentChange = stockData.Css("td > span")[3].InnerText;
                Console.WriteLine("percentChange: " + stock.percentChange);


            }

            Console.WriteLine("============scraping gainers table================");
            foreach (HtmlNode gainers in response.Css("#wsod_hotStocks > table:nth-child(8) > tbody > tr").Skip(1))
            {
                Stock stock = new Stock();

                stock.symbol = gainers.Css("td > a")[0].InnerText;
                Console.WriteLine("gainers symbol: " + stock.symbol);

                stock.companyName = gainers.Css("td > span")[0].InnerText;
                Console.WriteLine("gainers companyName: " + stock.companyName);

                stock.price = gainers.Css("td > span")[1].InnerText;
                Console.WriteLine("gainers price: " + stock.price);

                stock.change = gainers.Css("td > span")[2].InnerText;
                Console.WriteLine("gainers change: " + stock.change);

                stock.percentChange = gainers.Css("td > span")[3].InnerText;
                Console.WriteLine("gainers percent change: " + stock.percentChange);

            }
            
        }
    }
}
