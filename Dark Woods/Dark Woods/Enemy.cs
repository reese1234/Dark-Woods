using System;

namespace Dark_Woods
{
    class Enemy
    {
        public string Name { get; set; } = "";
        public int Health
        {
            get => MaxHealth;

            set { }
        }
        public int MaxHealth { get; set; } = 0;
        public int MinAttack { get; set; } = 0;
        public int MaxAttack { get; set; } = 0;

        public void Attack()
        {
            int damage = Game.Rnd(MinAttack, MaxAttack);
            Data.Health -= damage;
        }
    }
}