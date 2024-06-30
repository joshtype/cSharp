// (A5) Recursive Family Tree (Lady Gaga Driver)
// @author      Joshua Gregory
// @version     1.0 (June 2024)
using System;

class Program
{
    public static void Main(string[] args)
    {
        Family myFamily = new Family();

        myFamily.addPerson("John Bissett", -1, -1);
        myFamily.addPerson("Wilhelm Busart", -1, -1);
        myFamily.addPerson("John Leach", -1, -1);
        myFamily.addPerson("Georgianna Morningstar", -1, -1);
        myFamily.addPerson("John Campana", -1, -1);
        myFamily.addPerson("Anthony Germanotta", -1, -1);
        myFamily.addPerson("Rosaria X", -1, -1);
        myFamily.addPerson("George Lindsey Bissett", 0, 1);
        myFamily.addPerson("Sarah Ann Leach Sally", 2, 3);
        myFamily.addPerson("James Ferrie", -1, -1);
        myFamily.addPerson("Minnie Campana", 4, -1);
        myFamily.addPerson("Joseph Germanotta", 5, 6);
        myFamily.addPerson("Angeline C", -1, -1);
        myFamily.addPerson("Paul Douglas Bissett", 7, 8);
        myFamily.addPerson("Veronica R Ferrie", 9, 10);
        myFamily.addPerson("Joseph A Germanotta", 11, 12);
        myFamily.addPerson("Cynthia B. Bissett", 13, 14);
        myFamily.addPerson("Stephanie Joanne Germanotta", 15, 16);
        myFamily.addPerson("Natali Germanotta", 15, 16);

        bool done = false;

        do
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("1. Add a person to the tree");
            Console.WriteLine("2. See a person's ancestors");
            Console.WriteLine("3. See a person's descendants");
            Console.WriteLine("4. Quit");

            int choice = Int32.Parse(Console.ReadLine());
            string listOfPeople = myFamily.everyone();
            if (choice == 1)
            {
                Console.WriteLine("What is this person's name?");
                String name = Console.ReadLine();

                Console.WriteLine("Who is their first parent");
                Console.WriteLine("-1 Unknown");
                Console.WriteLine(listOfPeople);
                int parent1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Who is their other parent");
                Console.WriteLine("-1 Unknown");
                Console.WriteLine(listOfPeople);
                int parent2 = Int32.Parse(Console.ReadLine());

                myFamily.addPerson(name, parent1, parent2);

            }
            else if (choice == 2)
            {

                Console.WriteLine("Who do you want to see ancestors of?");
                Console.WriteLine(listOfPeople);
                int who = Int32.Parse(Console.ReadLine());
                myFamily.printParents(who, "Self");
            }
            else if (choice == 3)
            {

                Console.WriteLine("Who do you want to see descendants of?");
                Console.WriteLine(listOfPeople);
                int who = Int32.Parse(Console.ReadLine());
                myFamily.printChildren(who, "Self");
            }
            else if (choice == 4)
            {
                done = true;
            }
        } while (!done);
    }
}