using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnBuyukAsalCarpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCiftToplam(13195));
            Console.Read();
        }
        static long GetCiftToplam(long num)
        {           
            for (long i = 2; i <= num/2 ; i++)
            {
                if (num%i==0)
                {
                    num /=  i;
                    i = 2;
                }
            }

            return num;
        }
    }
}
