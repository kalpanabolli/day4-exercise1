using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conapp_enum
{
    internal class Program
    {
        enum seasons
        {
            winter,
            summer,
                rainy,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Current Season is: " + seasons.rainy);
            Console.WriteLine("Season Number is: \t"+(int)seasons.rainy);
            Console.ReadKey();
        }
    }
}
