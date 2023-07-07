// Cari kataloqda yeni fayl yaradırıq.
var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

// Baytları fayla yazırıq.
for (int i = 0; i < 256; i++)
{
    stream.WriteByte((byte)i);
}

Console.WriteLine(stream.Position);
// Daxili göstəricini ən əvvələ yönəldirik.
stream.Position = 0;

// Fayldan baytları oxuyuruq.
for (int i = 0; i < 256; i++)
{
    Console.Write(" " + stream.ReadByte());
}

// FileStream-i bağlayırıq. 
stream.Close();

// Delay.
Console.ReadKey();