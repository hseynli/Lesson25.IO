string path = @"C:\Windows\notepad.exe";
Console.WriteLine(path);

// Qeyd edilən ünvanda yerləşən faylın genişlənməsinin ekranda əks elətdirilməsi.
Console.WriteLine("Ext: {0}", Path.GetExtension(path));

// Random adın generasiya olunması
Console.WriteLine(Path.GetRandomFileName());

// Delay.
Console.ReadKey();