using System;
using System.Collections.Generic;
using System.Text;

namespace Level_1.Lesson_7
{
    class Cross
    {
        static int SIZE_X = 5;
        static int SIZE_Y = 5;
        static int LengthWin = 4;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void PlayerStep()
        {
            int x;
            int y;
            do
            {
                Console.WriteLine($"Введите координаты X Y (1-{SIZE_X})");
                x = Int32.Parse(Console.ReadLine()) - 1;
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiStep()
        {
            int x;
            int y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        private static bool CheckWin(char sym)
        {
            for (int mode = 0; mode < 4; mode++)
            {
                int lengthX = 1;
                int lengthY = 1;
                bool reversY = false;
                switch (mode)
                {
                    // Проверка по горизонтали
                    case 0:
                        lengthX = LengthWin;
                        break;

                    //Проверка по вертикали
                    case 1:
                        lengthY = LengthWin;
                        break;

                    //Проверка по диагонали с левого верхнего края
                    case 2:
                        lengthX = LengthWin;
                        lengthY = LengthWin;
                        break;

                    //Проверка по диагонали с левого нижнего края
                    case 3:
                        lengthX = LengthWin;
                        lengthY = LengthWin;
                        reversY = true;
                        break;
                }
                for (int y = reversY ? field.GetLength(0) - 1 : 0; !reversY && (y <= field.GetLength(0) - lengthY) || reversY && (y + 1 >= lengthY); y += reversY ? -1 : 1)
                {
                    for (int x = 0; x <= field.GetLength(1) - lengthX; x++)
                    {
                        bool IsWin = true;
                        for (int j = 0; j < LengthWin; j++)
                        {
                            char CheckedSym = EMPTY_DOT;
                            switch (mode)
                            {
                                case 0:
                                    CheckedSym = field[y, x + j];
                                    break;
                                case 1:
                                    CheckedSym = field[y + j, x];
                                    break;
                                case 2:
                                    CheckedSym = field[y + j, x + j];
                                    break;
                                case 3:
                                    CheckedSym = field[y - j, x + j];
                                    break;
                            }
                            if (CheckedSym != sym)
                            {
                                IsWin = false;
                                break;
                            }
                        }
                        if (IsWin)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            InitField();
            PrintField();

            while (true)
            {
                PlayerStep();
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("Player Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
                AiStep();
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("SkyNet Win!");
                    break;
                }
                if (IsFieldFull())
                {
                    Console.WriteLine("DRAW");
                    break;
                }
            }
        }
    }
}
