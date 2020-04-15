using System;
using System.Threading;
using System.Collections.Generic;

namespace Dark_Woods
{
    class Program
    {
        public static List<Item> Items = new List<Item>();
        static void Main()
        {
            for (; ; )
            {
                try
                {
                    Play();
                } catch (Exception e)
                {
                    Message("Oh no! An error occurred!", ConsoleColor.Red);
                    Console.WriteLine(e);
                } finally
                {
                    Message("Restarting...", ConsoleColor.Green);
                    Thread.Sleep(2000);
                }
            }
        }

        public static void Play()
        {
            new Item
            {
                Name = "Twig",
                Description = "A random twig you found."
            };
            throw new Exception();
        }

        public static void Message(string say, ConsoleColor color) //Move and fix this later
        {
            Console.ForegroundColor = color;
            foreach (char letter in say)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
