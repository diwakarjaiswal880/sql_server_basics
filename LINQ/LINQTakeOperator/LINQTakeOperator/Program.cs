using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTakeOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array countries of string type with the initialized array  
            string[] countries = { "India", "Ireland", "USA", "Russia", "China", "Australia", "Argentina", "Indonesia" };

            //The Example of LINQ Take Operator in Method Syntax

            //Here take() method will return the value from the String array upto three numbers.  
            IEnumerable<string> result = countries.Take(3);
            Console.WriteLine("The Example of LINQ Take Operator in Method Syntax");
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            //The Example of LINQ Take () Operator in Query Syntax
            IEnumerable<string> result1 = (from x in countries select x).Take(3);
            Console.WriteLine("\nThe Example of LINQ Take () Operator in Query Syntax");
            foreach (string s in result1)
            {
                Console.WriteLine(s);
            }

            //Example of LINQ TakeWhile in Method Syntax

            /*TakeWhile operator is used which will print  
              the values until the specified condition is satisfied.*/
            IEnumerable<string> result2 = countries.TakeWhile(x => x.StartsWith("I"));

            Console.WriteLine("\nExample of LINQ TakeWhile in Method Syntax");
            //foreach loop will print the value of the result  
            foreach (string s in result2)
            {
                Console.WriteLine(s);
            }

            //Example of LINQ TakeWhile in Query Syntax

            //apply the query syntax to print the values upto the specified condition.StartWith("A").  
            IEnumerable<string> result3 = (from x in countries select x).TakeWhile(x => x.StartsWith("I"));
            Console.WriteLine("\nExample of LINQ TakeWhile in Query Syntax");
            foreach (string s in result3)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
