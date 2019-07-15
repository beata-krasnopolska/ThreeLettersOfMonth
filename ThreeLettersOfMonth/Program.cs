using System;

namespace ThreeLettersOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program displays the name of the first three letters of month of a year starting form current date");
            var today = DateTime.Today;

            DateTime now = DateTime.Now;
            Console.WriteLine("Today is: {0}", today);
            Console.WriteLine("The tweleve months are:");
            for(int i =0; i< 12; i++)
            {
                Console.WriteLine("{0}", now.ToString("MMM"));
                now = now.AddMonths(1);
            }
            
            Console.ReadKey();
        }
    }
}
