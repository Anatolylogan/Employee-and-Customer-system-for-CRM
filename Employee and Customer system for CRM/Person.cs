using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract string GetDetails();
        public abstract double CalculateDiscount();
        public override string ToString()
        {
            return $"Person: Person {Name} Age {Age} ";
        }
    }
}
