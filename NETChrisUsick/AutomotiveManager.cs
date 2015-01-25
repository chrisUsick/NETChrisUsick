using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETChrisUsick
{
    public class AutomotiveManager
    {
        public enum DialogResult
        {
            OK
        }
        private static bool isBeingTested = false;
        
        //private static DialogResult dialogResult = DialogResult.OK;
        
        public static bool IsBeingTested {get;}
        //public static DialogResult DialogResult {get;} 

        public static bool IsNumeric(string stringValue)
        {
            double maybeDouble;
            return Double.TryParse(stringValue, out maybeDouble);
        }
    }
}
