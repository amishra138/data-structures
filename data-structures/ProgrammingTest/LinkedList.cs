﻿using System;

namespace ProgrammingTest
{
    /// <summary>
    /// Program to count number of nodes in a linked list
    /// </summary>
    public class LinkedList
    {
        Node head;

        public void RunProgram()
        {
            LinkedList llist = new LinkedList();
            llist.Push(1);
            llist.Push(3);
            llist.Push(1);
            llist.Push(2);
            llist.Push(1);

            Console.WriteLine($"Linked list count by iterative method: {llist.GetCountByInterative()}");

            Console.WriteLine($"Linked list count by iterative method: {llist.GetCountByRecursive()}");
        }

        public void Push(int value)
        {
            Node newNode = new Node(value)
            {
                Next = head
            };

            head = newNode;
        }

        public int GetCountByInterative()
        {
            Node temp = head;
            int count = 0;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        /// <summary>
        /// If head is null return 0
        /// </summary>
        /// <returns></returns>
        public int GetCountByRecursive() => getCountRec(head);

        private int getCountRec(Node node)
        {
            if (node == null)
                return 0;
            return 1 + getCountRec(node.Next);
        }
    }

    public class Node
    {
        public int Data { get; private set; }
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
