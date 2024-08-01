// Joshua Gregory; July 2024
// Threading Example; Driver file
using BabyThreads;

namespace BabyThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create 5 Baby objs
            Baby b1 = new Baby("Noah");
            Baby b2 = new Baby("Olivia");
            Baby b3 = new Baby("Liam");
            Baby b4 = new Baby("Emma");
            Baby b5 = new Baby("Amelia");

            // create 5 thread objs; pass in obj method to parallelize
            Thread t1 = new Thread(b1.Run);
            Thread t2 = new Thread(b2.Run);
            Thread t3 = new Thread(b3.Run);
            Thread t4 = new Thread(b4.Run);
            Thread t5 = new Thread(b5.Run);

            // call Start() to begin processing method in each thread
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }
    }
}
