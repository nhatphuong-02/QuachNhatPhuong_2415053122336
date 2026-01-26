    Console.Write("Nhap ho ten: ");
    String hoTen = Console.ReadLine();

    if(String.IsNullOrWhiteSpace(hoTen))
        Console.WriteLine("Ho ten nhap vao k hop le!");
    else{
        String[] ar = hoTen.Trim().Split(" ");
        String result = "";

        foreach (var item in ar){  
            if(String.IsNullOrWhiteSpace(item))
                continue;
            
            char[] a = item.ToCharArray();
            result = result+char.ToUpper(a[0]);
            for(int i = 1; i< a.Length; i++ ){
                a[i] = char.ToLower(a[i]);
                result += a[i];
            }
            result +=" ";
        }
        Console.WriteLine(result.Trim());
    }