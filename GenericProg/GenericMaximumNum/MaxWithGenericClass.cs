namespace GenericMaximumNum
{
    class MaxWithGenericClass<T> where T : IComparable
    {
        public T x, y, z;
        public MaxWithGenericClass(T x, T y, T z)   //parameterised constructor.
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static T MaxValue(T x, T y, T z)
        {
            //result will be either 0 or 1 or -1
            //-1 for lesser value, 1 for greater value, 0 for equal value
            int result = x.CompareTo(y);
            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0 )
            {
                return x;
            }
            else if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0)
            {
                return y;
            }
            else if (z.CompareTo(x) > 0 && z.CompareTo(y) > 0)
            {
                return z;
            }
            else
            {
                Console.WriteLine("Either number having same or equal value");
                return default;
            }
        }
        public void MaxTest()
        {
            //max value(x, y, z);
            Console.WriteLine("{0} is max", MaxValue(x, y, z));
        }

    }
}
