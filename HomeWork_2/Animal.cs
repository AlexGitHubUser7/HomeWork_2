using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    abstract class Animal
    {
        string? Name {get; set;}
        int Age { get; init;}
        private int health = 100;

        public Animal(int age)
        {
            Age = age;
        }
        public Animal(string? name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Feed(int foodCount)
        {
            health += foodCount;
            if (health >= 100)
            {
                health = 100;
            }            
        }
        public void Punish(int punchCount)
        {
            health -= punchCount;
            if (health < 0)
            {
                health = 0;
            }
        }
        public virtual void Say()
        {
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Имя пимтомца не задано.");
            }
            else
            {
                Console.WriteLine($"Имя питомца: {Name}");
            }                
            Console.WriteLine($"Возраст питомца: {Age}");
        }
        public void SetName(string petName)
        {
            if (Name != null)
            {
                Console.WriteLine("Имя можно задать только один раз.");
                Console.WriteLine($"Питомца зовут {Name}");
            }            
            else
            {
                Name = petName;
                Console.WriteLine($"Вы назвали своего питомца {petName}");
            }               

        }
        public string GetName()
        {
            return Name;
        }
        public void HealthCheckUp()
        {            
            if (health >= 0 && health <= 50)
            {
                Console.WriteLine("Идикатор здоровья белый.");
            }
            else if (health >=51 && health <= 100)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Идикатор здоровья зеленый.");
                Console.ResetColor();
            }            
        }
        
    }
}
