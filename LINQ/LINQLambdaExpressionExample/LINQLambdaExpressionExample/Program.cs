using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLambdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //list to store the countries type of string  
            List<string> countries = new List<string>();

            countries.Add("India");

            countries.Add("US");

            countries.Add("Australia");

            countries.Add("Russia");

            //use lambda expression to show the list of the countries  
            IEnumerable<string> result = countries.Select(x => x+" "+x);

            //foreach loop to display the countries  
            foreach (var item in result)   
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
