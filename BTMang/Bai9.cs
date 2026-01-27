using System;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            string[] mang = new string[n];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Mang {i+1} = ");
                mang[i] = Console.ReadLine();
            }
            int d = 0;
            foreach (string s in mang)
            {
                if (!string.IsNullOrEmpty(s))
                    d++;
            }
            Console.WriteLine($"So phan tu khac null va rong trong mang la: {d}");
            Console.ReadKey();
        }
    }
}
