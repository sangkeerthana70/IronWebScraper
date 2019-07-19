using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrapeNasdaq
{
    class Stock
    {
        public string companyName;
        public string symbol;
        public string price;
        public string changePercent;
        public string volume;
        public string percentVolume;

        public Stock()
        {

        }

        public Stock(string cN, string sym, string p, string cP, string vol, string pVol)
        {
            this.companyName = cN;
            this.symbol = sym;
            this.price = p;
            this.changePercent = cP;
            this.volume = vol;
            this.percentVolume = pVol;
            
        }
    }

    
}
