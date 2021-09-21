using System;
using System.Linq;

namespace LINQAggregateFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we are creating the array Num type of int  
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Product of the element:");
            //Now we will calculate the average of the numbers by applying the Aggregate function  
            double Average = Num.Aggregate((a, b) => a * b);

            Console.WriteLine("Product is {0}", Average); //Output 362880 ((((((((1*2)*3)*4)*5)*6)*7)*8)*9)  
                                                          
            //Create an array of string of the name charlist  
            string[] charlist = { "a", "b", "c", "d" };

            var concat = charlist.Aggregate((a, b) => a + ',' + b);

            Console.WriteLine("the Concatenated String: {0}", concat); // Output a,b,c,d  

            Console.ReadLine();
        }
    }
}
