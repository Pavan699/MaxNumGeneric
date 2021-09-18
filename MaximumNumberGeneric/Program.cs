using System;

namespace MaximumNumberGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number Program By Using Generic Class");
            Console.WriteLine("Maximum Value For Integer,Float and String :");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            new CalculateMax<int>(34, 156, 16).Print();            
            new CalculateMax<float>(3.8f, 1.8f, 9.4f).Print();           
            new CalculateMax<string>("Apple","Peach","Banana").Print();           
        }
    }
}
