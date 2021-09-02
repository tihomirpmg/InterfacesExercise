using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Classes
{
    class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corp):base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public string Corp { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).Append($"Corps: {this.Corp}");
            return sb.ToString();
        }
    }
}
