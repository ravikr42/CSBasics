using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics.accessdemo
{
    // Case 1: Accessing Class Members in Same class
    class AccessSpecifierCase1
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal");
        }

        public void Test5()
        {
            Console.WriteLine("Public Method");
        }

        static void Main(string[] args)
        {
            AccessSpecifierCase1 case1 = new AccessSpecifierCase1();

            case1.Test1();
            case1.Test2();
            case1.Test3();
            case1.Test4();
            case1.Test5();

            // Under same class all access specifiers are accessible
        }
    }
}
