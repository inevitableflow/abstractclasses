using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclassesp2
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; } 
        public float Height { get; set; }
        public float Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
