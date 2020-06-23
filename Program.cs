using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            var David = new Human("David");
            var Robert = new Human("Robert", 2,20, 10, 40 );
            Robert.Attack(David);
        }

        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;

            public int Health 
            {
                get { return health; }
                set { health = value; }
            }

            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                Health = 100;
            }

            public Human(string name, int strength, int intelligence, int dexterity, int health)
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                Health = health;
            }
    
            public void Attack(Human target)
            {
                var Target = (Human)target;
                Target.Health -= Strength * 5;
                var damage = Target.Health;
                Console.WriteLine($"{Name} attacted {Target.Name} for {damage} points");
                Console.WriteLine("Current Target status is " + Target.ToString());
            }
            public override string ToString()
            {
                return $"Name = {Name}, Stength = {Strength}, Intelligence = {Intelligence}, Dexterity = {Dexterity}, Health = {Health}";
            }
        }

    }
}
