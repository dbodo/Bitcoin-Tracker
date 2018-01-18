using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DatabaseService
{
    public class Crud
    {      
        public List<CurrencyList> GetCurrency()
        {
            List<CurrencyList> lCurrency = new List<CurrencyList>();
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Bitcoin_Currency";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lCurrency.Add(new CurrencyList()
                        {
                            Currency = (string)oReader["Currency"]
                        });
                    }
                }
            }
            return lCurrency;
        }

        public void AddCurrency(CurrencyList oCurrencyCode)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Bitcoin_Currency (Currency) VALUES('" + oCurrencyCode.Currency + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteCurrency(CurrencyList oCurrencyCode)
        {
            string sSqlConnectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Bitcoin_Currency WHERE Currency = '" + oCurrencyCode.Currency + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        /*public List<BitcoinList> GetBitcoin()
       {
           List<BitcoinList> lBitcoin = new List<BitcoinList>();
           String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
           using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
           using (DbCommand oCommand = oConnection.CreateCommand())
           {
               oCommand.CommandText = "SELECT * FROM Bitcoin_PriceIndex";
               oConnection.Open();
               using (DbDataReader oReader = oCommand.ExecuteReader())
               {
                   while (oReader.Read())
                   {
                       lBitcoin.Add(new BitcoinList()
                       {
                           DateTime = (string)oReader["DateTime"],
                           Value = (float)oReader["Value"], 
                           Currency = (float)oReader["Currency"]                         
                       });
                   }
               }
           }
           return lBitcoin;
       }*/


        /*public void AddBitcoin(BitcoinList oBitcoin)
        {
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Bitcoin_PriceIndex (DATETIME, VALUE, CURRENCY) VALUES('" + oBitcoin.DateTime + "', '" + oBitcoin.Value + "', '" + oBitcoin.Currency + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void UpdateBitcoin(BitcoinList oBitcoin)
        {
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE Bitcoin_PriceIndex SET DATETIME = '" + oBitcoin.DateTime + "', VALUE = '" + oBitcoin.Value + "' WHERE USER_ID = " + oBitcoin.Currency;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }*/

    }
}
