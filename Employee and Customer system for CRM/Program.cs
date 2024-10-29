using System.ComponentModel;

namespace Employee_and_Customer_system_for_CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var personRepo = new Repository<Person>();
            personRepo.Add(new Employee { Name = "Tolya", Age = 22, Position = "Admin" });
            personRepo.Add(new Client { Name = "Alex", Age = 44, PurchaseAmount = 2300 });

            var vipRepo = new VIPRepository<VIPClient>();
            vipRepo.Add(new VIPClient { Name = "Andrey", Age = 19, PurchaseAmount = 1000, VIPLevel = 1 });
            vipRepo.Add(new VIPClient { Name = "Danil", Age = 26, PurchaseAmount = 200, VIPLevel = 3 });

            Console.WriteLine("Persons:");
            foreach (var person in personRepo.GetAll())
            {
                Console.WriteLine(person.GetDetails());
                Console.WriteLine($"Discount: {person.CalculateDiscount() * 100}%");
            }
            Console.WriteLine("Vip Clients:");
            foreach (var vip in vipRepo.GetAll())
            {
                Console.WriteLine(vip.GetVIPDetails());
                Console.WriteLine($"Discount: {vip.CalculateDiscount() * 100}%");
            }
            Console.WriteLine("Vip Clients wth VIPlevel > 1");
            foreach (var vip in vipRepo.GetVIPs())
            {
                Console.WriteLine(vip.GetVIPDetails());
                Console.WriteLine($"Discount: {vip.CalculateDiscount() * 100}%");
            }
        }
    }
}