namespace Lesson16_Strings
{
    internal class Program
    {
        private static bool letter;

        static void Main(string[] args)
        {
            string yazi;
            yazi = "Bu bir string ifadedir";
            // StringIntro(yazi);
            StringMethods();
        }
        
        static void StringIntro(string yazi)
        {
            string value = "Türkiyenin başkenti Ankaradır";
            string newValue = "Yeni Değer";
            // Console.WriteLine(value.GetType());
            // Console.WriteLine(yazi.GetType());

            //for (int i = 0; i < value.Length; i++)
            //{
            //    if +1<value.Length  value[i + i] == '\'')
            //    {
            //        Console.WriteLine($"{value[i]}{value[i + 1]}");
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(value[i]);
            //    }
            //}
            //foreach
            //int index = 1;
            //foreach (var letter in value)
            //{
            //    if(index < value.Length)
            //    {
            //        char nextChar = value[index];
            //    if (index<value.Length && value[index] == '\'')
            //    {
            //            Console.WriteLine($"{letter}{value[index]}");
            //    }
            //    if  (letter != '\'')
            //    {
            //        Console.WriteLine(letter);
            //    }
            //    index++;

            //    }
              
















            }
        static void StringMethods()
        {
            //string text = "InfoTech Academy MSCD Yazılım Eğitimine Hoş Geldiniz";
            //Console.WriteLine(text);
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());

            //object newText = text.Clone;
            //Console.WriteLine($"text i harfi ile bitiyor mu ?{text.ToLower().EndsWith("i")}");
            //Console.WriteLine($"text I harfi ile başlıyormu ?{text.StartsWith("I")}");
            //Console.WriteLine($"t harfi text içerisinde kaçıncı sırada?:{text.IndexOf("T")}");
            //Console.WriteLine($"MSCD ifadesi text içerisinde kacıncı sırada ?:{text.IndexOf("MSCD")}");
            //Console.WriteLine($"text içerisindeki en son e harfinin index numarası: {text.LastIndexOf("e")}");
            //Console.WriteLine(text.IndexOf("x"));

            //Console.WriteLine(text.Insert(9,"(Mecidiyeköy)"));
            //Console.WriteLine(text.Substring(17,4));
            //Console.WriteLine(text.Substring(17));

            string address = "Kemal Candan mh.,Karanfil sk.,Nida apt,D:5,Üsküdar,İstanbul";
            string[] adressArray = address.Split(',');
            foreach(string str in adressArray)
            {
                Console.WriteLine(str.Trim());
            }



        }

    }
}
