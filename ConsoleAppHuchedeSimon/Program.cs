using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHuchedeSimon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentTime = DateTime.Now;
            if (currentTime > DateTime.Now.Date && currentTime < DateTime.Now.Date.AddHours(12))
            {
                Console.WriteLine("Morning Simon!");
            }
            else if (currentTime >= DateTime.Now.Date.AddHours(12) && currentTime < DateTime.Now.Date.AddHours(18))
            {
                Console.WriteLine("Good afternoon Simon!");
            }
            else 
            {
                Console.WriteLine("Good evening Simon");
            }
            var ispalindrome = Console.ReadLine();
            
            if (ispalindrome.SequenceEqual(ispalindrome.Reverse()))
            {
                
                Console.WriteLine("Well said!");
            }
            Console.ReadLine();
            var timeToSayBy = DateTime.Now;
            if (timeToSayBy > DateTime.Now.Date && timeToSayBy < DateTime.Now.Date.AddHours(12))
            {
                Console.WriteLine("Have a nice day Simon!");
            }
            else if (timeToSayBy >= DateTime.Now.Date.AddHours(12) && timeToSayBy < DateTime.Now.Date.AddHours(18))
            {
                Console.WriteLine("Have a nice afternoon Simon!");
            }
            else if(timeToSayBy >= DateTime.Now.Date.AddHours(18) && timeToSayBy < DateTime.Now.Date.AddHours(22))
            {
                Console.WriteLine("Have a nice evening Simon");
            }
            else
            {
                Console.WriteLine("Night night Simon");
            }
           Console.ReadLine();

        }
    }
}
