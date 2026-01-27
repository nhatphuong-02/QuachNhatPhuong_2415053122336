using System;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String hoTen;
            Console.Write("Nhap vao ho ten: ");
            hoTen = Console.ReadLine();
            int max;
            if (String.IsNullOrWhiteSpace(hoTen))
                return;
            else
            {
                hoTen.Trim();
                String[] chuoi = hoTen.Split(' ');
                max = chuoi[0].Length;
                String c = chuoi[0];
                foreach (var i in chuoi)
                {
                    if (i.Length > max)
                    {
                        max = i.Length;
                        c = i;
                    }
                }
                Console.WriteLine($"Tu dai nhat trong chuoi la: {c}");
            }
            Console.ReadKey();
        }
    }
}
