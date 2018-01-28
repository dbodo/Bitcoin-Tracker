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
        public List<CurrencyData> GetCurrency()
        {
            List<CurrencyData> lCurrency = new List<CurrencyData>();
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Bitcoin_Currency";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lCurrency.Add(new CurrencyData()
                        {
                            Currency = (string)oReader["Currency"]
                        });
                    }
                }
            }
            return lCurrency;
        }

        public void AddCurrency(CurrencyData oCurrencyCode)
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
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

        public void DeleteCurrency(CurrencyData oCurrencyCode)
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
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
        public void CheckCurrency(CurrencyData oCurrencyCode)
        {
            string sSqlConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Bitcoin_Currency WHERE Currency = '" + oCurrencyCode.Currency + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    if (oReader.HasRows)
                    {
                        oReader.Close();
                    }
                    else
                    {
                        AddCurrency(oCurrencyCode);
                    }
                }
            }
        }  
    }
}
