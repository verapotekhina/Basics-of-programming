using System;

/* Потехина Вера - реши то, не знаю что
 */
namespace StyleErrors
{
    class Program
    {
        static int Decode(string a)
        {
            int b = a.Length;
            for (int i = 0; i < b; i++)
            {
                if (a[i] == '.')
                {
                    a = a.Remove(i, 1);
                    i = i - 1;
                    b = b - 1;
                }
            }
            int n = int.Parse(a);
            n = n % 1024;
            return n;
        }

        static void Main()
        {
            string a;
            a = Console.ReadLine();

            Console.WriteLine(Decode(a));
        }
    }
}
