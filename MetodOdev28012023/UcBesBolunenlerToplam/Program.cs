using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcBesBolunenlerToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = GetMultiples(1000);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static int GetMultiples(int nums)
        {

            int sum = 0;
            for (nums=nums-1; nums >= 3; nums--)
            {
                if (nums % 3 == 0 || nums % 5 == 0)
                {
                    sum += nums;
                }
            }
            
           
            return sum;
        }
    }
}
