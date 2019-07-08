using IronWebScraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraerWithIronWebScraper
{
    public class ScrapeTopHadlines : WebScraper
    {
        public override void Init()
        {
            License.LicenseKey = "LicenseKey"; // Write License Key
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("https://www.realclearpolitics.com/", Parse);
        }

        public override void Parse(Response response)
        {
            //var date = response.Css("div > #top.date-header")[0].InnerText;
            //Console.WriteLine("date " + date);
            foreach(HtmlNode story in response.Css("div.story>div.post"))
            {
                /*Console.WriteLine("story " + story.InnerHtml);
                var link = response.Css("a")[0].InnerText;
                Console.WriteLine("link " + link);

                var author = response.Css(".byline")[1].InnerText;
                Console.WriteLine("author " + author);
                */


                string link = story.Css("div.title > a")[0].InnerText;
                Console.WriteLine("link " + link);
                string authorAndSource = story.Css("div.byline")[0].InnerText;
                Console.WriteLine("author " + authorAndSource);
                string author = authorAndSource.Split(',')[0];
                Console.WriteLine("author " + author);
                string source = authorAndSource.Split(',')[1];
                Console.WriteLine("source " + source);

            }
        }

    }
}
