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
    public partial class Form2 : Form
    {
        private readonly Form1 FormBitcoinList;
        public Form2(Form1 FormBitcoin)
        {
            FormBitcoinList = FormBitcoin;
            InitializeComponent();
            inptCurrency.MaxLength = 3;
        }

        private void btnAddCCY_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            CurrencyData currency = new CurrencyData();
            List<CurrencyData> lCurrency = new List<CurrencyData>();
            currency.Currency = inptCurrency.Text.ToUpper();
            crud.CheckCurrency(currency);
            lCurrency = crud.GetCurrency();
            this.FormBitcoinList.bitcoinCurrencyBindingSource.DataSource = lCurrency;
            this.FormBitcoinList.comboBoxCurrency.DataSource = this.FormBitcoinList.bitcoinCurrencyBindingSource.DataSource;
            this.FormBitcoinList.comboBoxCurrency.DisplayMember = "Currency";
            this.FormBitcoinList.comboBoxCCYCalc.DataSource = crud.GetCurrency();                    
        }

        private void inptCurrency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
