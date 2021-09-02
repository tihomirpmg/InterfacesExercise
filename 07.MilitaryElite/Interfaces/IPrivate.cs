using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}
