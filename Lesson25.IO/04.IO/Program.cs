Console.OutputEncoding = System.Text.Encoding.UTF8;

// Lokal disklər haqqında məlumatı ekranda əks elətdiririk.
string[] drives = Directory.GetLogicalDrives();
Console.WriteLine("Mövcüd disklər:");

foreach (string drive in drives)
    Console.WriteLine("- {0}", drive);

DirectoryInfo directory = new DirectoryInfo(@"D:\TESTDIR");

Console.WriteLine("\nSilməyə hazırlaşırıq:\n");
Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
Console.WriteLine(directory.FullName + @"\SUBDIR");
Console.WriteLine("\nSilmək üçün Enter düyməsini sıxın.\n");

// Silinmədən əvvəl düymənin sıxılmasını gözləmək.
Console.ReadKey();

try
{
    // Kataloqların silinməsi.
    Directory.Delete(@"D:\TESTDIR\SUBDIR");

    // İkinci parameter alt kataloqların da silinib-silinməyəcəyini təyin edir. 
    Directory.Delete(@"D:\TESTDIR\MyDir", true);

    Console.WriteLine("Kataloqlar uğurla silindi.");
}
catch (Exception e) 
{ 
    Console.WriteLine(e.Message); 
}

// Delay.
Console.ReadKey();