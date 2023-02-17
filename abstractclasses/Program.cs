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
            Console.Write("Dog's name: ");
            string dogName = Console.ReadLine();

            Console.Write("Dog's colour: ");
            string dogColour = Console.ReadLine();

            Console.Write("Dog's height (cm): ");
            float dogHeight = float.Parse(Console.ReadLine());

            Console.Write("Dog's age (year): ");
            float dogAge = float.Parse(Console.ReadLine());

            Dog dog = new Dog()
            {
                Name = dogName,
                Colour = dogColour,
                Height = dogHeight,
                Age = dogAge
            };

            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Colour);
            Console.WriteLine(dog.Height);
            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.Eat());

            Console.Write("Dog's name: ");
            string catName = Console.ReadLine();

            Console.Write("Dog's colour: ");
            string catColour = Console.ReadLine();

            Console.Write("Dog's height (cm): ");
            float catHeight = float.Parse(Console.ReadLine());

            Console.Write("Dog's age (year): ");
            float catAge = float.Parse(Console.ReadLine());

            Cat cat = new Cat()
            {
                Name = catName,
                Colour = catColour,
                Height = catHeight,
                Age = catAge
            };

            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Colour);
            Console.WriteLine(cat.Height);
            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.Eat());
        }
    }

}
