using System;
using System.Collections.Generic;

namespace DSLinkedList
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //Adding elements to the linked list
            linkedList.Add(70);
            linkedList.Display();
            int position = linkedList.search(70);
            Console.WriteLine("index position of elements 70 is " + position);
            linkedList.InsertInParticulatPosition(position + 1, 30);
            linkedList.InsertInParticulatPosition(position + 1, 56);
            linkedList.Display();
        }
    }
}
