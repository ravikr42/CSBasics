using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics.variables
{
    class VariablesDemo
    {
        public VariablesDemo() {
        }

        static void Main(string[] args)
        {
            // This is instance in C#
            VariablesDemo demo = new VariablesDemo();

            //This is variable in C#
            VariablesDemo demo1;

            //This is reference in C#
            VariablesDemo demo2 = demo;
        }
    }
}
