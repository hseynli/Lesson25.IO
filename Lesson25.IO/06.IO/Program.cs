Console.OutputEncoding = System.Text.Encoding.UTF8;

// D diskinin kökündə yeni fayl yaradırıq:
FileInfo file = new FileInfo(@"D:\Test.txt");

// FileMode.OpenOrCreate - ƏGƏR: mövcüddursa ONDA: açmaq ƏKS HALDA: yenisini yaratmaq
// FileAccess.Read - ancaq oxumaq üçün,
// FileShare.None - ümumi səlahiyyət - YOX.
FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

// Yaradılan fayl haqqında məlumatı ekranda əks elətdiririk.
Console.WriteLine("Full Name   : {0}", file.FullName);
Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
Console.WriteLine("CreationTime: {0}", file.CreationTime);

Console.WriteLine("Faylı silmək üçün ixtiyari bir düyməni sıxın.");
Console.ReadKey();

// FileStream-i bağlayırıq. 
stream.Close();

// Faylı silirik.
file.Delete();

Console.WriteLine("Fayl uğurlu şəkildə silindi.");

// Delay.
Console.ReadKey();