using System;

namespace Inheritance
{
    class Cat : Animal
    {
        public string catBreed;
        public string CatBreed
        {
            get { return catBreed; }
        }
        public Cat(string cat, DateTime bd, string n, float w, float h, float d, float we) : base(bd, n, w, h, d, we)
        {
            catBreed = cat;
        }

    }
}