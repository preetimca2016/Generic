using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProg
{
    class PrintArray<T>
    {
        // "T" is a type Parameter
        private T[] inputArray;

        public PrintArray(T[] arr)
        {
            inputArray = arr;
        }
        public void toPrint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("************************************");
        }
    }
}
