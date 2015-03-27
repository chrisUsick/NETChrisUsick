using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DataTier
{
    /// <summary>
    /// Base class for the data tier
    /// </summary>
    public class Data
    {
        internal OleDbConnection connection;
        internal OleDbDataAdapter adapter;
        internal OleDbCommandBuilder commandBuilder;
        internal DataSet dataSet;
        internal string connectionString;
        internal string tableName;
        internal string selectQuery;

        public Data(string connectionString, string tableName, string selectQuery)
        {
            this.connectionString = connectionString;
            this.tableName = tableName;
            this.selectQuery = selectQuery;

            connection = new OleDbConnection(connectionString);
            adapter = new OleDbDataAdapter();
            dataSet = new DataSet();
            

            connection.Open();
            adapter.SelectCommand = new OleDbCommand(selectQuery, connection);
            commandBuilder = new OleDbCommandBuilder(adapter);

            adapter.Fill(dataSet, tableName);
        }

        public DataTable GetAllRows()
        {
            return dataSet.Tables[tableName];
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
