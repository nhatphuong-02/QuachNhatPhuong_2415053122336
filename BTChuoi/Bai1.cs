namespace Bai1;
class Program
{
    static void Main(string[] args)
    {
        String hoTen;
        Console.Write("Nhap vao ho ten: ");
        hoTen = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(hoTen))
            Console.Write("Loi!");
        else
        {
            hoTen.Trim();
            String [] chuoi = hoTen.Split(" ");
            String c = "";
            foreach(var i in chuoi)
            {
                if(String.IsNullOrWhiteSpace(i))
                    continue;
                i.Trim();
                char[] a = i.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                foreach(char j in a)
                    c = c + j;   
                c = c + " ";
            }
            Console.WriteLine(c.Trim());
        }
    }
}