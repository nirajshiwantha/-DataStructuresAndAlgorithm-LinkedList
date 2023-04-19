using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedLists.TraversalAlgorithms
{
    public class LinkedList
    {
        // define the Node class
        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        // define the head of the linked list
        private Node Head;

        // define the constructor for the linked list
        public LinkedList()
        {
            this.Head = null;
        }

        // define the method to add a new node to the linked list
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                Node currentNode = this.Head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }
        }

        // define the method to perform linear traversal of the linked list
        public void LinearTraversal()
        {
            Node currentNode = this.Head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }
}