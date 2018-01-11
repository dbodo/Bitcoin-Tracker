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
        public List<BitcoinList> GetBitcoin()
        {
            List<BitcoinList> lBitcoin = new List<BitcoinList>();
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM users";
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
        }

        public void AddBitcoin(BitcoinList oBitcoin)
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
        }

    }
}
