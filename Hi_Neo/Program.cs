using System;
using System.Collections.Generic;
using System.Text;

namespace Hi_Neo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now}");
            Console.ReadLine();
        }
    }
}
