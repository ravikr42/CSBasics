using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 This class demonstrates types of constructors available in C#
 */
namespace CSBasics.constructors
{
    class ConstructorsDemo
    {
        public int a;
        public ConstructorsDemo() {
            Console.WriteLine("Message from Default constructor");
        }

        public ConstructorsDemo(int a) {
            this.a = a;
            Console.WriteLine("Parametrized constructor with value : {0}", a);
        }

        public ConstructorsDemo(ConstructorsDemo c) {
            this.a = c.a;
            Console.WriteLine("Message from Copy constructor");
        }

        public void Display() {
            Console.WriteLine("Value of a is: "+a);
        }

        static void Main(string[] args)
        {
            ConstructorsDemo c1 = new ConstructorsDemo();
            ConstructorsDemo c2 = new ConstructorsDemo(10);
            ConstructorsDemo c3 = new ConstructorsDemo(c2);

            c1.Display();
            c2.Display();
            c3.Display();
        }

    }
}
