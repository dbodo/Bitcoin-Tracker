using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTapi;
using System.IO;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace TestConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {
                REST rest = new REST();
                List<Bitcoin> lBitcoinREST = new List<Bitcoin>();
                string url = "https://api.coindesk.com/v1/bpi/historical/close.json?start=2010-09-01&end=2019-09-05&currency=HRK";
                string sJson = REST.GetHistoricalData(url);
                JArray json = JArray.Parse(sJson);
                var oBitcoin = json["bpi"].ToList();
                foreach (JProperty item in json.Children())
                {
                    lBitcoinREST.Add(new Bitcoin
                    {
                        DateTime = (string)item.Value,
                        Value = (float)item.Value
                    });
                }
                for (int i = 0; i < lBitcoinREST.Count; i++)
                {
                    Console.WriteLine(lBitcoinREST[i].DateTime + ' ' + lBitcoinREST[i].Value);
                }
        }

    }
}
