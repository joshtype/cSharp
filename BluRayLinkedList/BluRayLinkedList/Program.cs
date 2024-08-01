// (L11) BluRay library app using linked lists (driver/ui).
// @author:     Joshua Gregory
// @version:    1.0 (July 2024)
using System.Runtime.InteropServices;

namespace BluRayLinkedList
{
    internal class Program
    {
        public static BluRayCollection library = new BluRayCollection();
        public static string ui = "0: Exit\n1: Add new blueray to collection\n2: View current collecction";
        public static string inp;

        // DRIVER UI
        static void Main(string[] args)
        {
            Console.WriteLine(ui);
            inp = Console.ReadLine();

            do
            {
                if (inp == "0")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else if (inp == "1")
                {
                    string t = "";
                    string d = "";
                    int y = 0;
                    double c = 0;

                    // get obj.title, validate nonnull & len
                    Console.WriteLine("BluRay title:");
                    t = Console.ReadLine();
                    while (true)
                    {
                        if (t == null || t.Length < 1)
                        {
                            Console.WriteLine("Title input is too short, try again.");
                            t = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }

                    // get obj.director, validate nonnull & len
                    Console.WriteLine("Director:");
                    d = Console.ReadLine();
                    while (true)
                    {
                        if (d == null || d.Length < 1)
                        {
                            Console.WriteLine("Director input is too short, try again.");
                            d = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }

                    // get obj.year, convert to int
                    Console.WriteLine("Year released:");
                    string year = Console.ReadLine();
                    while (true)
                    {
                        if (year == null || year.Length < 1)
                        {
                            Console.WriteLine("Year input is too short, try again.");
                            year = Console.ReadLine();
                        }
                        else
                        {
                            if (!Int32.TryParse(year, out y))
                            {
                                Console.WriteLine("Invalid input. Enter the year as a postive integer (eg: 2001).");
                                year = Console.ReadLine();
                            }
                            else
                            {
                                y = int.Parse(year);
                                break;
                            }
                        }
                    }

                    // get obj.cost, convert to double
                    Console.WriteLine("Cost:");
                    string cost = Console.ReadLine();
                    while (true)
                    {
                        if (year == null || year.Length < 1)
                        {
                            Console.WriteLine("Cost input is too short, try again.");
                            year = Console.ReadLine();
                        }
                        else
                        {
                            if (!Double.TryParse(cost, out c))
                            {
                                Console.WriteLine("Invalid input. Enter the cost as a postive number (eg: 19.99 or 5.00).");
                                year = Console.ReadLine();
                            }
                            else
                            {
                                c = double.Parse(cost);
                                break;
                            }
                        }
                    }
                    // add new blueray obj to collection obj to end of linked list
                    library.add(t, d, y, c);

                    Console.WriteLine(ui);
                    inp = Console.ReadLine();
                }
                else if (inp == "2")
                {
                    library.showAll();
                    Console.WriteLine(ui);
                    inp = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                    Console.WriteLine(ui);
                    inp = Console.ReadLine();
                }
            } while (true);
        }
    }
}