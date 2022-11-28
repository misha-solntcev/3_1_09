using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 9. Дано целое число N (> 1). Найти наименьшее целое число K, 
    при котором выполняется неравенство 3K > N. */

namespace _3_1_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 12;
            int K = 0;
            while (3 * K <= N)
            {                
                K++;
                Console.WriteLine(K);
            }            
            Console.ReadKey();
        }
    }
}
