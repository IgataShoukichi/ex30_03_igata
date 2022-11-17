using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Worker : Person
    {
        public string occupation;
        public string Occupation
        {
            get { return occupation; }
        }
        public Worker(string occ,DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
            occupation = occ;
        }
    }
}
