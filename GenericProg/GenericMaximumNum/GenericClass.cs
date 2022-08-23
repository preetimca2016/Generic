using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximumNum
{
    class GenericClass<T>
    {
        public T[] arr;
        public GenericClass(T[] arr)
        {
            this.arr = arr;
        }

        public GenericClass(string[] stringArray)
        {
        }

        public void ToPrintElements()
        {
            Console.WriteLine("Displaying Array elemnts using Generic Class");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
