using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasses
{
    public abstract class Animal
    {
        static void Main(string[] args)
        {
        }
        string Name { get; set; }
        string Colour { get; set; }
        int Age { get; set; }

        internal abstract void Eat();

    }

}
