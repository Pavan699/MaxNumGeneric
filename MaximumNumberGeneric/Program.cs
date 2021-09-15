using System;

namespace MaximumNumberGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number Program");
            int MaxNum = CalculateMax.Check(79, 156, 31);
            Console.WriteLine("Maximum Nuber is : {0}",MaxNum);
        }
    }
}
