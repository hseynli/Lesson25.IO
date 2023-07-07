Console.OutputEncoding = System.Text.Encoding.UTF8;

FileInfo file = new FileInfo(@"C:\Windows\notepad.exe");

// Faylı kopyalayırıq
try
{
    file.CopyTo(@"D:\aaaa.exe");
    Console.WriteLine("Fayl uğurla kopyalandı!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

// Delay.
Console.ReadKey();