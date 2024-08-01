// Class creates Node objs to use as references in BluRayCollection linked lists.
using BluRayLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluRayLinkedList
{
    internal class Node
    {
        // Nodes store data and point to next node.
        public BluRayDisc data;  // 1) a defined data type
        public Node next;        // 2) reference pointing to next node

        public int num;  // can hold as many data types as desired
    }
}
