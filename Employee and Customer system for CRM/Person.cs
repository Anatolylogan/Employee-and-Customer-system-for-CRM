using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public abstract class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public abstract string GetDetails();
        public abstract double CalculateDiscount();
        public override string ToString()
        {
            return $"Person: Person {Name} Age {Age} ";
        }
    }
}
