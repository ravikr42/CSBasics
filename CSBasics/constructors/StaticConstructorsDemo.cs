using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics.constructors
{
    class StaticConstructorsDemo
    {
        public static int x;
        public int y;
              
        // Constructors Initialize the value of variables to their default value i.e. 0

        static StaticConstructorsDemo() {
            // Static constructors are called only once during execution of class lifespan
            // Static Constructors are being called implicitely
            Console.WriteLine("Static Constructor is called: {0}", x);
        }

        public StaticConstructorsDemo() {
            // Non Static constructors are called as many times as many instances are being created
            // Non Static constructors are called explicitely
            Console.WriteLine("Non Static Constructor is called: {0}", y);
        }

        static void Main(string[] args)
        {
            StaticConstructorsDemo s1 = new StaticConstructorsDemo();
        }
    }
}
