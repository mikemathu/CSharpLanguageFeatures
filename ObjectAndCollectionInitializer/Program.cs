using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringInterpolation;
using ObjectAndCollectionInitializer;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Without an initializer, creating a string array, for example, requires the size the array and the array elements to be specified separately
            /* string[] names = new string[3];
             names[0] = "Bob";
             names[1] = "Joe";
             names[2] = "Alice";

             Console.WriteLine(names[1]);*/


            //Using a collection initializer allows the contents of the array to be specified as part of the construction,
            string[] names = new string[] {"Bob", "Joe", "Alice" };

            Console.WriteLine(names[2]);


            

        }
    }
}
