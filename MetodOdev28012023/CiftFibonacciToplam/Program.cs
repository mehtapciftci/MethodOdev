using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftFibonacciToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciCiftToplam(4000000));
            Console.ReadKey();
        }
        static int FibonacciCiftToplam(int num)
        {
            int x = 1, y = 0, sum = 0;            
            for (int i = 2; y < num;)
            {
                y = x + i;
                x = i;
                i = y;
                if (y<num && y%2==0)
                {
                    sum += y;
                }
            }
            return sum+2;
        }
    }
}
