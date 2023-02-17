using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasses
{
    public abstract class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.Write("Dog's name: ");
             string dogName = Console.ReadLine();

             Console.Write("Dog's colour: ");
             string dogColour = Console.ReadLine();

             Console.Write("Dog's age (year): ");
             float dogAge = float.Parse(Console.ReadLine());

             Dog dog = new Dog()
             {
                 Name = dogName,
                 Colour = dogColour,
                 Age = dogAge
             };
             */

            Dog dog = new Dog()
            {
                Name = "Bidu",
                Colour = "Blue",
                Age = 3
            };

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Age);
            dog.Eat();

            /*
            Console.Write("Cat's name: ");
            string catName = Console.ReadLine();

            Console.Write("Cat's colour: ");
            string catColour = Console.ReadLine();

            Console.Write("Cat's age (year): ");
            float catAge = float.Parse(Console.ReadLine());

            Cat cat = new Cat()
            {
                Name = catName,
                Colour = catColour,
                Age = catAge
            };
            */

            Cat cat = new Cat()
            {
                Name = "Mingau",
                Colour = "White",
                Age = 4
            };

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Age);
            cat.Eat();
        }
    }

}

