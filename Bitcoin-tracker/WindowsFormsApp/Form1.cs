using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTapi;
using Newtonsoft.Json.Linq;
using System.Configuration;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public List<Bitcoin> lBitcoin;
        public Form1()
        {
            InitializeComponent();           
        }
        public List<Bitcoin> getBitcoinPriceIndex()
        {
            REST Rest = new REST();
            List<Bitcoin> lBitcoinREST = new List<Bitcoin>();
            string url = GetURL();
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
            return lBitcoinREST;
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            GetURL();
            lBitcoin = getBitcoinPriceIndex();
            dataGridViewBPI.DataSource = lBitcoin;
        }
        public string GetURL()
        {
            StringBuilder builder = new StringBuilder();
            string sStartDate = this.dateTimeStartDate.Text;
            string sEndDate = this.dateTimeEndDate.Text;
            //string endpoint = ConfigurationManager.AppSettings["endpoint"];
            string sCurrency = this.comboBoxCurrency.Text;
            builder.Append("https://api.coindesk.com/v1/bpi/historical/close.json" + "?start=" + sStartDate + "&end=" + sEndDate + "&currency=" + sCurrency);
            return builder.ToString();
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sCurrency = (string)comboBoxCurrency.SelectedItem;
        }
    }
}
