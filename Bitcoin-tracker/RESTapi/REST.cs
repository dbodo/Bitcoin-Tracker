using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Configuration;

namespace RESTapi
{
    public class REST
    {
        public List<Bitcoin> getBitcoinPriceIndex(string sStartDate, string sEndDate, string sCurrency)
        {
            REST Rest = new REST();
            List<Bitcoin> lBitcoinREST = new List<Bitcoin>();
            string url = GetURLhistorical(sStartDate, sEndDate, sCurrency);
            var sJson = JObject.Parse(GetData(url));
            var rates = sJson.SelectToken("bpi");
            foreach (var rate in rates)
            {
                var property = rate as JProperty;
                string Date = property.Name;
                float Val = (float)property.Value;
                lBitcoinREST.Add(new Bitcoin
                {
                    DateTime = Date,
                    Value = Val
                });
            }
            return lBitcoinREST;
        }

        public BitcoinPrice GetBitcoinCurrentPrice(string sCurrency)
        {
            BitcoinPrice btcCurrentPrice = new BitcoinPrice();
            string sUrl = GetURLcurrent(sCurrency);
            var sJson = JObject.Parse(GetData(sUrl));
            btcCurrentPrice.rate = (float)sJson.SelectToken("bpi." + sCurrency + ".rate");
            btcCurrentPrice.time = (string)sJson.SelectToken("time.updateduk");
            System.Diagnostics.Debug.WriteLine(btcCurrentPrice.rate);
            System.Diagnostics.Debug.WriteLine(btcCurrentPrice.time);
            return btcCurrentPrice;
        }

        public static string GetData(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            //webrequest.Headers.Add("Username", "xyz");
            //webrequest.Headers.Add("Password", "abc");
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public string GetURLhistorical(string sStartDate, string sEndDate, string sCurrency)
        {
            StringBuilder builder = new StringBuilder();
            string endpoint = ConfigurationManager.AppSettings["endpointHistorical"];
            builder.Append(endpoint + "?start=" + sStartDate + "&end=" + sEndDate + "&currency=" + sCurrency);
            return builder.ToString();
        }

        public string GetURLcurrent(string sCode)
        {
            StringBuilder builder = new StringBuilder();
            string endpoint = ConfigurationManager.AppSettings["endpointCurrent"];
            builder.Append(endpoint + sCode + ".json");
            return builder.ToString();
        }
    }
}
