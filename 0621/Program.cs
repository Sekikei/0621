using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _0621
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long p = 1;
            int keta = 1;
            while (p * 26 < n)
            {
                p *= 26;
                n -= p;
                keta++;
            }
            n--;

            var a = new char[keta];
            for (int i = keta - 1; i >= 0; i--)
            {
                a[i] = 'a';
                if (n == 0) continue;
                a[i] += (char)(n % 26);
                n /= 26;
            }
            var ans = new string(a);
            Console.WriteLine(ans);

        }
    }
}
