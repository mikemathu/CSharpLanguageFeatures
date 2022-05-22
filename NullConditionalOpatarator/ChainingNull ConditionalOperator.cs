using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalOpatarator.ChainingNullConditionalOperator
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public Person Supervisor { get; set; } //referene to the person's spouse
    }
}
