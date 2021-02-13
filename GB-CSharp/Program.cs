using System;

namespace GB_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();
            string curDate = DateTime.Now.ToString("d");
            Console.WriteLine($"Привет, {username}, сегодня {curDate}");

            Console.ReadKey();
        }
    }
}
