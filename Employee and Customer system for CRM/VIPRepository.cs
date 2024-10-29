using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_Customer_system_for_CRM
{
    public class VIPRepository<T> : Repository<T> where T : VIPClient
    {
        public List<T> GetVIPs()
        {
            return GetAll().Where(vip => vip.VIPLevel > 1 ).ToList();
        }
    }
}
