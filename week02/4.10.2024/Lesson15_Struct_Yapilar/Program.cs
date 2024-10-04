namespace Lesson15_Struct_Yapilar
{
    public struct SampleStruct 
    {
        public int number;
        public string text;
        public void MyMethod() 
        {
            Console.WriteLine("Bu metot yapı (struct) içindedir.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {   // Class bellekteki HEAP tarafında tuturlurken, Struck ise bellekteri STACK tarafında tultulr.
            //Bunun farkı bize sunu anlatır:Heap tarafındaki reference değişkenler işi bittiğinde yok edilmeyip;Garbage Collector adlı bir
            //mekanizma tarafından bizim kontrolomüz dısında yok edilmeyi bekerler.
            //STACK tarafındaki değişkenler yani value type değişkenler ise işeri bittiğinde bellekten kendilğinden yok edilirler
            //Dolayısıyla bazı durumlarda struck , class kullanımına göre belle kperformansı acısından daha kullanıslı olucaktır.
            
            SampleStruct sampleStruct = new SampleStruct();
            sampleStruct.MyMethod();
        }
    }
}
