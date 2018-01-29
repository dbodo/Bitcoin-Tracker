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
        public Form1()
        {
            InitializeComponent();
            //lCurrency = crud.GetCurrency();
            //comboBoxCurrency.DataSource = lCurrency;
            Crud crud = new Crud();
            List<CurrencyData> lCurrency = crud.GetCurrency();

            chart1.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 4;
            chart1.Series[0].Color = Color.FromArgb(43, 54, 83);
            chart1.Series[0].Name = "Bitcoin price";

            bitcoinCurrencyBindingSource.DataSource = lCurrency;
            comboBoxCurrency.DataSource = bitcoinCurrencyBindingSource.DataSource;
            comboBoxCurrency.DisplayMember = "Currency";
            comboBoxCCYCalc.DataSource = bitcoinCurrencyBindingSource.DataSource;
            comboBoxCCYCalc.DisplayMember = "Currency";

            comboBoxCurrency.SelectedIndex = -1;
            comboBoxCCYCalc.SelectedIndex = -1;

            dateTimeStartDate.Value = DateTime.Today.AddDays(-8);
            dateTimeStartDate.MaxDate = DateTime.Today.AddDays(-2);
            dateTimeEndDate.MaxDate = DateTime.Today.AddDays(-1);
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            REST rest = new REST();
            List<Bitcoin> lBitcoin = new List<Bitcoin>();
            string sStartDate = this.dateTimeStartDate.Text;
            string sEndDate = this.dateTimeEndDate.Text;
            string sCurrency = this.comboBoxCurrency.Text;
            rest.GetURLhistorical(sStartDate, sEndDate, sCurrency);
            lBitcoin = rest.getBitcoinPriceIndex(sStartDate, sEndDate, sCurrency);
            dataGridViewBPI.DataSource = lBitcoin;
            dataGridViewBPI.Columns[0].HeaderText = "Date";
            dataGridViewBPI.Columns[0].Name = "Date";
            dataGridViewBPI.Columns[1].HeaderText = sCurrency;
            dataGridViewBPI.Columns[1].Name = sCurrency;

            chart1.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1.Series[0].XValueMember = dataGridViewBPI.Columns[0].DataPropertyName;
            chart1.Series[0].YValueMembers = dataGridViewBPI.Columns[1].DataPropertyName;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 4;
            chart1.Series[0].Color = Color.FromArgb(43, 54, 83);
            chart1.Series[0].Name = "Bitcoin price";
            chart1.DataSource = dataGridViewBPI.DataSource;
        }


        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            CurrencyData currency = new CurrencyData();
            currency.Currency = comboBoxCurrency.Text;
            crud.DeleteCurrency(currency);
            comboBoxCurrency.DataSource = crud.GetCurrency();
            comboBoxCCYCalc.DataSource = crud.GetCurrency();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotNetDataSet.Bitcoin_Currency' table. You can move, or remove it, as needed.
            this.bitcoin_CurrencyTableAdapter.Fill(this.dotNetDataSet.Bitcoin_Currency);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            REST rest = new REST();
            BitcoinPrice btcPrice = new BitcoinPrice();

            string sCurrency = this.comboBoxCCYCalc.Text;
            rest.GetURLcurrent(sCurrency);
            btcPrice = rest.GetBitcoinCurrentPrice(sCurrency);
            lblUpdateDate.Text = btcPrice.time.ToUpper();
            float BtcPrice = btcPrice.rate;

            float BtcAmount = (float)Convert.ToSingle(inptXBT.Text);
            float calculate = (float)BtcPrice * BtcAmount;
            lblCalcVal.Text = (calculate + " " + sCurrency).ToString();
        }


        private void inptXBT_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inptXBT.Text, "  ^ [0-9]"))
            {
                inptXBT.Text = "";
            }
        }

        private void inptXBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
