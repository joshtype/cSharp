// Defines Person class obj
using System;

class Person
{
    private int id;
    public static int next_id = 0;
    private string name;

    private int parent_id1;
    private int parent_id2;

    public Person(string name, int parent1, int parent2)
    {
        id = next_id++;
        this.name = name;
        parent_id1 = parent1;
        parent_id2 = parent2;
    }

    public int getParent1()
    {
        return parent_id1;
    }

    public int getParent2()
    {
        return parent_id2;
    }

    public int getID()
    {
        return id;
    }

    public string getName()
    {
        return name;
    }

    public override string ToString()
    {
        return name;
    }

}