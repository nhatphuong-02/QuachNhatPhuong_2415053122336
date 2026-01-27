using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            String c;
            Console.Write("Nhap vao mot chuoi: ");
            c = Console.ReadLine();
            int d = 0;

            if (String.IsNullOrWhiteSpace(c))
                Console.Write(0);
            else
            {
                c.Trim();
                String[] chuoi = c.Split(' ');
                d = chuoi.Length;
            }
            Console.WriteLine($"So tu trong chuoi la: {d}");
            Console.ReadKey();
        }
    }
}
