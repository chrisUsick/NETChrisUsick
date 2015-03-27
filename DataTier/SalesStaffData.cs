using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    /// <summary>
    /// class for esablishing connection to sales staff data
    /// </summary>
    public class SalesStaffData : Data
    {
        public SalesStaffData(string connectionString, string tableName, string selectQuery)
            : base(connectionString, tableName, selectQuery) { }
    }
}
