﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    interface IRemovable : IAddable
    {
        void Remove();

        void GetRemovedElements();
    }
}
