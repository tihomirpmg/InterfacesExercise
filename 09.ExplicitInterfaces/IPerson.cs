using System;
using System.Collections.Generic;
using System.Text;

namespace _09.ExplicitInterfaces
{
    interface IPerson
    {
        string Name { get; }

        int Age { get; }

        void GetName();
    }
}
