using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataTier
{
    /// <summary>
    /// class for accessing vehicle stock data from database
    /// </summary>
    public class VehicleStockData : Data
    {
        public VehicleStockData(string connectionString, string tableName, string selectQuery)
            : base(connectionString, tableName, selectQuery) { }

        public bool IsDuplicateStockNumber(string id)
        {
            DataRow[] rows = GetAllRows().Select(string.Format("StockNumber = {0}", id));

            return (rows.Count() != 0);
        }
    }
}
