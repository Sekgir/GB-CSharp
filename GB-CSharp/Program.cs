using System;

namespace GB_CSharp
{
    enum DaysOfTheWeek
    {
        Monday = 0b0000001,
        Tuesday = 0b0000010,
        Wednesday = 0b0000100,
        Thursday = 0b0001000,
        Friday = 0b0010000,
        Saturday = 0b0100000,
        Sunday = 0b1000000
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Console.Write("Введите минимальную температуру за сутки: ");
            double tempMin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки: ");
            double tempMax = Convert.ToDouble(Console.ReadLine());
            double tempAverage = (tempMax + tempMin) / 2;
            Console.WriteLine($"Средняя температура за сутки составляет: {tempAverage}\n");

            Console.WriteLine("Задание №2");
            Console.Write("Введите порядковый номер текущего месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());
            string result;
            switch (numMonth)
            {
                case 1:
                    result = "Январь";
                    break;
                case 2:
                    result = "Февраль";
                    break;
                case 3:
                    result = "Март";
                    break;
                case 4:
                    result = "Апрель";
                    break;
                case 5:
                    result = "Май";
                    break;
                case 6:
                    result = "Июнь";
                    break;
                case 7:
                    result = "Июль";
                    break;
                case 8:
                    result = "Август";
                    break;
                case 9:
                    result = "Сентябрь";
                    break;
                case 10:
                    result = "Октябрь";
                    break;
                case 11:
                    result = "Ноябрь";
                    break;
                case 12:
                    result = "Декабрь";
                    break;
                default:
                    result = "Данные введены некорректно";
                    break;
            }
            Console.WriteLine(result + "\n");

            Console.WriteLine("Задание №3");
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число является четным\n");
            }
            else
            {
                Console.WriteLine("Число является нечетным\n");
            }

            Console.WriteLine("Задание №4");
            int checkNum = 1111;
            string nameScore = "ООО Ромашка";
            DateTime curTime = DateTime.Now;
            string productName1 = "Молоко";
            double productPrice1 = 50.5;
            int productCount1 = 2;
            string productName2 = "Чай липтон";
            double productPrice2 = 100;
            int productCount2 = 1;
            double sum = productPrice1 * productCount1 + productPrice2 * productCount2;
            Console.WriteLine($"Кассовый чек №{checkNum}");
            Console.WriteLine($"{nameScore}");
            Console.WriteLine($"{curTime}");
            Console.WriteLine($"Товар\t\tЦена\tКол-во\tСтоимость");
            Console.WriteLine($"{productName1}\t\t{productPrice1}\t{productCount1}\t{productCount1 * productPrice1}");
            Console.WriteLine($"{productName2}\t{productPrice2}\t{productCount2}\t{productCount2 * productPrice2}");
            Console.WriteLine($"Итого: {sum}\n");

            Console.WriteLine("Задание №5");
            if ((numMonth == 12 || numMonth == 1 || numMonth == 2) && tempAverage > 0)
            {
                Console.WriteLine("Дождливая зима\n");
            }

            Console.WriteLine("Задание №6");
            int officeNum1 = 0b0011110;
            int officeNum2 = 0b1111111;
            Console.Write("Рабочие дни офиса №1:");
            //foreach (var value in Enum.GetValues(typeof(DaysOfTheWeek)))
            //{
            //    if (((int)value & officeNum1) == (int)value)
            //    {
            //        Console.Write($" {value}");
            //    }
            //}
            if (((int)DaysOfTheWeek.Monday & officeNum1) == (int)DaysOfTheWeek.Monday)
            {
                Console.Write($" {DaysOfTheWeek.Monday}");
            }
            if (((int)DaysOfTheWeek.Tuesday & officeNum1) == (int)DaysOfTheWeek.Tuesday)
            {
                Console.Write($" {DaysOfTheWeek.Tuesday}");
            }
            if (((int)DaysOfTheWeek.Wednesday & officeNum1) == (int)DaysOfTheWeek.Wednesday)
            {
                Console.Write($" {DaysOfTheWeek.Wednesday}");
            }
            if (((int)DaysOfTheWeek.Thursday & officeNum1) == (int)DaysOfTheWeek.Thursday)
            {
                Console.Write($" {DaysOfTheWeek.Thursday}");
            }
            if (((int)DaysOfTheWeek.Friday & officeNum1) == (int)DaysOfTheWeek.Friday)
            {
                Console.Write($" {DaysOfTheWeek.Friday}");
            }
            if (((int)DaysOfTheWeek.Saturday & officeNum1) == (int)DaysOfTheWeek.Saturday)
            {
                Console.Write($" {DaysOfTheWeek.Saturday}");
            }
            if (((int)DaysOfTheWeek.Sunday & officeNum1) == (int)DaysOfTheWeek.Sunday)
            {
                Console.Write($" {DaysOfTheWeek.Sunday}");
            }
            Console.WriteLine();
            Console.Write("Рабочие дни офиса №2:");
            //foreach (var value in Enum.GetValues(typeof(DaysOfTheWeek)))
            //{
            //    if (((int)value & officeNum2) == (int)value)
            //    {
            //        Console.Write($" {value}");
            //    }
            //}
            if (((int)DaysOfTheWeek.Monday & officeNum2) == (int)DaysOfTheWeek.Monday)
            {
                Console.Write($" {DaysOfTheWeek.Monday}");
            }
            if (((int)DaysOfTheWeek.Tuesday & officeNum2) == (int)DaysOfTheWeek.Tuesday)
            {
                Console.Write($" {DaysOfTheWeek.Tuesday}");
            }
            if (((int)DaysOfTheWeek.Wednesday & officeNum2) == (int)DaysOfTheWeek.Wednesday)
            {
                Console.Write($" {DaysOfTheWeek.Wednesday}");
            }
            if (((int)DaysOfTheWeek.Thursday & officeNum2) == (int)DaysOfTheWeek.Thursday)
            {
                Console.Write($" {DaysOfTheWeek.Thursday}");
            }
            if (((int)DaysOfTheWeek.Friday & officeNum2) == (int)DaysOfTheWeek.Friday)
            {
                Console.Write($" {DaysOfTheWeek.Friday}");
            }
            if (((int)DaysOfTheWeek.Saturday & officeNum2) == (int)DaysOfTheWeek.Saturday)
            {
                Console.Write($" {DaysOfTheWeek.Saturday}");
            }
            if (((int)DaysOfTheWeek.Sunday & officeNum2) == (int)DaysOfTheWeek.Sunday)
            {
                Console.Write($" {DaysOfTheWeek.Sunday}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
