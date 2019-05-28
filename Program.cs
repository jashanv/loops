using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string actualpin = "0786";
            int count = 0;
            string pin;
            do
            {
                pin = Console.ReadLine();
                count++;
            }
            while (pin != actualpin && count < 3);
            if (pin == actualpin)
                Console.WriteLine("Welcome user");
            else
                Console.WriteLine("Account Locked");
        }
    }
}
