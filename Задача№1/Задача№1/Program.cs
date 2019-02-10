using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        public static int p_find(string side)
        {
            int a = Convert.ToInt32(side);
            return a = 4 * a;
        }
        static void Main(string[] args)
        {
            string side;
            int p = 0;

            Console.Write("Enter your side:");
            side = Console.ReadLine();
            p = p_find(side);
            Console.WriteLine("Your P:" + p);
            Console.ReadKey();
        }
    }
}
