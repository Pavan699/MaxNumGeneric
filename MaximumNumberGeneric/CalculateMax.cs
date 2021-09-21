using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumberGeneric
{
    class CalculateMax
    {
        /// <summary>
        /// Check() Generic method to handle all datatypes 
        /// </summary>
        /// <typeparam name="datatype">Generic datatype</typeparam>
        /// <param name="num1">Number_One</param>
        /// <param name="num2">Number_Two</param>
        /// <param name="num3">Number_Three</param>
        /// <returns></returns>
        public static dynamic Check<datatype>(datatype num1 , datatype num2 , datatype num3) where datatype : IComparable
        {
            if(num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {               
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {                
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            Console.WriteLine(num1);
            return num1;
        }     
    }
}
