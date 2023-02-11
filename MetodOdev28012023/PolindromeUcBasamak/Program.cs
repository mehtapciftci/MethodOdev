using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolindromeUcBasamak
{
    class Program
    {
        static void Main(string[] args)
        {
            long basamak = long.Parse(Console.ReadLine());

            Console.WriteLine(GetNum(basamak));
            Console.ReadLine();

        }

        static long GetNum(long basamak)
        {
            int sayac = 0;
            long sonuc;
            long temp;
            string ters = "";
            long[] sayilar = new long[98999]; // 100*100 ile 999*999 arası sayı kadar değer atadım.  



            for (long i = (long)Math.Pow(10, basamak - 1); i < (long)Math.Pow(10, basamak); i++)
            {
                for (long j = (long)Math.Pow(10, basamak - 1); j < (long)Math.Pow(10, basamak); j++)
                {
                    temp = i * j;
                    sonuc = temp;
                    while (temp != 0)
                    {
                        ters += (temp % 10).ToString();
                        temp /= 10;
                    }
                    if (sonuc.ToString() == ters)
                    {
                        sayilar[sayac] = sonuc;
                        sayac++;
                    }
                    ters = "";
                }
            }

            Array.Sort(sayilar);
            Array.Reverse(sayilar);
            return sayilar[0];



        }
    }
}
