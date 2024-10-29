using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }

        public abstract string GetDetails();
        public abstract string CalculateDiscount();
        public override string ToString()
        {
            return $"Person:{Name} Age:{Age} ";
        }
    }
}
