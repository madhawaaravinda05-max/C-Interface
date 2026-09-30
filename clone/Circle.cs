using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone
{
    public class Circle:ShapePrototype
    {
        public string color;

        public Circle(string color)
        {
            this.color = color;
        }

        public ShapePrototype Clone()
        {
            return new Circle(this.color);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {color} circle.");
        }
    }
}
