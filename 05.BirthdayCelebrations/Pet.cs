using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    class Pet : IPet, IBirthdate
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; }

        public string Birthday { get; }
    }
}
