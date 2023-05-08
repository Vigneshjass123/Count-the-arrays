using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 5, 7, 8, 9, 10 };
            int count = 0;
            for(int i =0;i<ar.Length;i++)
            {
                count++;
            }
            Console.WriteLine("Count the digit of = " + count);
        }
    }
}
