using System;
namespace partialclass1
{
  public partial class Demo
    {
        public  void Add(int AddValue1, int AddValues2)
        {
            int Sum = AddValue1 + AddValues2;
            Console.WriteLine("Add Values : "+Sum);
        }
        static void Main(string[] args)
        { 
            Demo D1 = new Demo();
            Console.WriteLine("Hello World!");
            int x = 10;
            int y =5;
          D1.Add(x,y);
          D1.subraction(x,y);
        }
    }
    public partial class Demo
    {
         public  void subraction(int sAddValue1, int sAddValues2)
        {
            int Sum = sAddValue1 - sAddValues2;
            Console.WriteLine("Subraction Values : "+Sum);
        }
    }
}
