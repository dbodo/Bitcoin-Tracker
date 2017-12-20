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
        public static string GetHistoricalData(string url)
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
        public List<Bitcoin> getBitcoinPriceIndex()
        {
            REST Rest = new REST();
            List<Bitcoin> lBitcoinREST = new List<Bitcoin>();
            string url = GetURL();
            string sJson = REST.GetHistoricalData(url);
            JArray json = JArray.Parse(sJson);
            var oBitcoin = json["bpi"].ToList();
            foreach (JProperty item in oBitcoin.Children())
            {
                lBitcoinREST.Add(new Bitcoin
                {
                    DateTime = (string)item.Value,
                    Value = (float)item.Value
                });
            }
            return lBitcoinREST;
        }

        public string GetURL()
        {
            StringBuilder builder = new StringBuilder();
            string endpoint = ConfigurationManager.AppSettings["endpoint"];
            string sStartDate = dateTimeStartDate.Text;
            string sEndDate = dateTimeEndDate.Text;
            string sCurrency = comboBoxCurrency.Text;
            builder.Append(endpoint + "?start=" + sStartDate + "&end=" + sEndDate + "&currency=" + sCurrency);
            return builder.ToString();
        }
    }
}
