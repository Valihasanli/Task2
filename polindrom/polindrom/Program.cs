using System;
namespace az
{
    internal class A
    {
        static void Main(string[] args)
        {
            int a = 122211;
            int p = 0;
            int b = a;
            int x;
            while (b > 0)
            {
                x = b % 10;
                p = (p * 10) + x;
                b = b / 10;
            }
            if (a == p)
            {
                Console.WriteLine("polindromdur");
            }
            else
            {
                Console.WriteLine("polindrom deyil");
            }
        }

    }

}
