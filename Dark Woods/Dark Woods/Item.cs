using System;
using System.Threading;

namespace Dark_Woods
{
    class Item
    {

        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Effect { get; set; } = "health";
        public int EffectValue { get; set; } = 0;
        public int UseTimes { get; set; } = 1;
        public int MinAttack { get; set; } = 0;
        public int MaxAttack { get; set; } = 0;

        public void Announce()
        {
            string letter = Name.Substring(0, 1).ToLower();

            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Game.Message($"You got an {Name}!");
            }
            else
            {
                Game.Message($"You got a {Name}!");
            }
            Thread.Sleep(400);
            Game.Message(Description, ConsoleColor.Gray);
            Thread.Sleep(400);
        }

        public void Use()
        {
            if (Effect == "health")
            {
                Data.Health += EffectValue;
                if (Data.Health > Data.MaxHealth)
                    Data.Health = Data.MaxHealth;
                Game.Message($"{Data.Health}/{Data.MaxHealth} health.", ConsoleColor.Yellow);
            }
            else if (Effect == "attack")
            {
                if (Data.Foes.Count == 0)
                {
                    Game.Message("You have nothing to attack.");
                } else
                {
                    int attack = Game.Rnd(MinAttack, MaxAttack);
                    int i = 0;
                    foreach (Enemy enemy in Data.Foes)
                    {
                        Game.Message($"({Game.Alphabet[i]}) {enemy.Name}: {enemy.Health}/{enemy.MaxHealth}");
                        i++;
                    }
                    
                }
            }
            else
            {
                Game.Message("Nothing happened.");
            }

            UseTimes--;
            if (UseTimes == 0)
            {
                Game.Message($"You cannot use your {Name} anymore.");
                Data.Items.Remove(this);

            }
            else
            {
                Game.Message($"You can use your {Name} {UseTimes} times more.");
            }
        }
    }
}