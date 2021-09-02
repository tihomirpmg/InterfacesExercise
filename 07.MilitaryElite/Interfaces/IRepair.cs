using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    interface IRepair
    {
        string PartName { get; }

        int HoursWorked { get; }
    }
}
