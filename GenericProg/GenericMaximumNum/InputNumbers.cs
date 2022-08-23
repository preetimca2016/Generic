using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximumNum
{
    class InputNumbers
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("******************************************************************************************************************");
        }
    }
}
