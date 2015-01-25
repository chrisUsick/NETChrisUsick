using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NETChrisUsick
{
    public class AutomotiveManager
    {
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
            double maybeDouble;
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
        /// <param name="defaultButton">default button of the message box. Default: MessageBoxDefaultButton.Button1</param>
        /// <returns>the value of the message box</returns>
        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return isBeingTested ? messageBoxResult : MessageBox.Show(text, caption, buttons, icon, defaultButton);
        }
    }
}
