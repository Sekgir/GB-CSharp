using System;

namespace GB_CSharp
{
    class Program
    {
        enum Seasons
        {
            None = 0,
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine(GetFullName("Сергей", "Гудовщиков", "Константинович"));
            Console.WriteLine(GetFullName("Максим", "Селезнёв", "Олегович"));
            Console.WriteLine(GetFullName("Константин", "Попов", "Михаилович"));
            Console.WriteLine();

            Console.WriteLine("Задание №2");
            Console.Write("Введите набор чисел, разделенных пробелом: ");
            Console.WriteLine(GetSum(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Задание №3");
            Console.Write("Введите порядковый номер месяца: ");
            int number;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 || number > 12)
                {
                    Console.Write("Ошибка. Введите число от 1 до 12: ");
                }
            } while (number < 1 || number > 12);
            Seasons season = GetSeason(number);
            Console.WriteLine("Время года: " + GetSeasonStr(season));
            Console.WriteLine();

            Console.WriteLine("Задание №4");
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначчи: " + Fibonachi(n));
            Console.ReadKey();
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
        static int GetSum(string inputLine)
        {
            int sum = 0;

            //string[] numbers = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //foreach (string item in numbers)
            //{
            //    sum += Convert.ToInt32(item);
            //}

            string number = "";
            for (int i = 0; i <= inputLine.Length; i++)
            {
                if (i == inputLine.Length || inputLine[i] == ' ')
                {
                    if (number != "")
                    {
                        sum += Convert.ToInt32(number);
                        number = "";
                    }
                }
                else
                {
                    number += inputLine[i];
                }
            }
            return sum;
        }
        static Seasons GetSeason(int number)
        {
            Seasons season = Seasons.None;
            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    season = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Seasons.Autumn;
                    break;
            }
            return season;
        }
        static string GetSeasonStr(Seasons season)
        {
            string seasonStr = "";
            switch (season)
            {
                case Seasons.Winter:
                    seasonStr = "Зима";
                    break;
                case Seasons.Spring:
                    seasonStr = "Весна";
                    break;
                case Seasons.Summer:
                    seasonStr = "Лето";
                    break;
                case Seasons.Autumn:
                    seasonStr = "Осень";
                    break;
            }
            return seasonStr;
        }
        static int Fibonachi(int n)
        {
            return Fibonachi(n, out _);
        }
        static int Fibonachi(int n, out int f1)
        {
            f1 = 0;
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int f2; //Число Фибоначчи n - 2
                f1 = Fibonachi(n - 1, out f2); //Число Фибоначчи n - 1
                return f1 + f2;
            }
        }
    }
}
