// Faylı oxumaq üçün açırıq.
FileStream file = File.Open("Hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

// Fayldan oxumaq üçün stream yaradırıq.
StreamReader reader = new StreamReader(file);

// Sona qədər oxuyuruq.
Console.Write(reader.ReadToEnd());

// Faylı bağlayırıq və stream-i silirik.
reader.Close();
//file.Close(); // Bağlamaq mütləq deyil, çünki reader özü bağlayacaq.

Console.WriteLine("\n");

// Digər üsuldan istifadə edərək faylı açırıq.
reader = File.OpenText("Hello.txt");

// Sona qədər oxuyuruq və faylı bağlayırıq.
Console.Write(reader.ReadToEnd());
reader.Close();

Console.WriteLine("\n");

// Faylda yerləşən bütün mətni oxuyuruq.
Console.WriteLine(File.ReadAllText("Hello.txt"));

// Задержка.
Console.ReadKey();