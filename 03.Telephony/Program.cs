using System;

namespace _03.Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] sites = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Smartphone smartphone = new Smartphone();

            foreach (string number in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }
            if (sites.Length == 0)
            {
                Console.WriteLine("Browsing: !");
            }
            else
            {
                foreach (string site in sites)
                {
                    Console.WriteLine(smartphone.BrowseInWeb(site));
                }
            }
        }
    }
}
