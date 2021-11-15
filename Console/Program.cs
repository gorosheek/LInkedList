using SingleLinkedList;

namespace Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            while (true)
            {
                Console.Write("Enter: ");
                list.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine(list.ToString());
            }
        }
    }
}
