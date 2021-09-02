using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    class Robot : IID, IRobot
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; }

        public string Id { get; }
    }
}
