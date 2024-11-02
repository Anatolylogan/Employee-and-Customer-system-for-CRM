using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public class VIPClient : Client
    {
        private int vipLevel;
        public virtual int VIPLevel
        {
            get => vipLevel;
            set => vipLevel = value;
        }
        public VIPClient(string name, int age, double initialPurchaseAmount, int vipLevel = 1)
            : base(name, age, initialPurchaseAmount)
        {
            this.vipLevel = vipLevel;
        }
        protected new string GetDetails()
        {
            return $"VIPClient: Person {Name} Age {Age} PurchaseAmount {PurchaseAmount} VIPLevel {VIPLevel}";
        }
        public string GetVIPDetails()
        {
            return GetDetails();
        }
    }
}
