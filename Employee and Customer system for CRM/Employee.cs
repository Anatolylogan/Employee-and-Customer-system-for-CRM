using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public class Employee : Person
    {
        private string position;
        public string Position
        {
            get => position;
            set => position = value;
        }
        public Employee(string name, int age, string position)
            : base(name, age)
        {
            this.position = position;
        }
        public override string GetDetails()
        {
            return $"Employee: Person {Name}, Age {Age}, Position {Position}";
        }
        public override double CalculateDiscount()
        {
            double discount = 0;
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
}
