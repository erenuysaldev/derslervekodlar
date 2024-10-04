using System.Linq.Expressions;

namespace lesson13_Siniflar
{
    class House
    {
        public string streetName;
        public int doorNumber;
    }


    class user
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public string userName;
    }


    /* class Product
     {
         private int _id;                    //sınıfların içindeki değişkenlerin default erişim belirleyici privstedir biz burada belirgin olsun diye yazdık yazmasaydıkda olurdu.
         private string _name;//bunlara field diyoruz bu classtan yaratılan nesnenin içindeki bilgileri tutan nesneler
         private decimal _price;

         public void setPrice(decimal price)

         {
             _price = price;
         }
         public decimal getPrice()
         {
             return _price;
         }

     }*/

    class Product {
        public string nameof { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }

        public int GetNameLenght { get { return nameof.Length; } }
    }
}
    
            









    internal class Program
    {
        static void Main(string[] args)
        {

            #region oop giriş
            // Nesne Yönelimli Programlama-Object Oritented Programming(OOP)
            //Sınıflar nesnelerin kalıpları şablonlarıdır ne gibi özelliklere sahip oldugunu belirler dolayısıyla nesneler sınıflardan yaratılır bu baglamda c# için her şey bir Nesne'dir.
            //int number;
            //number = 56;

            //House house1;
            //house1 = new House();
            //house1.streetName = "ELF Sokağı";
            //house1.doorNumber = 56;

            //Console.WriteLine(house1.streetName);
            //Console.WriteLine(house1.doorNumber);
            #endregion
            #region ornek1
            user user1 = new user();
            user1.id = 1;
            user1.firstName = "Ali";
            user1.lastName = "Cabbar";
            user1.email = "alicabbar@roman.com";
            user1.userName = "alicabbar";
            user1.password = "1234";

            user user2 = new user()
            {
                id = 2,
                firstName = "Eren",
                lastName = "uysal",
                email = "eren123@hotmail.com",
                userName = "eren123",
                password = "123",
            };

            user user3 = new()
            {
                id=3
            };

        #endregion
        #region örnek2
        Product product1 = new Product();
            product1.setPrice(150);
            Console.WriteLine(product1.getPrice());
             Product product2 = new Product();
            product2.setPrice(400);
            Console.WriteLine(product2.getPrice());
            Product product3 = new Product();
            product3.setPrice(-1400);
            Console.WriteLine(product3.getPrice());
        #endregion
        #region örnek3
        Product product1 = new Product();
            product1.Price = 100;
            product1.Name = "Iphone";
        Console.WriteLine(product1.GetNameLenght);

        #endregion




    }


}

    
}
