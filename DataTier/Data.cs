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

            // handle adding ID to new rows, once added to the database
            adapter.RowUpdated += new OleDbRowUpdatedEventHandler(delegate(object sender, OleDbRowUpdatedEventArgs e)
                {
                    // if the command was an insert
                    if (e.StatementType == StatementType.Insert)
                    {
                        // select the ID of the last added item
                        OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", connection);

                        // add it the the row which was updated
                        e.Row["ID"] = (int)cmd.ExecuteScalar();
                    }
                });
        }

        public DataTable GetAllRows()
        {
            return dataSet.Tables[tableName];
        }

        public void Close()
        {
            connection.Close();
        }

        public void Update()
        {
            adapter.Update(dataSet.Tables[tableName]);
        }
    }
}
