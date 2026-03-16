using BaiTapLop;
Random rd = new Random();
List<Product> list = new List<Product>()
{
        new Product() { Id = "1", Name = "Laptop", Price = rd.NextDouble()*1000, Category = "Electronics" },
        new Product() { Id = "2", Name = "Smartphone", Price = rd.NextDouble()*1000, Category = "Electronics" },
        new Product() { Id = "3", Name = "Table", Price = rd.NextDouble() * 1000, Category = "Furniture" },
        new Product() { Id = "4", Name = "Chair",   Price = rd.NextDouble() * 1000, Category = "Furniture" },
        new Product() { Id = "5", Name = "Headphones", Price = rd.NextDouble() * 1000, Category = "Electronics" },
        new Product() { Id = "6", Name = "Sofa", Price = rd.NextDouble() * 1000, Category = "Furniture" }
};

var c31 = list.Where(x=> x.Price >500).ToList();
Console.WriteLine("Cac san pham co gia tren 500: ");
if (c31.Count > 0)
    c31.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Gia: {x.Price:F0}"));
else
    Console.WriteLine("Danh sach rong");

var c32 = list.OrderBy(x=>x.Price).ToList();
Console.WriteLine("\n\nDanh sach gia tang dan: ");
c32.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Gia: {x.Price:F0}"));

var c33 = c32.Take(3).ToList();
Console.WriteLine("\n\nDanh sach 3 san pham co gia re nhat: ");
c33.ForEach(x => Console.WriteLine($"Ten: {x.Name}; Gia: {x.Price:F0}"));

Console.Write("\n\nNhap tu khoa san pham can tim kiem: ");
var a = Console.ReadLine();
var c34 = list.Where(x => x.Name.Contains(a)).ToList();
if (c34.Count > 0)
    c34.ForEach(x => Console.WriteLine($"Id: {x.Id}; Ten: {x.Name}; Gia: {x.Price:F0}; Loai: {x.Category} "));
else
    Console.WriteLine("Khong tim thay san pham nao");

var c41 = list.Sum(x => x.Price);
Console.WriteLine($"\n\nTong gia cac san pham la: :{c41:F0}");

var c42 = list.Average(x => x.Price);
Console.WriteLine($"\nGia tri trung binh la: {c42:F0} ");


