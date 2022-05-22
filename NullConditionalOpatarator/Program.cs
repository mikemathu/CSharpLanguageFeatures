using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullConditionalOpatarator.NullConditionalOperator;
using NullConditionalOpatarator.ChainingNullConditionalOperator;

namespace ConditionalOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Null Conditional Operator*/
            /* string[] Names = new string[] { "Mike", "Joan", "Jane" };
             Names = null;
             TesterMethod(Names);*//*

            int? numberOfStudents = 49;
            numberOfStudents = null;
            NullConditionalOperator.TesterMethod(numberOfStudents);*/


            /*Chaining the null conditional operator*/
            /* Person person = new Person);

             person.FirstName = "Nike"; //set
             person.LastName = "Mathu"; //set
             person.age = 23;
             person.*/

            /*string name = person?.FirstName;
            //int? age = 23;
            Nullable<int> age = person?.age;*/
            /*Console.WriteLine(age);*/
            //Console.WriteLine(person.FirstName); 

            string messageToUser = "nothing";


            Person lecturer = new Person
            {
                FirstName = null,
                LastName = "Ndirangu"
            };

            Person student = new Person
            {
                FirstName = "Mike",
                LastName = "Mathu",
                Age = 23,
            };

            student.Supervisor = lecturer;

            string name = lecturer?.FirstName?? messageToUser;
            int? years = lecturer?.Age ?? 0;
            //Console.WriteLine(years);

            string supervisorName = student?.Supervisor?.FirstName ?? messageToUser;//Chainig the null conditional operator.Detectig nested null Values


            string output = string.Format("Name: {0} Age: {1}, Supervisor: {2}", name, years, supervisorName);
            Console.WriteLine(output);

            

           









        }
    }
}


