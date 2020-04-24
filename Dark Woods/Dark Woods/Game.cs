using System;
using System.Threading;

namespace Dark_Woods
{
    class Game
    {
        public static int GameSpeed = 50;

        public static void Message(string say, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char letter in say)
            {
                Console.Write(letter);
                Thread.Sleep(GameSpeed);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void Character(string name, string say, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.ForegroundColor = color;
            Console.Write($"{name}: ");
            Message(say, ConsoleColor.Gray);
        }

        public static int Rnd(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max + 1);
        }

        public static void End()
        {
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEND");
            for (; ; ) { Console.ReadLine(); }
        }

        public static string[] Alphabet = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    }
}
