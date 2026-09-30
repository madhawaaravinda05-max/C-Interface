using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clone
{
    public interface ShapePrototype
    {
        ShapePrototype Clone();
        void Draw();

    }
}
