// using System means that we can use classes from the System namespace
using System;

namespace StudyMethod
{
    class StudyMethod
    {
        static int onAdd(int x, int y, string name = "static value")
        {
            Console.WriteLine(name);
            int z = x + y;
            return z;
        }
        static void Main(string[] args)
        {
            int result = onAdd(5, 3);
            Console.WriteLine("result1 - " + result);
            Console.WriteLine("result2 - " + onAdd(5, 5, "dynamic value"));
        }
    }
}