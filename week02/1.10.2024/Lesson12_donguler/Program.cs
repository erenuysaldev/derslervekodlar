using System.Threading.Channels;

namespace Lesson12_donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-For: Dönüş(tekrar) sayısı belirli ya da belirlenebilir ise tercih edilmesi gereken döngüdür.
            //for (int i = 0; i < 10; i++) // for döngüsü 3 bölümden oluşur
            //                             // int i=0=> döngü değişkeni tanımlanır
            //                             //i<10=>İ 10 dan küçük olduğu sürece dönmeye devam et 
            //                             //i++ döngü her döndüğünde i'yi bir arttır
            //{

            //}



            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}Merhaba Dünya!");
            //}

            //Klavyeden girilicek beş adet sayıyı toplayıp sonucu ekrana yazdıran program

            //int total = 0;
            //int number;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1}.Sayıyı giriniz");
            //   number=int.Parse( Console.ReadLine() );
            //    total +=number;

            //}
            //Console.WriteLine(total);

            //2-While:Bir koşula bağlı olarak çalışır. Koşul doğru olduğu sürece döngü devam eder.
            //int i = 5;
            //while(i < 5)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i++;
            //}



            //string currentPasword = "123456";
            //string password = "";
            //while (password != currentPasword)
            //{
            //    Console.WriteLine("Şifrenizi giriniz:");
            //    password = Console.ReadLine();

            //}
            //Console.WriteLine("Login oldunuz!");

            //3-Do While : Bir koşula bağlı olarak çalışır. Koşul doğru olduğu sürece döngü devam eder.While'dan farkı en az bir kez çalışır, çünkü koşul döngü sonunda kontrol edilir

            //string currentPasword = "123456";
            //string password;
            //do
            //{
            //    Console.WriteLine("Şifrenizi giriniz:");
            //    password = Console.ReadLine();

            //} while (password != currentPasword);
            //Console.WriteLine("Login oldunuz!");

            // 4-Foreach:Koleksiyonlar içine döngü kurabilmek için kullanılır.Şimdilik bu anlamda bilidiğiniz diziler var.

            //string[] studentNames = { "Ceren", "Işık", "Elif", "Serra", "Aysu" };


            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    studentNames[i] += " Gün";
            //}
            //foreach (string studentName in studentNames)
            //{
            //    Console.WriteLine(studentName);
            //}
            //for ile yazdırma
            //for(int i=0; i<studentNames.Length; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //}
            //while ile yazdıralım
            //int i = 0;
            //while (i < studentNames.Length)
            //{
            //    Console.WriteLine(studentNames[i]);
            //    i++;
            //}


            string[] products = { "Iphone 13", "Samsung S23", "Macbook" };
            int[] prices = {55000 , 40000 , 47000};
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{products[i]} --- {prices[i]}");  
            }
            



        }
    }
}
