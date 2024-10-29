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
        public virtual int VIPLevel { get; set; } = 1;
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
