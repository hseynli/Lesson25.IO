Console.OutputEncoding = System.Text.Encoding.UTF8;

// D diskinin kökündə yeni fayl yaradırıq:
var file = new FileInfo(@"D:\Test.txt");

FileStream stream = file.Create();

// Yeni yaradılan fayl haqqında məlumatı ekranda əks elətdiririk.
Console.WriteLine("Full Name   : {0}", file.FullName);
Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
Console.WriteLine("CreationTime: {0}", file.CreationTime);

Console.WriteLine("Faylı silmək üçün ixtiyari bir düyməni sıxın.");
Console.ReadKey();

// FileStream-i bağlayırıq.
stream.Close();

// Faylı silirik.
file.Delete();

Console.WriteLine("Fayl uğurla silindi.");

// Delay.
Console.ReadKey();