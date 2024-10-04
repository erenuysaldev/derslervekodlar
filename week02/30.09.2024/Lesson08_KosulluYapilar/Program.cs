using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Lesson08_KosulluYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programlarımızda duruma göre farklı akışlardan devam edilmesini sağlayan yapılardır.

            //             int number  = int.Parse(Console.ReadLine());

            //            Console.Write("Bir sayı giriniz");

            //            if (number > 0)
            //            {
            //                Console.WriteLine($"Girdiğiniz {number} sayısı  pozitiftir.");
            //            }

            //            else if (number == 0)
            //            {
            //                Console.WriteLine($"girdiğiniz {number} sayısı negatifitr.");
            //            }




            //            else
            //                Console.WriteLine($"girdiginiz {number} sayısı negatiftir .");








            //string currentUserName = "daniel";

            //string currentPassword = "Qwe123";

            //Console.Write("kullanıcı adınızı girin");
            //string userName = Console.ReadLine();
            //Console.Write("şifre : ");
            //string password = Console.ReadLine();

            //if (currentUserName == currentUserName && password== currentPassword)
            //{
            //    Console.WriteLine("Başarılı bi şekilde giriş yaptınız");
            //    Console.WriteLine($"Hoşgeldiniz {userName}");

            //}
            //else if(userName!=currentUserName && password != currentPassword)
            //{
            //    Console.WriteLine("Giriş işlemi başarısız oldu");
            //} 






            /*
                        DateTime date = new DateTime(2024, 09, 24);
                        int month = date.Month;
                        string message;
                        if (month ==12 || month == 1  || month == 2)
                        {
                            message = "Kış";
                        }
                        else if (month>=3  && month<=5)
                        {
                            message = "İlkbahar";
                        }
                        else if(month>=6 && month<=8)
                        {
                            message = "Yaz";
                        }
                        else
                        {
                            message = "sonbahar";
                        }
                        Console.WriteLine($"{date} tarihi {message} mevsimine aittir!");*/


            //DateTime date = new DateTime(2024, 09, 24);
            //int month = date.Month;
            //string message;
            //switch(month)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        message = "kış";
            //            break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        message = "ilkbahar";
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //    default:
            //        message = "yaz";
            //        break;
            //}


            //Console.Write("Yaşınızı giriniz:");
            //byte age = byte.Parse(Console.ReadLine());
            //string message = age >= 18 ? "Giriş yapabilirsiniz" : "Giriş yapamazsınız";
            //if (age >= 18)
            //{
            //    message = "Giriş yapabilirsiniz!";
            //}
            //else
            //{
            //    message = "Giriş yapamazsınız";
            //}

            //Console.WriteLine(message);

            //Console.Write("Yaşınızı giriniz:");
            //byte age = byte.Parse(Console.ReadLine());
            //Console.WriteLine(age >= 18 ? "Giriş yapabilirsiniz" : "Giriş yapamazsınız");



            //Not Sistemi:
            /*   
               0-45: E
                46-60: D
                61-70: C
                71-85: B
                86-100:A


             */
            Console.WriteLine("100 lük sistemdeki puanı giriniz:");
           byte point = byte.Parse(Console.ReadLine()); 

            char result = point<=45 ? 'E' :
                point<=60 ? 'D' :
                point<=70 ? 'C' :
                point<=85 ? 'B' :  'A';
            Console.WriteLine($"100lük sistemdeki puanınız: {point}");
            Console.WriteLine($"sistemdeki puanınız: {result}");


            //bu örneği if ile ve switch ile de yapın.





        }

    }
}

