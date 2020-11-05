using System;
using System.Collections.Generic;
using System.Text;

namespace DSLinkedList
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        ///Method for Adding the elements to the the linked list
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Inserts the in particulat position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        internal Node InsertInParticulatPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("position out of range");
                }
            }
            return head;
        }
        /// <summary>
        /// Searches the specified element position
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        internal int search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node != null)
                {
                    if (node.data == value)
                    {
                        return count;
                    }
                    node = node.next;
                    count++;
                }
            }
            return count;
        }
    }
}
