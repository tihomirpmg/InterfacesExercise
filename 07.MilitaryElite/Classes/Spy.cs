using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Classes
{
    class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber):base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString()).Append($"Code Number: {this.CodeNumber}");
            return sb.ToString();
        }
    }
}
