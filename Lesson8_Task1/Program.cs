using System;
using System.Diagnostics;

namespace Lesson8_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTaskManager();
            Console.WriteLine("Нажмите кнопку, чтобы продолжить...");
            Console.ReadKey();
        }
        static void ShowTaskList()
        {
            Process[] processArray = Process.GetProcesses();
            Console.WriteLine("{0, 11} | {1}", "ID процесса", "Имя процесса");
            foreach (Process process in processArray)
            {
                Console.WriteLine("{0, 11} | {1}", process.Id, process.ProcessName);
            }
        }
        static void ShowCommands()
        {
            Console.WriteLine("Список возможных действий: 1 - вывести список процессов; 2 - остановить какой-либо процесс; 3 - выход.");
            Console.Write("Выберите одно из действий: ");
        }
        static void KillProcess(string processString)
        {
            int idProcess = -1;
            try
            {
                idProcess = Convert.ToInt32(processString);
            }
            catch { }
            Process[] processArray = Process.GetProcesses();
            if (idProcess != -1)
            {
                Array.Find(processArray, process => process.Id == idProcess)?.Kill();
            }
            else
            {
                Process[] targetProcess = Array.FindAll(processArray, process => process.ProcessName == processString);
                foreach (Process process in targetProcess)
                {
                    process.Kill();
                }
            }
        }
        static void RunTaskManager()
        {
            int numCommand;
            do
            {
                numCommand = 0;
                ShowCommands();
                try
                {
                    numCommand = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (numCommand)
                {
                    case 1:
                        ShowTaskList();
                        break;
                    case 2:
                        Console.Write("Для остановки введите ID или имя процесса: ");
                        KillProcess(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            } while (numCommand != 3);
        }
    }
}
