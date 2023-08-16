using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    // Flyweight Interface
    // This is an interface that defines the members of the flyweight objects.
    public interface IShape
    {
        void Draw();
    }
}
