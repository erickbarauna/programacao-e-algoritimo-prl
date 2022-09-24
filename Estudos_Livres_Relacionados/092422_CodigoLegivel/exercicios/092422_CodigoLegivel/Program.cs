using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092422_CodigoLegivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int widgetsPurchased = 7;
            // Testing a change to the message.
            // int widgetsSold = 7;
            // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
            Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


            /* 
              This is a long comment 
              that spans multiple lines
              just to prove that it can
              be done.
            */




            /*
              The following code creates five random OrderIDs
              to test the fraud detection process.  OrderIDs 
              consist of a letter from A to E, and a three
              digit number. Ex. A123.
            */
            Random random = new Random();
            string[] orderIDs = new string[5];

            for (int i = 0; i < orderIDs.Length; i++)
            {
                int prefixValue = random.Next(65, 70);
                string prefix = Convert.ToChar(prefixValue).ToString();
                string suffix = random.Next(1, 1000).ToString("000");

                orderIDs[i] = prefix + suffix;
            }

            foreach (var orderID in orderIDs)
            {
                Console.WriteLine(orderID);
            }
        }
    }
}
