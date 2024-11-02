using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public abstract class Person
    {
        private readonly string name;
        private readonly int age;
        public string Name => name;
        public int Age => age;
        protected Person(string name , int age) 
        {
            this.name = name;
            this.age = age;
        }

        public abstract string GetDetails();
        public abstract double CalculateDiscount();
        public override string ToString()
        {
            return $"Person: Person {Name} Age {Age} ";
        }
    }
}
