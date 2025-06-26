using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Dog : Animal
    {

        public Dog(int age) : base(age)
        {
        }
        public Dog(string? name, int age) : base(name, age)
        {
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("Гав!");
        }

    }
}
