using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MillersLawnService
{
    public static class Validators
    {
        //Validates Name text
        public static bool ValidText(string name)
        {
            Regex regex = new Regex("^(?=.{1,40}$)[a-zA-Z]+(?:[-'\\s][a-zA-Z]+)*$");
            return regex.IsMatch(name);
        }

        //Validates Phone Numbers
        public static bool ValidPhone(string phone)
        {
            Regex regex = new Regex("^\\d{10}$");
            return regex.IsMatch(phone);
        }
    }
}
