using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    class Smartphone : IPhone, IBrowsable
    {
        public string Call(string number)
        {
            if (number.All(Char.IsDigit))
            {
                return $"Calling... {number}";
            }
            else
            {
                return "Invalid number!";
            }
        }
        public string BrowseInWeb(string site)
        {
            if (site.Any(Char.IsDigit))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {site}!";
            }
        }
    }
}
