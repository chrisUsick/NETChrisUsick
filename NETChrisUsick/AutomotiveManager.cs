using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Configuration;

namespace NETChrisUsick
{
    /// <summary>
    /// A utility class with functionality to be used throughout the entire application
    /// </summary>
    public static class AutomotiveManager
    {
        /// <summary>
        /// enumeration for form type
        /// </summary>
        public enum FormAction
        {
            New,
            Update
        }

        // true if the class is being unit tested
        private static bool isBeingTested = false;
        
        // Used for unit testing methods with a messageBox
        private static DialogResult messageBoxResult = DialogResult.OK;
        
        // public accessor for `isBeingTested`
        public static bool IsBeingTested
        {
            get
            {
                return isBeingTested;
            }
        }

        // public accessor for `messageBoxResult`
        public static DialogResult MessageBoxResult 
        {
            get
            {
                return messageBoxResult;
            }
        } 

        /// <summary>
        /// tests if a string only contains numeric characters
        /// </summary>
        /// <param name="stringValue">string value to test</param>
        /// <returns>true if the string contains only numeric characters</returns>
        public static bool IsNumeric(string stringValue)
        {
            // a variable to use as the out value for tryParse
            double maybeDouble;
            // return the value of TryParse
            return Double.TryParse(stringValue, out maybeDouble);
        }

        /// <summary>
        /// caculate an annuity based on fixed period payments
        /// </summary>
        /// <param name="rate">interest rate</param>
        /// <param name="numberOfPaymentPeriods">number of payments to be made</param>
        /// <param name="presentValue">present value of the annuity</param>
        /// <param name="futureValue">future value of the annuity</param>
        /// <param name="type">
        /// indicates when payments are made.
        /// 1 for payment at the beginning
        /// 0 for payment at the end
        /// </param>
        /// <returns>the payment for the annuity</returns>
        public static double Payment(double rate, double numberOfPaymentPeriods, double presentValue, double futureValue = 0, double type = 0)
        {
            // return the calculated price of an annuity
            return (rate == 0) ? presentValue / numberOfPaymentPeriods : 
                rate * (futureValue + presentValue * Math.Pow(1 + rate, numberOfPaymentPeriods)) / ((Math.Pow(1 + rate, numberOfPaymentPeriods) - 1) * (1 +rate * type));
        }

        /// <summary>
        /// Show a message box, and return the result
        /// </summary>
        /// <param name="text">text to be used in the message box</param>
        /// <param name="caption">caption of the message box</param>
        /// <param name="buttons">buttons to use in the message box. Default: MessageBoxButtons.OK</param>
        /// <param name="icon">icon to use in the message box. Default: MessageBoxIcon.Information</param>
        /// <param name="defaultButton">default button of the message box. Default: MessageBoxDefaultButton.Botton1</param>
        /// <returns>the value of the message box</returns>
        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            // if the class is being tested return messagBoxResult, display a message box
            return isBeingTested ? messageBoxResult : MessageBox.Show(text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        /// write an error to the error log
        /// </summary>
        /// <param name="exception">The exception that should be logged</param>
        /// <param name="message">
        /// Optional, the message to be placed before the stack trace.
        /// Defaults the the exception message
        /// </param>
        public static void LogError(Exception exception, string message = null)
        {
            try
            {
                // get the assembly
                //Assembly assembly = Assembly.GetExecutingAssembly();

                // get the namespace of the current assembly
                //string nameSpace = assembly.GetName().Name.ToString();

                // get the log file name
                string logName = ConfigurationManager.AppSettings.Get("logFile");

                // create the stream to the file
                //Stream fileStream = assembly.GetManifestResourceStream(
                    //nameSpace + "." + logName);

                // create the writer object
                //StreamWriter writer = (IsBeingTested) 
                //    ? new StreamWriter(logName)
                //    : new StreamWriter(fileStream);

                StreamWriter writer = new StreamWriter(logName, true);

                // add the log
                writer.WriteLine("Date: " + DateTime.Now.ToShortDateString());
                writer.WriteLine("Time: " + DateTime.Now.ToShortTimeString());
                message = (message == null) ? exception.Message : message;
                writer.WriteLine("Message: " + message);
                writer.WriteLine("Stack Trace: " + exception.StackTrace);
                writer.Close();
            }
            catch (Exception e)
            {
                // show message that error logging isn't working
                ShowMessage("Error writing to the error log: " + e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// log an exception and show a message box 
        /// </summary>
        /// <param name="exception">Exception passed to LogError</param>
        /// <param name="message">MessageBox message</param>
        /// <param name="caption">MessageBox caption</param>
        /// <returns>The result of the Message box</returns>
        public static DialogResult LogErrorWithMessage(Exception exception, string message, string caption)
        {
            // call the overloaded method
            return LogErrorWithMessage(exception, null, message, caption);
        }

        /// <summary>
        /// log an exception and show a message box 
        /// </summary>
        /// <param name="exception">Exception passed to LogError</param>
        /// <param name="logMessage">The log message, passed to LogError</param>
        /// <param name="message">MessageBox message</param>
        /// <param name="caption">MessageBox caption</param>
        /// <returns>The result of the Message box</returns>
        public static DialogResult LogErrorWithMessage(Exception exception, string logMessage, string message, string caption)
        {
            LogError(exception, logMessage);
            return ShowMessage(message,
                caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
    }
}
