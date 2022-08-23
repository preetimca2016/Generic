namespace GenericMaximumNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[3];
            //    int i;
            //Console.WriteLine("Input 3 elements in the array:");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Element {0} :",i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());   
            //}
            //InputNumbers.ToPrint(arr);
            //new PrintArray<int>(arr).ToPrint();
            int[] intArray = { 45, 65, 78 };
            string[] stringArray = {"Apple", "Banana", "Kiwi" };
            double[] doubleArray = { 1.3, 5.7, 4.3 };

            Console.WriteLine("Choose program to execute");
            Console.WriteLine("1.Displaying array element using generic method concept.\n2.Generic class concept for printing an array\n3.find max value\n4.find max value using generic class\n5.exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nGeneric method");
                    GenericMethodUse.ToPrintElements<int>(intArray);  //Calling generic method for integer datatype
                    GenericMethodUse.ToPrintElements<string>(stringArray);
                    GenericMethodUse.ToPrintElements<double>(doubleArray);
                    break;
                case 2:
                    Console.WriteLine("Generic Class Concept");
                    GenericClass<int> genericclass = new GenericClass<int>(intArray);    //object created for constructor
                    genericclass.ToPrintElements();                                   //Calling constructor Method

                    GenericClass<double> genericclass1 = new GenericClass<double>(doubleArray);
                    genericclass1.ToPrintElements();

                    GenericClass<string> genericclass2 = new GenericClass<string>(stringArray);
                    genericclass2.ToPrintElements();

                    //new GenericClass<int>(intArray).ToPrintElements();                        //Calling Constructor by another way to reduce lines of code
                    //new GenericClass<double>(doubleArray).ToPrintElements();
                    //new GenericClass<string>(stringArray).ToPrintElements();
                    break;
                case 3:
                    Console.WriteLine("Max Value");


                    MaxWithGenericClass maxObj<int>(intArray).MaxValue();
                        break;
                case 4:
                    break;
            }
        }
        
    }
}