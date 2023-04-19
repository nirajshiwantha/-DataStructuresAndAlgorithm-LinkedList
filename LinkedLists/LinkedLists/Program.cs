using LinkedLists.TraversalAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a new linked list
            LinkedList myList = new LinkedList();

            // add some elements to the linked list
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(8);
            myList.Add(5);

            // perform linear traversal of the linked list
            Console.WriteLine("Performing linear traversal...");
            myList.LinearTraversal();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
