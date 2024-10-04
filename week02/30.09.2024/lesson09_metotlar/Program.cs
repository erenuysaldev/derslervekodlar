namespace lesson09_metotlar
{
    internal class Program
    {   //static sözüğünün ne işe yaradıgını OOP konularında ögrenecegiz
        static void Merhaba()
        {
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine("Sanada Merhaba");
            Console.WriteLine("*************");

        }
        c# ta önemli gelenekler biri metot isimlerinin pascalCase ile yazılmasıdır pascalcase her kelimenin ilk harfi büyük geri alanları kücük seklinde yazılır.
        static int Topla()
        {
            int a = 45 + 6;
            return a;
        }

        static int IkiSayiyiTopla(int sayi1, int sayi2)//parametre deniyor.
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }



        static void Main(string[] args)//Bir dotnet konsol uygulaması ilk calıstırıldıgında main methodunu calıstırır
        {
            Console.WriteLine(IkiSayiyiTopla(5, 18));






            Merhaba();
            int a = 45;
            double b = 56;
            string message = "Nasılsın";
            Merhaba();
            Merhaba();
            Merhaba();
            int number = Topla();
            Console.WriteLine(number * number);
            IkiSayiyiTopla(5, 18);//methodun argümanları



            static int UcSayiyiTopla(int sayi1, int sayi2, int sayi3)
            {
                int sonuc = sayi1 + sayi2 + sayi3;
                return sonuc;

                Console.WriteLine(UcSayiyiTopla(5, 18, 19));
                Console.WriteLine(UcSayiyiTopla(31, 78, 99));
                Console.WriteLine(UcSayiyiTopla(1, 18, 1));

                namespace lesson09_metotlar
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                decimal productPrice = 100m; // Örnek bir ürün fiyatı
                decimal rateOfTax = 0.2m; // Örnek bir vergi oranı

                decimal totalPrice = CalculateIncludeTax(productPrice, rateOfTax);
                Console.WriteLine("Vergi dahil toplam fiyat: " + totalPrice);
            }

            static decimal CalculateIncludeTax(decimal productPrice, decimal rateOfTax)
            {
                decimal tax = CalculateTax(productPrice, rateOfTax);
                return productPrice + tax;
            }

            static decimal CalculateTax(decimal productPrice, decimal rateOfTax)
            {
                decimal tax = productPrice * rateOfTax;
                return tax;
                                       

                            static string GenerateSmsCode()
                {
                    Random rnd = new Random();
                    string n1 = rnd.Next(0,10).ToString();
                    string n2 = rnd.Next(0,10).ToString();
                    string n3 = rnd.Next(0,10).ToString();
                    string n4 = rnd.Next(0,10).ToString();
                    string n5 = rnd.Next(0,10).ToString();
                    string n6 = rnd.Next(0,10).ToString();
                    return $"{n1}{n2}{n3}{n4}{n5}{n6}";
                }





        
    






            }
        }
    } 
}
