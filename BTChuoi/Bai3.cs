using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            String c, cdx = "";
            Console.Write("Nhap vao mot chuoi: ");
            c = Console.ReadLine();
            int d = 0;

            if (String.IsNullOrWhiteSpace(c))
                Console.Write("Chuoi khong doi xung");
            else
            {
                c.Trim();
                String[] chuoi = c.Split(' ');
                for (int i = chuoi.Length - 1; i >= 0; i--)
                    cdx = cdx + chuoi[i];
            }
            if (cdx == c)
                Console.WriteLine("Chuoi doi xung");
            else
                Console.WriteLine("Chuoi khong doi xung");
            Console.ReadKey();
        }
    }
}
