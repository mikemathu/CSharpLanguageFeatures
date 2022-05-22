using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOpatarator.NullConditionalOperator
{
    public class NullConditionalOperator
    {
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

        public static void TesterMethod(int? students)
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


/*NOTES*/
/*
 When you are writing software, it is common to check incoming parameters, which are values returned from 
type members (methods, properties, indexers), against the value null. For example, let’s assume you have 
a method that takes a string array as a single parameter. To be safe, you might want to test for null before 
proceeding. In that way, you will not get a runtime error if the array is empty. The following would be a 
traditional way to perform such a check:

 static void TesterMethod(string[] args)
{
 // We should check for null before accessing the array data!
 if (args != null)
 {
 Console.WriteLine($"You sent me {args.Length} arguments.");
 }
}
Here, you use a conditional scope to ensure that the Length property of the string array will not be 
accessed if the array is null. If the caller failed to make an array of data and called your method like so, you 
are still safe and will not trigger a runtime error:
TesterMethod(null);
C# includes the null conditional operator token (a question mark placed after a variable type but before 
an access operator) to simplify the previous error checking. Rather than explicitly building a conditional 
statement to check for null, you can now write the following:
static void TesterMethod(string[] args)
{
 // We should check for null before accessing the array data!
 Console.WriteLine($"You sent me {args?.Length} arguments.");
}
In this case, you are not using a conditional statement. Rather, you are suffixing the ? operator directly after 
the string array variable. If the variable is null, its call to the Length property will not throw a runtime error. If 
you want to print an actual value, you could leverage the null-coalescing operator to assign a default value as so:
Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");

NOTE: t because it might return null, its return type is
always a nullable type. That means that for a struct or primitive type, it is wrapped into a Nullable<T> i.e int?
 */
