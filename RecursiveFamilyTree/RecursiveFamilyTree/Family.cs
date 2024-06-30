// Defines Family class obj (includes recursive methods)
using System;
using System.Collections.Generic;

class Family
{
    List<Person> family = new List<Person>();  // family tree to iterate

    public void addPerson(string name, int parent1, int parent2)
    {
        //This method adds a person to the tree.
        family.Add(new Person(name, parent1, parent2));
    }

    public int getIDFromName(string name)
    {
        //This method converts a name to an id
        foreach (Person x in family)
        {
            if (x.getName() == name)
            {
                return x.getID();
            }
        }
        return -1;
    }

    public string getNameFromID(int id)
    {
        //This method converts an id to a name.
        foreach (Person x in family)
        {
            if (x.getID() == id)
            {
                return x.getName();
            }
        }
        return "Unknown";
    }

    public string parentRelationship(string current)
    {
        //This method calculates the word for a parent, grandparent, great grandparent etc. 
        if (current.Equals("Self"))
        {
            return "Parent";
        }
        else if (current.Equals("Parent"))
        {
            return "GrandParent";
        }
        else
        {
            return "Great " + current;
        }
    }

    public string childRelationship(string current)
    {
        //This method calculates the word for a child, grandchild, great grandchild etc. 
        if (current.Equals("Self"))
        {
            return "Child";
        }
        else if (current.Equals("Child"))
        {
            return "GrandChild";
        }
        else
        {
            return "Great " + current;
        }
    }

    public string everyone()
    {
        //This method gives you a list of all people in the tree.
        string returnString = "";
        foreach (Person x in family)
        {
            returnString += x.getID() + ") " + x.getName() + "\n";
        }
        return returnString;
    }

    public List<int> getChildrenIDs(int id)
    {
        List<int> childList = new List<int>();  // return List, stores child IDs
        foreach (Person p in family)             // loop thru family tree
        {
            // if parent1 or parent2 ID == arg id, then p is a child of arg id
            if (p.getParent1() == id || p.getParent2() == id)
            {
                childList.Add(p.getID());  // add to List
            }
        }
        return childList;
    }

    public int[] getParents(int ID)
    {
        int[] parentArr = new int[2];  // return arr of parent IDs
        foreach (Person p in family)    // loop thru List
        {
            if (p.getID() == ID)        // find target child ID
            {
                parentArr[0] = p.getParent1();  // add target's getParent1()
                parentArr[1] = p.getParent2();  // add target's getParent2()
            }
        }
        return parentArr;
    }

    public void printParents(int childID, string relationship)
    {
        // This method prints all ancestors & relationships of initial arg childID.

        if (childID != -1)  // recursive case (base case is implicit, -1 = unknown)
        {
            Console.WriteLine($"{relationship} {getNameFromID(childID)}");  // main purpose of recurring
            int[] parents = getParents(childID);                            // returns int[2], resets ea recur
            relationship = parentRelationship(relationship);                // set next relationship
            printParents(parents[0], relationship);                         // recur on 1st parent
            printParents(parents[1], relationship);                         // recur on 2nd parent 
        }
    }

    public void printChildren(int parentID, string relationship)
    {
        // This method prints all descendents & relationships of initial arg parentID.

        if (parentID != -1)  // recursive case (base case is implicit, -1 = unknown)
        {
            Console.WriteLine($"{relationship} {getNameFromID(parentID)}");  // purpose of recurring
            relationship = childRelationship(relationship);                  // set next relationship
            List<int> children = getChildrenIDs(parentID);                   // reset with curr children
            foreach (int childID in children)
            {
                printChildren(childID, relationship);  // must loop recurs due to unknown List len

            }
        }
    }
}