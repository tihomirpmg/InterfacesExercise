using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    class Citizen : IId, ICitizen
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
    }
}
