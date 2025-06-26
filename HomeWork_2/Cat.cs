using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Cat : Animal
    {
        public Cat(int age) : base(age)
        {
        }
        public Cat(string? name, int age) : base(name, age)
        {
        }
        public override void Say()
        {
            base.Say();
            Console.WriteLine("Мяу!");
        }
    }
}
