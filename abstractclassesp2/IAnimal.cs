using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclassesp2
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        float Height { get; set; }
        float Age { get; set; }

        void Eat();
        string Cry();
    }
}
