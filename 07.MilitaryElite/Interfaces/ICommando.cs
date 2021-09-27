using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    interface ICommando : ISpecialisedSoldier
    {
        List<IMission> Missions { get; }
    }
}
