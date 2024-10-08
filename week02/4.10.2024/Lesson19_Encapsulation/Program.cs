namespace Lesson19_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category("Bilgisayar");
            category.Id = 56;
            
            Console.WriteLine(category.Id);
            Console.WriteLine(category.NameLength);
            Console.WriteLine(category.Name);

        //adı category1 olan yen ibir kategori nesneesi tanımlayin
        //category1 nesnesinin name:telefon olsun
        //Idsi 5 description:telefon kategorisi oslun ve bu bilgiler nesne oluşturulurken verilsin

            Category category1 =new Category("Telefon");
            {
                Id=5,
                Description = "Telefon kategorisi";
            };
            
        }
    }
}
