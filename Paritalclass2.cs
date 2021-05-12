using System;

namespace partialclass
{
   public partial class Demo
    {
        public  void Multiplication(int AddValue1 = 12, int AddValues2=20)
        {
            int Sum = AddValue1 * AddValues2;
            Console.WriteLine(Sum);
        }
        
    }
}
