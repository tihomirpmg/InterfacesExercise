﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IId> ids = new List<IId>();
            GetIds(input, ids);
            string lastDigits = Console.ReadLine();
            DetainId(lastDigits, ids);
        }
        private static void GetIds(string input, List<IId> ids)
        {
            while (input != "End")
            {
                string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputParts.Length == 3)
                {
                    IId citizen = new Citizen(inputParts[0], int.Parse(inputParts[1]), inputParts[2]);
                    ids.Add(citizen);
                }
                else if (inputParts.Length == 2)
                {
                    IId robot = new Robot(inputParts[0], inputParts[1]);
                    ids.Add(robot);
                }
                input = Console.ReadLine();
            }
        }
        private static void DetainId(string lastDigits, List<IId> ids)
        {
            foreach (IId id in ids.Where(i => i.Id.EndsWith(lastDigits)))
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}
