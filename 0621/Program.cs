using System;
using System.Collections.Generic;

namespace _0621
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i_ary = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int num = i_ary[0];
            int buy = i_ary[1];

            List<int> item_list = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            item_list.Sort();
            int ans = 0;
            for(int i=0;i<buy;i++)
            {
                ans = ans + item_list[i];
            }
            Console.WriteLine(ans);
        }
    }
}
