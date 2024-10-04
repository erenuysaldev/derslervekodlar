using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace ödevler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine(i);    Sayıları 1'den 10'a kadar yazdıran program
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            //Sayıları 1'den 100'e kadar olan tek sayıları yazdıran program
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //4.Kullanıcının girdiği bir sayının pozitif mi negatif mi olduğunu belirleyen program
            //    Console.Write("Bir sayı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı pozitiftir.");
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı negatiftir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı sıfırdır.");

            //5. 10 elemanlı bir dizi tanımlayın ve elemanlarını ekrana yazdırın

            //int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (int eleman in dizi)
            //{
            //    Console.WriteLine(eleman);


            //6. Kullanıcının girdiği iki sayıyı karşılaştıran ve büyük olanı ekrana yazdıran program
            //Console.Write("Birinci sayıyı girin: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci sayıyı girin: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Birinci sayı daha büyüktür: " + sayi1);
            //}
            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("İkinci sayı daha büyüktür: " + sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("İki sayı eşittir.");
            //
            //8.Kullanıcının girdiği bir sayının faktöriyelini hesaplayan bir program
            //Console.Write("Bir sayı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int faktoriyel = 1;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel *= i;
            //}

            //Console.WriteLine(sayi + " sayısının faktöriyeli: " + faktoriyel);
            //9. Kullanıcıdan bir sayı alın ve bu sayının karesini hesaplayıp ekrana yazdırın

            //Console.Write("Bir sayı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int kare = sayi * sayi;

            //Console.WriteLine(sayi + " sayısının karesi: " + kare);

            //10. 10 elemanlı bir dizi tanımlayın ve bu dizideki en büyük sayıyı bulan program
            //int[] dizi = { 23, 12, 45, 67, 34, 89, 78, 56, 10, 5 };
            //int enBuyuk = dizi[0];

            //foreach (int eleman in dizi)
            //{
            //    if (eleman > enBuyuk)
            //    {
            //        enBuyuk = eleman;
            //    }
            //}

            //Console.WriteLine("Dizideki en büyük sayı: " + enBuyuk);,

            //11. 1 ile 10 arasında rastgele bir sayı üretin ve kullanıcıdan bu sayıyı tahmin etmesini isteyin
            //Random random = new Random();
            //int rastgeleSayi = random.Next(1, 11);

            //int tahmin;
            //do
            //{
            //    Console.Write("1 ile 10 arasında bir sayı tahmin edin: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin < rastgeleSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı tahmin edin.");
            //    }
            //    else if (tahmin > rastgeleSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı tahmin edin.");
            //    }
            //} while (tahmin != rastgeleSayi);

            //Console.WriteLine("Tebrikler, doğru tahmin!");


            //12.Kullanıcının yaşını girip kaç yıl sonra 50 yaşına geleceğini hesaplayan program

            //Console.WriteLine("Yaşınızı girin:");
            //int yas =Convert.ToInt32(Console.ReadLine());
            //int kalanYil = 50 - yas;
            //if (kalanYil > 0)
            //{
            //    Console.WriteLine("50 yaşına " + kalanYil + "yıl sonra geleceksiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("50 yaşını geçtiniz");
            //}    
            //13. Kullanıcıdan bir sayı alın ve bu sayının asal olup olmadığını kontrol eden program
            //Console.Write("Bir sayı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //bool asalMi = true;

            //if (sayi <= 1)
            //{
            //    asalMi = false;
            //}
            //else
            //{
            //    for (int i = 2; i <= Math.Sqrt(sayi); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            asalMi = false;
            //            break;
            //        }
            //    }
            //}

            //if (asalMi)
            //{
            //    Console.WriteLine(sayi + " asal bir sayıdır.");
            //}
            //else
            //{          
            //    Console.WriteLine(sayi + " asal bir sayı değildir.");
            //}
            //13. Kullanıcıdan bir sayı alın ve bu sayının asal olup olmadığını kontrol eden program
            //Console.Write("Bir sayı girin: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //bool asalMi = true;

            //if (sayi <= 1)
            //{
            //    asalMi = false;
            //}
            //else
            //{
            //    for (int i = 2; i <= Math.Sqrt(sayi); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            asalMi = false;
            //            break;
            //        }
            //    }
            //}

            //if (asalMi)
            //{
            //    Console.WriteLine(sayi + " asal bir sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine(sayi + " asal bir sayı değildir.");




            //}



            //14. 20 elemanlı bir diziye rastgele sayılar atayın ve bu sayıları sıralayan program


        }
    }
}   
