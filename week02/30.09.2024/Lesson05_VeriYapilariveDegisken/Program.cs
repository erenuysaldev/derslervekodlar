using System.Runtime.InteropServices;

namespace Lesson05_VeriYapilariveDegisken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ondalıklı Sayılar
            /*
                        float number1 = 45.45f;//f koymadan yazamazsın ondalıklı floatta
                        double number2 = 32.32;//bunda yazabiliyon
                        decimal number3 = 19.98m;// m olmadan yazamiyon

                        Console.WriteLine($"number1 sayısının bellekte kapladıgı alan: {sizeof(float)} ");
                        Console.WriteLine($"number2 sayısının bellekte kapladıgı alan: {sizeof(double)} ");
                        Console.WriteLine($"number3 sayısının bellekte kapladıgı alan: {sizeof(decimal)} ");


                        // Metinsel veri tipleri
                        char karakter1 = 'A';
                        char karakter2 = '%';

                        string adSoyad = "Immobile";
                        Console.WriteLine(adSoyad);
                        Console.WriteLine(adSoyad[0]);

                        char karakter3 = adSoyad[0];
            */

            // Mantıksal veri
            //bool isActive = true;
            //bool isDeleted = false;
            
            const int a = 45;
            const int b = 50;
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine("******************");

            //a = a+8;
            //b = b+9;
            int c;
            c = a + b;
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"a+b: {c}");
            Console.Read();

        }
    }
}
