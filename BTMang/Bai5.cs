using System;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so phan tu n = : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Mang null hoac rong, khong xu ly.");
                return;
            }
            else
            {
                int max = a[0];
                foreach (int i in a)
                    if (i > max)
                        max = i;
                Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
            }
            Console.ReadKey();

        }
    }
}
