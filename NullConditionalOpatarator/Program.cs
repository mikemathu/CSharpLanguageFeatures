using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string[] Names = new string[] { "Mike", "Joan", "Jane" };
             Names = null;
             TesterMethod(Names);*/

            int? numberOfStudents = 49;
            //numberOfStudents = null;
            TesterMethod(numberOfStudents);
        }


        /*Traditiona way to test for null using conditional statement/*
        static void TesterMethod(string[] args)
        {
            //checking for null before accessig the array data
            if(args != null)
            {
                Console.WriteLine($"You sent me {args.Length} arguments");
            }
            else
            {
                Console.WriteLine("Your value is null!");
            }
        }*/


        /*Using conditional null operator to test null*//*
        static void TesterMethod(string[] args)
        {
            //Console.WriteLine($"You sent me {args?.Length} arguments Conditional null operator");//conditional null operator
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments Conditional null operator"); // using the null-coalescing operator '??' to assign a default value

        }*/

        static void TesterMethod(int? students)
        {
           /* if (students != null)
            {
                Console.WriteLine($"your have {students} number of student");
            }
            else
            {
                Console.WriteLine($"your have zero number of student");

            }*/

            Console.WriteLine($"your have {students ?? 0} number of student");


        }





    }
}
