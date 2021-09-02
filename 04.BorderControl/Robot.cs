using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    class Robot : IId, IRobot
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
