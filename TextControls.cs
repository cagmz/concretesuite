using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ConcreteSuite
{
    //string _myGroupbox = 

    class TextControls
    {
        public static bool Validate(string text) 
        { 
            //sanitize input of textboxes
            //hopefully in a way that
            //will accomodate any future textboxes
            // check for empty and null strings
            // if (tb!=null && tb.Text != string.Empty)

            //Original pattern
            //string pattern="^[+]?([.]\d+|\d+[.]?\d*)$";

            
            string pattern="^[+]?([.]\\d+|\\d+[.]?\\d*)$";
            //MatchCollection matches = Regex.Matches(text, pattern);
            if (Regex.IsMatch(text, pattern))
            {
                return true;
            } else {
                return false;
            }


        }

        //find the namespace for .Controls
        //public void Clear()
        //{
        // foreach (Control ctrl in this.Controls)
        //{
        //    TextBox tb = ctrls as TextBox;
        //    if (tb != null && tb.Text != string.Empty)
        //    {
        //    tb.Clear();
        //    }
        //}
        //}



    }
}
