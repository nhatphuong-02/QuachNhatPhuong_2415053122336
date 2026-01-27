using System;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String hoTen;
            Console.Write("Nhap vao ho ten: ");
            hoTen = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(hoTen))
                return;
            else
            {
                hoTen.Trim();
                String[] chuoi = hoTen.Split(' ');
                foreach (var i in chuoi)
                {
                    Console.WriteLine($"{i} ");
                }
            }
            Console.ReadKey();
        }
    }
}
