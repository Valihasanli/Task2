using System;
namespace az
{
    internal class A
    {
        static void Main(string[] args)
        {
            int a = 113;
            int count = 0;
            int b = a / 2;
            int i;
            if (a == 1) { Console.WriteLine("eded ne sadedir ne murekkebdir"); }
            else
            {
                for (i = 2; i <= b; i++)
                {
                    if (a % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine("eded murekkebdir");
                }
                else { Console.WriteLine("eded sadedir"); }
            }
        }

    }

}
