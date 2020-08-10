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
        public static bool ValidName(string name)
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

        //Validates that there are no numbers in input
        public static bool ValidText(string text)
        {
            Regex regex = new Regex("^[^0-9]+$");
            return regex.IsMatch(text);
        }

        //Validates Zip Code
        public static bool ValidZipCode(string zip)
        {
            Regex regex = new Regex("^\\d{5}(?:[-\\s]\\d{4})?$");
            return regex.IsMatch(zip);
        }

        //Validates money 
        public static bool ValidMoney(string money)
        {
            Regex regex = new Regex("^[0-9]{1,3}(?:,?[0-9]{3})*(?:\\.[0-9]{2})?$");
            return regex.IsMatch(money);
        }
    }
}
