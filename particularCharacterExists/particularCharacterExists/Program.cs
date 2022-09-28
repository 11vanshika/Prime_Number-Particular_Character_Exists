using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particularCharacterExists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Character which you find");
             char checkValue = Convert.ToChar(Console.ReadLine());

            char[] chars = str1.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == checkValue)
                {
                    Console.WriteLine("Character is present :" + i);
                    count++;
                }
            }
            if(count==0){
            Console.WriteLine("Character is not present");
            }
        }
    }
}
