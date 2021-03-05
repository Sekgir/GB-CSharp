using System;
using System.IO;
using System.Text.Json;

namespace GB_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SaveTreeEntities();
            Console.WriteLine();
            RunToDoList();
            Console.WriteLine();
            CheckStringArray();
            Console.WriteLine();
            CreateClassPerson();
            Console.ReadKey();
        }
        static void SaveTreeEntities()
        {
            Console.WriteLine("Задание №1");
            string pathDir = @"C:\Test";
            string fileName = "Tree.txt";
            SaveTreeDirAndFiles(pathDir, fileName);
            Console.WriteLine($"Список файлов и подкаталогов внутри каталога \"{pathDir}\" записан в файл \"{fileName}\"");
        }
        static void RunToDoList()
        {
            Console.WriteLine("Задание №2");
            ToDo[] toDo_list;
            try
            {
                toDo_list = LoadTasks("tasks.json");
            }
            catch (FileNotFoundException)
            {
                toDo_list = CreateToDoList();
            }
            Console.WriteLine("Список задач:");
            for (int i = 0; i < toDo_list.Length; i++)
            {
                Console.WriteLine("{0}. {1}{2}", i + 1, toDo_list[i].IsDone ? "[x]" : "", toDo_list[i].Title);
            }
            string temp;
            while (true)
            {
                Console.Write("Введите порядковый номер задачи, чтобы отметить ее выполнение, или оставить поле пустым для продолжения:");
                temp = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(temp))
                {
                    break;
                }
                int num_task = Convert.ToInt32(temp) - 1;
                toDo_list[num_task].IsDone = true;
            }
            SaveTasks(toDo_list, "tasks.json");
        }
        static ToDo[] CreateToDoList()
        {
            Console.WriteLine("Напишите задачу, чтобы добавить. Для остановки оставьте строку пустой.");
            string[] array = new string[0];
            while (true)
            {
                Console.Write("Введите задачу: ");
                string task = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(task))
                {
                    break;
                }
                else
                {
                    int index = array.Length;
                    Array.Resize<string>(ref array, array.Length + 1);
                    array[index] = task;
                }
            }
            ToDo[] toDo_list = new ToDo[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                toDo_list[i] = new ToDo(array[i]);
            }
            return toDo_list;
        }
        static void CheckStringArray()
        {
            Console.WriteLine("Задание №3");
            object[] arrays = new object[] { new string[4,5], new string[4, 4] { {"1", "2", "3", "4" }, { "1", "2", "Не число", "4" }, { "1", "2", "3", "4" }, { "1", "2", "3", "4" } },
                new string[4, 4] {{ "1", "2", "3", "4" }, { "1", "2", "3", "4" }, { "1", "2", "3", "4" }, { "1", "2", "3", "4" } } };
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine($"Массив {i + 1}.");
                try
                {
                    int sum = ArraySum((string[,])arrays[i]);
                    Console.WriteLine($"Сумма массива: {sum}");
                }
                catch (MyArraySizeException)
                {
                    Console.WriteLine("Исключение: Размер массива не соответствует требуемому");
                }
                catch (MyArrayDataException ex)
                {
                    Console.WriteLine($"Исключение: Данные в ячейке [{ex.IdRow}, {ex.IdColumn}] не удается преобразовать в число");
                }
            }
        }
        static void CreateClassPerson()
        {
            Console.WriteLine("Задание №4");
            Person[] persArray = new Person[5];
            persArray[0] = new Person("Фамилия1 Имя1", "Должность1", "email1@mailbox.com", "+7 (920) 111-11-11", 35000, 30);
            persArray[1] = new Person("Фамилия2 Имя2", "Должность2", "email2@mailbox.com", "+7 (920) 222-22-22", 50000, 41);
            persArray[2] = new Person("Фамилия3 Имя3", "Должность3", "email3@mailbox.com", "+7 (920) 333-33-33", 30000, 39);
            persArray[3] = new Person("Фамилия4 Имя4", "Должность4", "email4@mailbox.com", "+7 (920) 444-44-44", 55000, 50);
            persArray[4] = new Person("Фамилия5 Имя5", "Должность5", "email5@mailbox.com", "+7 (920) 555-55-55", 40000, 34);
            foreach (Person pers in persArray)
            {
                if (pers.Age > 40)
                {
                    pers.OutputInfo();
                    Console.WriteLine();
                }
            }
        }
        static void SaveTreeDirAndFiles(string pathDir, string outputFile)
        {
            File.WriteAllText(outputFile, "Список файлов и подкаталогов без рекурсии:" + Environment.NewLine);
            string[] temp = Directory.GetFileSystemEntries(pathDir, "*", SearchOption.TopDirectoryOnly);
            File.AppendAllLines(outputFile, temp);

            File.AppendAllText(outputFile, Environment.NewLine + "Список файлов и подкаталогов с рекурсией:" + Environment.NewLine);
            temp = Directory.GetFileSystemEntries(pathDir, "*", SearchOption.AllDirectories);
            File.AppendAllLines(outputFile, temp);
        }
        static ToDo[] LoadTasks(string pathFile)
        {
            return JsonSerializer.Deserialize<ToDo[]>(File.ReadAllText(pathFile));
        }
        static void SaveTasks(ToDo[] tasks, string pathFile)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(pathFile, json);
        }
        static int ArraySum(string[,] array)
        {
            if (array.GetLength(0) != 4 || array.GetLength(1) != 4)
            {
                throw new MyArraySizeException();
            }
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    try
                    {
                        sum += Convert.ToInt32(array[i, j]);
                    }
                    catch
                    {
                        throw new MyArrayDataException(i, j);
                    }
                }
            }
            return sum;
        }
    }
}
