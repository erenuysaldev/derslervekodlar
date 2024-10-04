namespace Lesson10_MetotlarAsiriYuklenme
{




    internal class Program
    {
        static string GenerateSmsCode()
        {
            Random rnd = new Random();

            int number1 = rnd.Next(0, 10);
            int number2 = rnd.Next(0, 10);
            int number3 = rnd.Next(0, 10);
            int number4 = rnd.Next(0, 10);
            int number5 = rnd.Next(0, 10);
            int number6 = rnd.Next(0, 10);
            string smsCode = $"{number1}{number2}{number3}{number4}{number5}{number6}";
            return smsCode;
        }
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }


        static int Sum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Sum(4,7));
            Console.WriteLine(Sum(7,10));
            

















        {
            //Console.WriteLine(GenerateSmsCode());
            //Console.WriteLine("*************");
            //Console.WriteLine(GenerateSmsCode());
        }
    }
}
