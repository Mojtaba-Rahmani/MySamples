using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Fibonacci
    {
        public int BerechneFibonacci(int n)
        
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;

            int a = 0, b = 1, temp;

            Console.Write(a + " " + b);
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
                Console.Write(" " + b);
            }
            return b;
        }
    }
}
