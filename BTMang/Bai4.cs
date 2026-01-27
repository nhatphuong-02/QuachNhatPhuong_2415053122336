using System;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so phan tu n = : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int tong = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            if (a == null)
                Console.WriteLine("Lỗi!");
            else
            {

                foreach (int i in a)
                    tong = tong + i;
                Console.WriteLine($"Tong cac phan tu la: {tong}");
            }
            Console.ReadKey();
        }
    }
}
