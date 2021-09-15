using System;

namespace MaximumNumberGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number Program");
            int MaxIntNum = CalculateMax.Check(79, 156, 31);
            Console.WriteLine("Maximum Integer Number is : {0}",MaxIntNum);
            float MaxFloatNum = CalculateMax.Check(3.8f, 1.8f, 9.4f);
            Console.WriteLine("Maximum Float Number is : {0}", MaxFloatNum);
            string MaxStringNum = CalculateMax.Check("Apple","Peach","Banana");
            Console.WriteLine("Maximum Float Number is : {0}", MaxStringNum);
        }
    }
}
