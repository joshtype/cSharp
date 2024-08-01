// Class creates/edits collections of BluRayDisc objs using linked list.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BluRayLinkedList
{
    internal class BluRayCollection
    {
        private Node head = null;  // init first node of new linked list

        // METHOD
        public void add(string title, string director, int year, double cost)
        {
            // Creates a new node that references a new obj & inserts at end of linked list.
            BluRayDisc newDisk = new BluRayDisc(title, director, year, cost);
            Node newNode = new Node();  // new node to insert
            newNode.data = newDisk;     // set node to ref new obj

            // insert new node at end of linked list
            if (head == null)  // if null, list is empty
            {
                head = newNode;  // set head to reference new obj
            }
            else
            {
                Node curr = head;         // use new reference
                while (curr.next != null)  // until null reference found
                {
                    curr = curr.next;    // move to next pointer
                }
                curr.next = newNode;        // null ref found, update ref
                newNode.next = null;        // last node reference = null
            }
        }

        // METHOD
        public void addFront(string title, string director, int year, double cost)
        {
            // Creates a new node that references a new obj, inserts at front of linked list.
            BluRayDisc newDisk = new BluRayDisc(title, director, year, cost);
            Node newNode = new Node();
            Node nextNode = new Node();
            newNode.data = newDisk;

            head.next = nextNode;
            newNode.next = head;       // change head to refernce new node
            head = newNode;  // change data referenced by head
        }

        // METHOD
        public void remove(string title)
        {
            // Finds and removes a node based on obj attribute in node's data.

            Node curr = this.head;        // start at head
            Node prev = curr;             // store node copy
            if (curr.data.title == title)  // check obj title
            {
                this.head = curr.next;   // reassing reference
                return;
            }
            while (curr.data.title != title)
            {
                prev = curr;       // copy current node
                curr = curr.next;  // move to next node
                if (curr == null)  // end reached
                {
                    Console.WriteLine("Title not found.");
                    return;
                }
                prev.next = curr.next;  // merge references

            }
        }

        // Method: Show data in first node (referenced by head).
        public void showFirst()
        {
            Console.WriteLine(head.data.ToString());
        }

        // Method: Show data in last node (references null).
        public void showLast()
        {
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;  // move to next node               
            }
            Console.WriteLine(curr.data.ToString());
        }

        // Method: Display BlueRayDisk objects in linked list.
        public void showAll()
        {
            // traverse linked list, invoking ToString() on ea node
            Node curr = head;
            if (curr == null)  // if empty
            {
                Console.WriteLine("No bluerays in library yet.");
            }
            else
            {
                while (curr != null)  // until last node
                {
                    Console.WriteLine(curr.data.ToString());  // display curr.data
                    curr = curr.next;      // move to next node
                }
            }
        }
    }
}
