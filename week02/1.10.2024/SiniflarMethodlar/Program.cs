using SiniflarMethodlar.Members;
using SiniflarMethodlar.Shopping;
using System.Threading.Channels;

namespace SiniflarMethodlar
{
    internal class Program
    {
        static void Main(string[] args)

            
            Product product1 = new Product(4, "mac");
            Console.WriteLine(product1.Name);
            Role role1 = new Role
            {
                Id = 1,
                Name = "Admin",
                Description = "Yönetici Rolü"

            };
            role1.DisplayInfo();
        }       
    }
}
