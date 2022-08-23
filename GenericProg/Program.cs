namespace GenericProg
{
    class ArrayList
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'A', 'B', 'C', 'D' };
            double[] doubleArray = { 1.2, 1.3, 5.7, 4.3 };
            int[] intArray = { 1, 4, 6, 9, 2, 5 };

            Generic.toPrint(intArray);
            Generic.toPrint(doubleArray);
            Generic.toPrint(charArray);

            GenericMethod.toPrint<int>(intArray);
            GenericMethod.toPrint<double>(doubleArray);
            GenericMethod.toPrint<char>(charArray);

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();
        }
    }
}