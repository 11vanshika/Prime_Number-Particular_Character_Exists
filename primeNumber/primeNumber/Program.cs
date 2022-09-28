using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.Write("1-100 Prime number:");
            for(int number = 1; number <= 100; number++)
            {
                count =0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                    if (count == 2)
                    {
                        Console.Write(number + ",");
                    }
            }
        }
    }
}
