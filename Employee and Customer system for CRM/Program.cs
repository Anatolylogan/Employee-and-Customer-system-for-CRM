using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Employee_and_Customer_system_for_CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            var personRepo = new Repository<Person>();
            personRepo.Add(new Employee("Tolya", 22, "Admin"));
            var client = new Client("Alex", 44, 2300);
            client.AddPurchace(1200);
            personRepo.Add(client);

            var vipRepo = new VIPRepository<VIPClient>();
            vipRepo.Add(new VIPClient("Andrey", 19, 1000, 1));
            vipRepo.Add(new VIPClient("Danil", 26, 200, 3));

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