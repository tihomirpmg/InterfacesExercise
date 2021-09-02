using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    interface IMyList : IRemovable
    {
        int NumberOfElem{ get; }
    }
}
