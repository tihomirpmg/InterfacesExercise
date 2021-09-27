using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    interface IBuyer:ICitizen
    {
        int Food { get; }
        void BuyFood();
    }
}
