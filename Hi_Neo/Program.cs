using System;
using System.Collections.Generic;
using System.Text;

namespace Hi_Neo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now}");
            Console.ReadLine();
        }
    }
}
