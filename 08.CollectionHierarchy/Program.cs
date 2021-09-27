﻿using System;

namespace _08.CollectionHierarchy
{
    public class Program
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in inputParts)
            {
                addCollection.Add(part);
                addRemoveCollection.Add(part);
                myList.Add(part);
            }

            int elementsToRemove = int.Parse(Console.ReadLine());
            for (int i = 0; i < elementsToRemove; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }

            Console.WriteLine(addCollection);
            Console.WriteLine(addRemoveCollection);
            Console.WriteLine(myList);
            addRemoveCollection.GetRemovedElements();
            myList.GetRemovedElements();
        }
    }
}
