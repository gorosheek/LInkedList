using System;

namespace SingleLinkedList
{
    public class SingleLinkedList<T>
    {
        public SingleLinkedList()
        {
            FirstItem = new Item<T>();
        }
        private Item<T> FirstItem { get; set; }
        public void Add(T value)
        {
            if (Equals(FirstItem.Value, default(T)))
            {
                FirstItem.Value = value;
            }
            else if (FirstItem.NextItem == null)
            {
                Item<T> item = new Item<T>() { Value = value };
                FirstItem.NextItem = item;
            }
            else
            {
                Item<T> temp = new Item<T>();
                temp = FirstItem.NextItem;
                while (temp.NextItem != null)
                {
                    temp = temp.NextItem;
                }
                temp.NextItem = new Item<T>() { Value = value };
            }
        }
        public override string ToString()
        {
            string result = "";
            Item<T> item = new Item<T>();
            item = FirstItem;
            while (item.NextItem != null)
            {
                result += $"{item.Value} ";
                item = item.NextItem;
            }
            result += $"{item.Value}";
            return result;
        }
    }
}
