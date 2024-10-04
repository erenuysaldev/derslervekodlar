using System.Collections.Concurrent;

namespace Lesson07_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        { 
 ;          //1- Aritmetik Operatörler

            //int number1 = 10;
            //int number2 = 2;
            //Console.WriteLine($"Number1 = {number1}\nNumber2 = {number2}");

            ////Console.WriteLine();//Boş satır
            ////Console.WriteLine($"Toplam= {number1+number2}");
            ////Console.WriteLine($"Fark= {number1-number2}");
            ////Console.WriteLine($"Çarp= {number1*number2}");
            ////Console.WriteLine($"Bölüm= {number1/number2}");
            ////Console.WriteLine($"Mod= {number1%number2}");
            //Console.Read();

            //number1++; /*+operatörü kullandığı değişkenin işini yaptıktan sonra değerini 1 arttırır, önüne yazılmışşsa önce değerini  1 arttırır sonra kullanır */.
            //-- operatörü kullanıldığı değişkenin işini yptıktan sonra değerini 1 eksiltir
            //Console.WriteLine(number1);



            //number1--;
            //Console.WriteLine(number1);
            //Console.WriteLine(++number1

            //int a = 7;
            //int b = 21;
            //int c = 11;
            //Console.WriteLine(a++ + b++ +c+ --a+ ++b);
            // a= a+3;
            //a += 3;//a=a+3
            //a -= 2;//a=a-2
            //a *= 5;//a=a*5
            //a /= 3;// a=a/5

            //2)İlişkisel Operatörler

            int number1 = 10;
            int number2 = 15;
            int number3 = 10;
            //Console.WriteLine($"number 1 number2'den büyük mü ?:{number1>number2 }");
            //Console.WriteLine($"number 1 number 2'den büyük ya da eşit mi ?:{number1>=number2} ");
            //Console.WriteLine($"number 1 number 2'den küçük mü?:{number1<number2} ");
            //Console.WriteLine($"number 1 number 2'den küçük ya da eşit mi ?:{number1<=number2} ");
            //Console.WriteLine($"number 1 number 2'ye eşit mi ?:{number1=number2} ");
            //Console.WriteLine($"number 1 number2'den farklı mı? {number1!=number2}");



            //3) Mantıksal Operatorler

            Console.WriteLine(number1==number2 ||number1==number3);
            Console.WriteLine(number1==number2 && number1==number3);




        }
    }
}
