using System;
using System.Threading;

namespace Dark_Woods
{
    class Story
    {
        static void Main()
        {
            for (; ; )
            {
                try
                {
                    Play();
                } catch (Exception e)
                {
                    Game.Message("Oh no! An error occurred!", ConsoleColor.Red);
                    Console.WriteLine(e);
                } finally
                {
                    Game.Message("Restarting...", ConsoleColor.Green);
                    Thread.Sleep(2000);
                }
            }
        }
        public static void Play()
        {
            Game.Message("Set a typing speed: 50 for default");
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Green;
            Game.GameSpeed = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            Game.Message("You wake up in a small tent, with some yummy food cooking outside.");
            Game.Character("???", "You're finally awake.");
            Game.Message("A young woman walks into the room, holding some soup.");
            Game.Message("You want to ask her something, but you feel too weak.");
            Game.Character("???", "Here.");
            Game.Message("She gives you the soup, and you gulp it down. Immediately, you feel better and you're able to talk.");
            Game.Character("You", "Who are you?", ConsoleColor.Green);

            Game.Character("???", "Firstly, who are you?");
            Console.Write("> ");
            Console.ForegroundColor = ConsoleColor.Green;
            Data.Name = Console.ReadLine();

            Game.Character("You", $"I'm {Data.Name}!", ConsoleColor.Green);
            Game.Character("???", $"Hello {Data.Name}. I'm Ava.");
            Game.Message("You want to know where you are, so you ask Ava.");
            Game.Character("Ava", "I actually don't know. I also just woke up, like you.");
            Game.Character("Ava", "You should go out. But be careful.");
            Item stickItem = new Item
            {
                Name = "Stick",
                Description = "A common stick used for combat. Deals 2-4 damage.",
                Effect = "attack",
                MinAttack = 2,
                MaxAttack = 4
            };
            stickItem.Announce();

            Item appleItem = new Item
            {
                Name = "Apple",
                Description = "A sweet, fresh & red apple. Restores 4 health.",
                EffectValue = 4
            };
            appleItem.Announce();

            Enemy e = new Enemy
            {
                Name = "Hoppy",
                MaxHealth = 5,
                MinAttack = 1,
                MaxAttack = 2
            };
            Data.Foes.Add(e);
            stickItem.Use();

            Game.End();
        }
    }
}