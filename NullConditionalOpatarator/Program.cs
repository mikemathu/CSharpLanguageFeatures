using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConditionalOpatarator.NullConditionalOperator;

namespace ConditionalOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* string[] Names = new string[] { "Mike", "Joan", "Jane" };
             Names = null;
             TesterMethod(Names);*/

            int? numberOfStudents = 49;
            numberOfStudents = null;
            NullConditionalOperator.TesterMethod(numberOfStudents);
        }
    }
}


