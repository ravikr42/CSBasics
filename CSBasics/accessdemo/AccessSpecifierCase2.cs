using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics.accessdemo
{
    // Case 2: Accessing from Child Class
    class AccessSpecifierCase2 : AccessSpecifierCase1
    {
        static void Main(string[] args)
        {
            AccessSpecifierCase2 case2 = new AccessSpecifierCase2();

            //case2.Test1(); private method is not accessible in child class
            case2.Test2();
            case2.Test3();
            case2.Test4();
            case2.Test5();
        }
    }
}
