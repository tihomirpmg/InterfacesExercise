using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}
