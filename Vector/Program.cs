using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<int> v1 = new Vector<int>(2, 4);
            Vector<int> v2 = new Vector<int>(5, 10);

            Vector<int> v3 = v1 + v2;
            Vector<int> v4 = v1 - v2;
            Vector<int> v5 = new Vector<int>(2, 4);

            Console.WriteLine("v1 [{0}]", v1);
            Console.WriteLine("v2 [{0}]", v2);
            Console.WriteLine("v1 + v2 = v3 [{0}]", v3);
            Console.WriteLine("v1 - v2 = v4 [{0}]", v4);
            Console.WriteLine("v5 [{0}]", v5);
            Console.WriteLine("v1 > v2 ? {0}", v1 > v2);
            Console.WriteLine("v4 < v3 ? {0}", v4 < v3);
            Console.WriteLine("v1 == v5 ? {0}", v1 == v5);
            Console.WriteLine("v1 != v4 ? {0}", v1 != v4);

            Console.WriteLine("--------------------------------");
            Vectors vectors = new Vectors();

            foreach(var item in vectors)
            {
                Console.WriteLine(item);
            }
        }
    }
}
