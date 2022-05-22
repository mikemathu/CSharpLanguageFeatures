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

            string output = string.Format("Name: {0}, Gender: {1}, Age: {2} ", person.Name, person.Gender, person.Age);

            Console.WriteLine(output);

            Console.WriteLine("nAME: {0}, gENDER: {1}, aGE: {2}", person.Name, person.Gender, person.Age);
        }
    }
}
