using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public class Employee : Person
    {
        public string Position { get; set; }
        public override string GetDetails()
        {
            return $"Person {Name}, Age {Age}, Position {Position}";
        }
        public override double CalculateDiscount()
        {
            if (Age < 25)
                return 0.10;
            else if (Age < 50)
                return 0.20;
            else
                return 0.30;
        }

    }
}
