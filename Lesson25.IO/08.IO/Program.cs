// MemoryStream klasının obyektini yaradırıq.
MemoryStream memory = new MemoryStream();

// Lazım olacaq ölçünü təyin edirik.
memory.Capacity = 256;

// Stream-ə baytları yazırıq.
for (var i = 0; i < 256; i++)
{
    memory.WriteByte((byte)i);
}

// Daxili göstəricini ən əvvələ yönəldirik.
memory.Position = 0;

// Stream-dan baytları oxuyuruq.
for (int i = 0; i < 256; i++)
{
    Console.Write(" " + memory.ReadByte());
}

Console.WriteLine("\n" + new string('-', 80));

// MemoryStream-də olan batları massivə yazırıq.
byte[] array = memory.ToArray();

foreach (byte b in array)
{
    Console.Write(b);
}

Console.WriteLine("\n" + new string('-', 80));

// MemoryStream-də olan məlumatları fayla yazırıq.
FileStream file = new FileStream("Dump.dat", FileMode.Create, FileAccess.ReadWrite);
memory.WriteTo(file);

// Daxili göstəricini ən əvvələ yönəldirik.
file.Position = 0;

// Fayldan baytları oxuyuruq.
for (int i = 0; i < 256; i++)
{
    Console.Write(" " + file.ReadByte());
}

memory.Close();
file.Close();

// Delay.
Console.ReadKey();