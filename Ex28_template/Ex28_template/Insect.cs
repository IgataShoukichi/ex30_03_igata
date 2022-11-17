using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Insect :Animal
    {
        public string season;
        public string Season
        {
            get { return season; }
        }
        public Insect(string sea, DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
            season = sea;
        }

    }
}
