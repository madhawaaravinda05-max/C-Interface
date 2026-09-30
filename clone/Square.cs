using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone
{
    internal class Square : ShapePrototype
    {
        public String type;

        public Square(string type)
        {
            this.type = type;
        }

        public ShapePrototype Clone()
        {
            return new Square(this.type);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {type} square.");
        }
    }
}
