using System;
using System.Collections.Generic;

namespace Dark_Woods
{
    class Data
    {
        public static string Name { get; set; } = "";

        public static int Health = 50;
        public static int MaxHealth = 50;

        public static List<Item> Items = new List<Item>();
        public static List<Enemy> Foes = new List<Enemy>();
    }
}
