using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics.accessdemo
{
    // Case3 : Accessing from Non Child class
    class AccessSpecifierCase3
    {
        static void Main(string[] args)
        {
            AccessSpecifierCase1 case3 = new AccessSpecifierCase1();

           // case3.Test1(); Private member is not accessible from non child class
            case3.Test2();
          //  case3.Test3(); Protected member is also not accessible from non child class
            case3.Test4();
            case3.Test5();
        }
    }
}
