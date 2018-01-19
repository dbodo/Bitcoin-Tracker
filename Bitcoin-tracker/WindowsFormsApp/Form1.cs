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
using DatabaseService;



namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public List<Bitcoin> lBitcoin;
        public List<BitcoinPrice> lBitcoinPrice;
        public Form1()
        {
            InitializeComponent();
            //lCurrency = crud.GetCurrency();
            //comboBoxCurrency.DataSource = lCurrency;
            Crud crud = new Crud();
            List<CurrencyList> lCurrency = crud.GetCurrency();
            bitcoinCurrencyBindingSource.DataSource = lCurrency;
            comboBoxCurrency.DataSource = bitcoinCurrencyBindingSource.DataSource;
            comboBoxCurrency.DisplayMember = "Currency";
            comboBoxCurrency2.DataSource = bitcoinCurrencyBindingSource.DataSource;
            comboBoxCurrency2.DisplayMember = "Currency";
            //labelValue.Text = "sranje";

            dateTimeStartDate.MaxDate = DateTime.Now.AddDays(-2);
            dateTimeEndDate.MaxDate = DateTime.Now.AddDays(-1);
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            REST rest = new REST();
            string sStartDate = this.dateTimeStartDate.Text;
            string sEndDate = this.dateTimeEndDate.Text;
            string sCurrency = this.comboBoxCurrency.Text;
            rest.GetURL(sStartDate, sEndDate, sCurrency);
            lBitcoin = rest.getBitcoinPriceIndex(sStartDate, sEndDate, sCurrency);
            dataGridViewBPI.DataSource = lBitcoin;
            chart1.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1.Series[0].XValueMember = dataGridViewBPI.Columns[0].DataPropertyName;
            chart1.Series[0].YValueMembers = dataGridViewBPI.Columns[1].DataPropertyName;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.DataSource = dataGridViewBPI.DataSource;
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sCurrency = comboBoxCurrency.SelectedItem.ToString();
        }

        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            CurrencyList currency = new CurrencyList();
            currency.Currency = inptCurrency.Text;
            Crud crud = new Crud();
            if (!comboBoxCurrency.Items.Contains(currency.Currency)){
                crud.AddCurrency(currency);
            }
            List<CurrencyList> lCurrency = crud.GetCurrency();
            bitcoinCurrencyBindingSource.DataSource = lCurrency;
            comboBoxCurrency.DataSource = bitcoinCurrencyBindingSource.DataSource;        
                     
            comboBoxCurrency.DisplayMember = "Currency";
            //comboBoxCurrency.DataSource = crud.GetCurrency();
        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            CurrencyList currency = new CurrencyList();
            currency.Currency = inptCurrency.Text;
            Crud crud = new Crud();
            crud.DeleteCurrency(currency);
            comboBoxCurrency.DataSource = crud.GetCurrency();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotNetDataSet.Bitcoin_Currency' table. You can move, or remove it, as needed.
            this.bitcoin_CurrencyTableAdapter.Fill(this.dotNetDataSet.Bitcoin_Currency);
        }

        private void comboBoxCurrency2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sCode = comboBoxCurrency2.SelectedItem.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            REST rest = new REST();
            string sCurrency = this.comboBoxCurrency2.Text;
            rest.GetURL2(sCurrency);
            lBitcoinPrice = rest.GetBitcoinCurrentPrice(sCurrency);
           
        }
    }
}
