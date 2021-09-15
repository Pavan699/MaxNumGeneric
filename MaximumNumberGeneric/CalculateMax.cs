using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberGeneric
{   
    class CalculateMax<classtype>//create the "classtype" for the class
    {
        dynamic num1;//class intances to store the data
        dynamic num2;
        dynamic num3;
        public CalculateMax(classtype numOne, classtype numTwo, classtype numThree)//constructor creation
        {
            this.num1 = numOne;//assining the values
            this.num2 = numTwo;
            this.num3 = numThree;
        }          
        public void Print()//print method to print the maximum values for Integer,Float and String
        {
            if(num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                Console.WriteLine("Maximum Value is : " + num1);
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                Console.WriteLine("Maximum Value is : " + num2);
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                Console.WriteLine("Maximum Value is : " + num3);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
        }           
    }
}
