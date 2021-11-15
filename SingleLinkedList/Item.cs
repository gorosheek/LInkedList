using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Item<T>
    {
        public T Value { get; set; }
        public Item<T> NextItem { get; set; }
    }
}
