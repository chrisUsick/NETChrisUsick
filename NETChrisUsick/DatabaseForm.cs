using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataTier;
using System.Data;

namespace NETChrisUsick
{
    

    /// <summary>
    /// a helper class containing useful database methods
    /// this form loads data on the shown event.
    /// </summary>
    public partial class DatabaseForm : Form
    {
        /// <summary>
        /// class for holding database connection info
        /// </summary>
        public struct DataObjectInfo
        {
            public string ConnectionString {get; set;}
            public string TableName {get; set;}
            public string SelectStatement {get; set;}

            /// <summary>
            /// construct a n DataObjectInfo object
            /// </summary>
            /// <param name="connectionString"></param>
            /// <param name="tableName"></param>
            /// <param name="selectStatement"></param>
            public DataObjectInfo(string connectionString, string tableName, string selectStatement)
                :this()
            {
                this.ConnectionString = connectionString;
                this.TableName = tableName;
                this.SelectStatement = selectStatement;
            }
        }
        protected Data dataObject;

        protected BindingSource bindingSource;

        /// <summary>
        /// constructor required for design view
        /// Shouldn't be used in code
        /// </summary>
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
        }

        /// <summary>
        /// construct a databaseForm
        /// </summary>
        /// <param name="dataClass">The type of class to use as the Database object. Should be a DataTier class</param>
        /// <param name="info">object containing connection info</param>
        public DatabaseForm(Type dataClass, DataObjectInfo info)
        {
            string errorMessage = "An error occurred fetching vehicle stock data.";
            string caption = "Database Error";
            InitializeComponent();
            // add shown event handler
            Shown += new EventHandler(delegate(object sender, EventArgs e)
                {
                    // construct the dataObject
                    try
                    {
                        Type stringType = typeof(string);
                        dataObject = (Data)dataClass.GetConstructor(new Type[] { stringType, stringType, stringType })
                            .Invoke(new Object[]{
                                info.ConnectionString,
                                info.TableName,
                                info.SelectStatement
                            });
                        bindingSource = new BindingSource();

                        bindingSource.DataSource = dataObject.GetAllRows();


                    }
                    catch (InvalidCastException castEx)
                    {
                        // if a bad class is passed in the constructor throw exception
                        //throw new Exception("Cannot cast given dataClass to type `DataTier.Data`", castEx);
                        AutomotiveManager.LogErrorWithMessage(castEx, errorMessage, caption);
                    }
                    catch (Exception ex)
                    {
                        // catch all other errors;
                        //throw new Exception("failed to populate bindingSource.DataSource", ex);
                        AutomotiveManager.LogErrorWithMessage(ex, errorMessage, caption);
                    }
                });
        }
    }
}
