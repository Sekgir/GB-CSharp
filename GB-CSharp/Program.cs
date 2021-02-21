using System;

namespace GB_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            int[,] array1 = new int[5, 5];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = i * array1.GetLength(1) + j;
                    string text = new string(' ', i * array1.GetLength(1) + j) + array1[i, j];
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Задание №2");
            Console.WriteLine("Значения массива:");
            string[,] array2 = { { "Георгий", "+7 910 000-00-01" },
                { "Дмитрий", "+7 910 000-00-02" },
                { "Сергей", "email3@mail.ru" },
                { "Александр", "email4@mail.ru" },
                { "Михаил", "+7 910 000-00-05" }};
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                Console.WriteLine($"{array2[i, 0],-15}{array2[i, 1]}");
            }
            Console.WriteLine();

            Console.WriteLine("Задание №3");
            Console.Write("Введите текст:");
            string inputLine = Console.ReadLine();
            Console.Write("В обратном порядке:");
            for (int i = inputLine.Length - 1; i >= 0; i--)
            {
                Console.Write(inputLine[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Задание \"Морской бой\"");
            char[,] array3 =  { { 'O','O','O','O','O','O','O','X','X','O' },
                                { 'O','X','O','O','X','O','O','O','O','O' },
                                { 'O','O','O','O','X','O','O','O','O','O' },
                                { 'O','O','O','O','O','O','O','O','O','O' },
                                { 'O','O','O','O','O','O','X','X','X','O' },
                                { 'X','O','X','O','O','O','O','O','O','O' },
                                { 'X','O','X','O','O','O','O','O','O','O' },
                                { 'O','O','X','O','O','O','X','O','O','O' },
                                { 'O','O','X','O','O','O','X','O','O','X' },
                                { 'X','O','O','O','O','O','X','O','O','O' } };
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Задание №4");
            int[] array4 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Изначальный массив: ");
            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(array4[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Введите число для смещения:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = Math.Abs(n);
            for (int i = 0; i < count; i++)
            {
                int temp = 0;
                if (n > 0)
                {
                    temp = array4[array4.Length - 1];
                    for (int j = array4.Length - 1; j > 0; j--)
                    {
                        array4[j] = array4[j - 1];
                    }
                    array4[0] = temp;
                }
                //Не имеет смысла добавлять условие для n==0, т.к. с таким значением изначальный цикл ниразу не выполнится
                else
                {
                    temp = array4[0];
                    for (int j = 0; j < array4.Length - 1; j++)
                    {
                        array4[j] = array4[j + 1];
                    }
                    array4[array4.Length - 1] = temp;
                }
            }
            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(array4[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
