using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person:Animal
    {
        public Person(DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
        }
    }
}
