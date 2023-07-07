Console.OutputEncoding = System.Text.Encoding.UTF8;

DirectoryInfo directory = new DirectoryInfo(@"D:\TESTDIR");
// Console.WriteLine(directory.FullName);
// TESTDIR kataloqunda yeni alt kataloqların yaradılması.
if (directory.Exists)
{
    // D:\TESTDIR\SUBDIR yaradırıq.
    directory.CreateSubdirectory("SUBDIR");

    // D:\TESTDIR\MyDir\SubMyDir yaradırıq.
    directory.CreateSubdirectory(@"MyDir\SubMyDir");

    Console.WriteLine("Qovluqlar yaradıldı.");
}
else
{
    Console.WriteLine("{0} adlı direktoriyalar mövcüd deyil..", directory.FullName);
}

// Delay.
Console.ReadKey();