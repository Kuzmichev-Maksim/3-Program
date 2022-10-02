using System.Security.Cryptography;

namespace Практическая_2___3_программы
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Игра Угадай число");
                Console.WriteLine("2 - Таблица умножения");
                Console.WriteLine("3 - Вывод делителей числа");
                Console.WriteLine("Выберете номер программы: ");
                int NumberGame = Convert.ToInt32(Console.ReadLine());
                switch (NumberGame)
                {
                    case 1:
                        FirstGame();
                        break;
                    case 2:
                        TwightGame();
                        break;
                    case 3:
                        ThirdGame();
                        break;

                }   
            }
        }
        static void FirstGame()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(0, 100);
            Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте отгадать его");
            Console.WriteLine("Введите число:");
            while (true)
            {
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number > RandomNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                if (Number < RandomNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                if (Number == RandomNumber)
                {
                    Console.WriteLine("Поздравляю! Вы угадали число");
                    Main();
                }

            }
        }
        static void TwightGame()
        {
            int tablе = 9;
            for (int i = 1; i <= tablе; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= tablе; j++)
                {
                    Console.Write("{0}  ", i * j);
                }
            }   
            Console.WriteLine("");
            Main();
        } 
        static void ThirdGame()
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                int i = Convert.ToInt32(Console.ReadLine());
                for (int Num = 1; Num * Num < i; Num++)
                {
                    if (i % Num == 0)
                    {
                        Console.Write("{0}   {1}   ", Num, i / Num);
                    }
                }
                Console.WriteLine("");
                Main();
            }
        }    
    }   
}