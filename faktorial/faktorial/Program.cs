using System;
namespace az
{
    internal class A
    {
        static void Main(string[] args)
        {
            int a = 3;
            int f = 1;
            int i;
            for (i = 1; i <= a; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }

    }

}
