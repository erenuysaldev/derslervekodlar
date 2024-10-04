using System.Diagnostics;

namespace Project04_VeriYapilariveDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler
            int age = 23;
            string name;
            name = "Ali";
            string ageOfAli = "23";
            //camelCase=ageOfAli o ve a büyük, daha rahat okunuyor studentNumber,firstName
            // değişkenlerin arasına tire konmaz"-" boşluk bırakılmaz, alttan tire konur(underscore) "_______"



            // Veri Tipleri
            // 1) Sayı Tipleri
            //"*u*"short = unsilent yani işaretsiz negatif olmuyan
            //short= silent olan yani negatif sayı alabilen

            byte studentNot = 255;
            sbyte studenNot = -20;

            short orderCount = -100;
            ushort orderCount2 = 5;
    
            int totalLastYear = 50000;
            uint totalLastYear2 = 3;

            long count = 1245678;
            ulong count2 = 3123213;

            /*  Console.Write("Short tipinin minimum değeri : ");
              Console.WriteLine(short.MinValue);
              Console.Write("Short tipinin maximum değeri : ");
              Console.WriteLine(short.MaxValue);
              Console.Write("Long tipinin bellekteki boyutu (byte değeri) : ");
              Console.WriteLine(sizeof(long) * 8);
              Console.ReadLine();*/   // */ = Ctrl shift ö"

            /*
            Console.WriteLine("Short Max Value : " + short.MaxValue);
            Console.WriteLine("Short Min Value : " +short.MinValue);
            Console.WriteLine("Short Size: " sizeof(short) + "byte");*/

            string firstName = "Eren";
            string lastName = "Uysal";
            string gender = "Bay";
            Console.WriteLine("Sayın " +gender + " " + firstName +" "+ lastName);
            Console.WriteLine($"Sayın {gender} {firstName} {lastName}");




        }
    }
}
