using System;
using System.Collections.Generic;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //Adding elements to the linked list
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}
