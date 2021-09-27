using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    class AddCollection : IAddable
    {
        private List<string> data;
        private List<int> indexes;
        public void Add(string element)
        {
            int index = this.data.Count;
            this.indexes.Add(index);
            this.data.Add(element);
        }
        public AddCollection()
        {
            this.data = new List<string>();
            this.indexes = new List<int>();
        }

        public override string ToString()
        {
            return $"{string.Join(" ", this.indexes)}";
        }
    }
}
