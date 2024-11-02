using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public enum ClientStatus
    {
        NoPurchases,
        HasPurchases
    }
    public class Client : Person
    {
        private double purchaseAmount;
        public double PurchaseAmount => purchaseAmount;
        public ClientStatus Status
        {
            get
            {
                return purchaseAmount > 0 ? ClientStatus.HasPurchases : ClientStatus.NoPurchases;
            }
        }

        public Client(string name, int age, double initialPurshaseAmount = 0)
             : base(name, age)
        {
            purchaseAmount = initialPurshaseAmount;
        }
        public void AddPurchace(double amount)
        {
            if (amount > 0)
            {
                purchaseAmount += amount;
            }
        }
        public override string GetDetails()
        {
            return $"Client: Person {Name} Age {Age} PurchaseAmount {PurchaseAmount}";
        }
        public override double CalculateDiscount()
        {
            if (PurchaseAmount < 1000)
                return 0.10;
            else if (PurchaseAmount > 2500)
                return 0.20;
            else
                return 0.30;
        }
    }
}
