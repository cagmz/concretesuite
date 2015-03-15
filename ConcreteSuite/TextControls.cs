using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ConcreteSuite
{

    class TextControls
    {
        public static bool Validate(string text) 
        { 
            //sanitize input of textboxes
            //hopefully in a way that
            //will accomodate any future textboxes
            // check for empty and null strings

     
            string pattern="^[+]?([.]\\d+|\\d+[.]?\\d*)$";
            
            if (Regex.IsMatch(text, pattern))
            {
                return true;
            } else {
                return false;
            }
        }
    }

}
