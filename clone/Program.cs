using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle("red",20);
            c1.Draw();

            Circle c2 = (Circle)c1.Clone();
            c2.Draw();
            c2.color = "green";
            c2.size = 30;
            c2.Draw();
        }
    }
}
