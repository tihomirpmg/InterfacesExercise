using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    interface ILeutenantGeneral : IPrivate
    {
        List<ISoldier> Privates { get; }
    }
}
