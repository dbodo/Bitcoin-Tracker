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
        REST rest = new REST();
        public Form1()
        {
            InitializeComponent();           
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
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
            string sCurrency = (string)comboBoxCurrency.SelectedItem;
        }
    }
}
