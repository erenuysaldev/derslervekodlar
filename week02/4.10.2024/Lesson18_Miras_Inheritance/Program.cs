using Lesson18_Miras_Inheritance.Eshop;
using Lesson18_Miras_Inheritance.Sınıflar;

namespace Lesson18_Miras_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kod
            //Otomobil otomobil1 = new Otomobil();
            //otomobil1.Tur = "Otomobil";
            //otomobil1.Marka = "bmw";
            //otomobil1.Model = "520i";
            //otomobil1.DisplayInfo();
            //otomobil1.KornaCal();

            //Vapur vapur1 = new Vapur();
            //vapur1.Tur = "Vapur";
            //vapur1.GemiAd = "Barbaros Hayrettin Paşa";
            //vapur1.GemiNo = 11111;
            #endregion
            #region 2.kod

            // List<Brand> brands = new List<Brand>
            // {
            //     new Brand
            //     {
            //         Id=1,
            //         Name="Apple",
            //         Country="Usa",
            //         Description="Kendine has bir marka",
            //         IsActive=true,
            //         CreatedDate=DateTime.Now,
            //     },

            //     new Brand
            //     {
            //         Id = 2,
            //         Name="Lenovo",
            //         Country="Usa",
            //         Description="Pc nin mucidi",
            //         IsActive=true,
            //         CreatedDate = DateTime.Now,
            //     }
            // };
            // new Brand
            // {
            //     Id = 3,
            //     Name="Monster",
            //     Country = "TR",
            //     Description = "Pc nin mucidi",
            //     IsActive = true,
            //     CreatedDate = DateTime.Now,

            // };
            // foreach (Brand brand in brands)
            // {
            //     string isActive = brand.IsActive ? "Aktif Marka" : "Pasif Marka "; Console.WriteLine($"{brand.Id}-{brand.Name}-{isActive}");

            //};
            #endregion

            List<Brand> brands = new List<Brand>();
            
            Product product1 = new Product
            {
                Id = 1,
                Name = "Macbook Air M2 16GB",
                Properties = "M2 işlemci , 16 gb ram , 512gb ssd",
                Price = 62000,
                TaxRate = 0.2M,
                BrandId = 1
            };
            Product product2 = new Product

            {
                Id = 2,
                Name = "Mnster Air M2 16GB",
                Properties = "M2 işlemci , 16 gb ram , 512gb ssd",
                Price = 62000,
                TaxRate = 0.2M,
                BrandId = 2
            };
            Product product3 = new Product
            {
                Id = 3,
                Name = "msi Air M2 16GB",
                Properties = "M2 işlemci , 16 gb ram , 512gb ssd",
                Price = 62000,
                TaxRate = 0.2M,
                BrandId = 3
            };




            List<Product> products = new List<Product>();  
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
           foreach(Product product in products)
            {
                 string brandName="";
                foreach (Brand brand in brands)//BrandId'ye göre BrandName'i buluyoruz
                {
                    if(product.BrandId == brand.Id)
                    {
                        brandName = brand.Name;
                    }
                }
                

                Console.WriteLine($"Id: {product.Id} - Ürün: {product.Name}-{product.BrandId}- {brandName}");
            }





        }
        

    }
}

