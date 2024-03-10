using System;
namespace az
{
    internal class A
    {
        static void Main(string[] args)
        {
            int b;
            int h = 1;
            int a = 1234564;
            while (a > 0)
            {
                b = a % 10;
                h *= b;
                a /= 10;
            }
            Console.WriteLine(h);
        }

    }

}

