using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximumNum
{
    class GenericMethodUse
    {        
        public static void ToPrintElements<T>(T[] inputArray) //generic method syntax.
        {
            Console.WriteLine("Display array using Generic method");
            foreach (var element in inputArray)  //var take any data type 
            {
                Console.WriteLine(element);
            }
        }
    }
}
