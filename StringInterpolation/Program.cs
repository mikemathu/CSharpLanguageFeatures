using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringInterpolation;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Mmike",
                Gender = "Male",
                Age = 23
            };

            /*Using string.Format method*/
            //string output = string.Format("Name: {0}, Gender: {1}, Age: {2} ", person.Name, person.Gender, person.Age);//using traditional c# tool for composing strings that contains data values

            //Console.WriteLine(output);

            //Console.WriteLine("nAME: {0}, gENDER: {1}, aGE: {2}", person.Name, person.Gender, person.Age);


            /*Using string Inteporation. Avoids the need to ensure the {0} reference in the string template match up with variable specified s arguments. I stead we use the variable name directly*/
            Console.WriteLine($"Namee: {person.Name}, Gender: {person.Gender}, Age: {person.Age:C2} ");

        }
    }
}
