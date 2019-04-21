using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal c = new Cat("Kitty");
            c.Speak();
            Animal d = new Dog("Puppy");
            d.Speak();
            Animal f = new Fish("George");
            f.Speak();
            Console.ReadLine();
        }
    }

    class Animal
    {
        public bool tail;
        public bool fur;
        public bool fins;
        public string cry;
        public string name;

        public Animal() { }

        public void Speak()
        {
            Console.WriteLine(cry);
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class Cat : Animal
    {
        public Cat(string name)
        {
            tail = true;
            fur = true;
            fins = false;
            cry = "Meow";
            this.name = name;
        }
    }

    class Dog : Animal
    {
        public Dog(string name)
        {
            tail = true;
            fur = true;
            fins = false;
            cry = "Woof";
            this.name = name;
        }
    }

    class Fish : Animal
    {
        public Fish(string name)
        {
            tail = true;
            fur = false;
            fins = true;
            cry = "Blub";
            this.name = name;
        }
    }
}
