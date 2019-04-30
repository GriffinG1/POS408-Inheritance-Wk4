using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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

            Program sl = new Program();

            sl.Serialize(c);
            sl.DeSerialize(c);
            sl.Serialize(d);
            sl.DeSerialize(d);
            sl.Serialize(f);
            sl.DeSerialize(f);
        }

        void Serialize(Animal a) // Info taken from https://www.c-sharpcorner.com/article/serializing-objects-in-C-Sharp/
        {
            Stream s = File.Open("temp.dat", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, a);
            s.Close();  
        }

        void DeSerialize(Animal a)
        {
            Stream s = File.Open("temp.dat", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            a = (Animal) b.Deserialize(s);
            Console.WriteLine(a.name);
            s.Close();
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
