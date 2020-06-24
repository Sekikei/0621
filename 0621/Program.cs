using System;
using System.Collections.Generic;

namespace _0621
{
    class Program
    {
        static void Main(string[] args)
        {
          //  int[] i_ary = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string[]array=Console.ReadLine().Split(' ');
            int num = int.Parse(array[0]);
            int buy = int.Parse(array[1]);

            List<string> item_list = new List<string>(Console.ReadLine().Split(' '));
            item_list.Sort();
            int ans = 0;
            for(int i=0;i<buy;i++)
            {
                ans = ans + int.Parse(item_list[i]);
            }
            Console.WriteLine(ans);
        }
    }
}
