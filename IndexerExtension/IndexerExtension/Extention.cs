using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtension
{
    public static class Extention
    {
        /// <summary>
        /// Bu method stringin lenght-i qaytarir
        /// </summary>
        /// <param name="str">Extention string</param>
        public static void GetStrLenght(this string str)
        {
            Console.WriteLine($"String lenght:{str.Length}");
        }

        public static int Sum(this int n1,int n2)
        {
            return n1 + n2;
        }
    }
}
