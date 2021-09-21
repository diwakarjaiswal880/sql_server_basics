using System;
using System.Linq;

namespace LINQMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array 'a' type of int having the values 1 to 9  
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("The Minimum value in the given array is:");

            /*Min() function is applied on the array 'a' 
             to find the minimum number from the array*/
            int minimumNum = a.Min();

            Console.WriteLine("The minimum Number is {0}", minimumNum);

            /*Max() function is applied on the array to  
            find the maximum value from the arra*/
            int maximumNum = a.Max();

            Console.WriteLine("The maximum Number is {0}", maximumNum);

            //Num.Sum() is used to add the value of the Num array  
            int Sum = a.Sum();
            Console.WriteLine("The Sum is {0}", Sum);

            Console.WriteLine("Find the count of the elements:");
            /*to find the number of values in Num array will apply 
             the 'count' function on the array Num*/

            int Count = a.Count();
            /*print the value of 'Count' variable which is type of int 
             with the helplp of WriteLine function*/

            Console.WriteLine("The Count is {0}", Count);

            Console.ReadLine();
        }
    }
}
