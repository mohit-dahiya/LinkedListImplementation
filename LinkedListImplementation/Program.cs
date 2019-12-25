using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    class LinkedList
    {
        Node head;
        class Node
        {
            public int Value;
            public Node NextElementAddress;

            public Node()
            {

                NextElementAddress = null;
            }
        }

        public void Flush_List()
        {
            head = null;
        }

        #region CreateLinkedList
        /// <summary>
        /// Create a hard coded Linked List
        /// </summary>
        public void CreateLinkedList()
        {
            if(head == null)
            {
                Node temp = new Node();
                temp.Value = 1001;
                head = temp;

                Node temp2 = new Node();
                temp2.Value = 1002;
                temp.NextElementAddress = temp2;

                Node temp3 = new Node();
                temp3.Value = 1003;
                temp2.NextElementAddress = temp3;
            }
            else
            {
                Node temp = head.NextElementAddress;
                while (temp.NextElementAddress != null)
                {
                    temp = temp.NextElementAddress;
                }
                Node temp4 = new Node();
                temp4.Value = 1004;
                temp.NextElementAddress = temp4;

                Node Temp5 = new Node();
                Temp5.Value = 1005;
                temp4.NextElementAddress = Temp5;
            }
        }

        #endregion

        #region Add Element
        /// <summary>
        /// Add a new element at the end of the list.
        /// </summary>
        /// <param name="val"></param>
        public void AddElement(int val)
        {
            if(head == null)
            {
                Node temp = new Node();
                temp.Value = val;
                head = temp;
                return;
            }

            Node lastTempNode = head;
            while (lastTempNode.NextElementAddress != null)
            {
                lastTempNode = lastTempNode.NextElementAddress;
            }

            Node lastNode = new Node();
            lastNode.Value = val;
            lastTempNode.NextElementAddress = lastNode;
        }
        #endregion

        #region Add Element between list
        /// <summary>
        /// Add a new element between of the list
        /// </summary>
        /// <param name="val"></param>
        public void AddElementBetween(int elementVal, int newValue)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node prev = head;

            while (prev.Value != elementVal)
            {
                if (prev.NextElementAddress == null)
                {
                    Console.WriteLine("Value is not available in the list.");
                    return;
                }
                prev = prev.NextElementAddress;
            }
            Node nextElement = prev.NextElementAddress;
            Node newElement = new Node();
            newElement.Value = newValue;
            newElement.NextElementAddress = nextElement;
            prev.NextElementAddress = newElement;
        }
        #endregion

        #region Print all the values
        /// <summary>
        /// Print all list items.
        /// </summary>
        public void PrintValues()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Node temp = head;
            while (temp.NextElementAddress != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.NextElementAddress;
            }
            Console.WriteLine(temp.Value);
        }
        #endregion

        #region Delete an item
        /// <summary>
        /// Delete an item from the list
        /// </summary>
        /// <param name="val"></param>
        public void DeleteItem(int val)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Node temp = head;
            Node prev = null;
            while (temp.Value != val)
            {
                if (temp.NextElementAddress == null)
                {
                    Console.WriteLine("Element not found!");
                }
                prev = temp;
                temp = temp.NextElementAddress;
            }

            prev.NextElementAddress = temp.NextElementAddress;
        }
        #endregion

        #region Reverse a list
        /// <summary>
        /// Reverse a list
        /// </summary>
        public void ReverseList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            Node prevElement = null;
            Node currentElement = head;
            Node tempElement = null;

            while (currentElement != null)
            {
                tempElement = currentElement.NextElementAddress;
                currentElement.NextElementAddress = prevElement;
                prevElement = currentElement;
                currentElement = tempElement;
            }
            head = prevElement;
        }
        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.CreateLinkedList();
            linkedList.CreateLinkedList();
            linkedList.CreateLinkedList();

            //Flush linked list
            linkedList.Flush_List();

            linkedList.AddElement(10);
            linkedList.AddElement(20);
            linkedList.AddElement(30);
            linkedList.AddElement(40);
            linkedList.AddElement(50);

            linkedList.AddElementBetween(10, 1001);
            linkedList.AddElementBetween(20, 2001);
            linkedList.AddElementBetween(30, 3001);
            linkedList.AddElementBetween(40, 4001);
            linkedList.AddElementBetween(50, 5001);


            //Print all the items
            linkedList.PrintValues();

            //Delete an item
            linkedList.DeleteItem(1001);
            linkedList.DeleteItem(2001);
            linkedList.DeleteItem(3001);
            linkedList.DeleteItem(4001);
            linkedList.DeleteItem(5001);

            linkedList.ReverseList();

            //Print all the items
            linkedList.PrintValues();

            //Flush linked list
            linkedList.Flush_List();

            //Must show "list is empty"
            linkedList.AddElementBetween(10, 1001);

        }
    }

}
