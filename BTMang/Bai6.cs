using System;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so phan tu n = : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int d = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in a)
                if (i % 2 == 0)
                    d++;
            Console.WriteLine($"So phan tu chan trong mang la: {d}");
            Console.ReadKey();
        }
    }
}
