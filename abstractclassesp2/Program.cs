using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace abstractclassesp2
{
    internal class Program
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
            dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.Write("Cat's name: ");
            string catName = Console.ReadLine();

            Console.Write("Cat's colour: ");
            string catColour = Console.ReadLine();

            Console.Write("Cat's height (cm): ");
            float catHeight = float.Parse(Console.ReadLine());

            Console.Write("Cat's age (year): ");
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
            Console.WriteLine(cat.Age);
            cat.Eat();
            Console.WriteLine(cat.Cry());

            List<IAnimal> list = new List<IAnimal>();

            IAnimal animal = new Doguinho()
            {
                Name = "Clifford",
                Colour = "Red",
                Height = 10000,
                Age = 2
            };
            list.Add(animal);
            list.Add(dog);
            list.Add(cat);
            list.Add(new Cat()
            {
                Name = "George",
                Colour = "Orange",
                Height = 30,
                Age = 1
            });

            foreach(IAnimal a in list)
            {
                Console.WriteLine(a.Name);
                Console.WriteLine(a.Colour);
                Console.WriteLine(a.Height);
                Console.WriteLine(a.Age);
            }

            Console.ReadLine();
        }
    }
}
