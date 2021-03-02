using System;
using System.IO;

namespace GB_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.ReadKey();
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1");
            Console.Write("Введите произвольный набор данных: ");
            string data = Console.ReadLine();
            File.WriteAllText("Task1.txt", data);
            Console.WriteLine("Данные записаны в файл Task1.txt");
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2");
            DateTime curTime = DateTime.Now;
            Console.WriteLine($"Текущее время: {curTime}");
            File.AppendAllText("startup.txt", curTime + Environment.NewLine);
            Console.WriteLine("Время записано в файл startup.txt");
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3");
            Console.WriteLine("Перечислите через запятую произвольное количество чисел диапазоном от 0 до 255: ");
            string data = Console.ReadLine();
            string[] numbers = data.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] bytes = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = Convert.ToInt32(numbers[i]);
                if (temp >= 0 && temp <= 255)
                {
                    bytes[i] = (byte)temp;
                }
            }
            File.WriteAllBytes("bytes.bin", bytes);
            Console.WriteLine("Данные записаны в файл bytes.bin");
        }
    }
}
