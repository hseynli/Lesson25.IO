Console.OutputEncoding = System.Text.Encoding.UTF8;

DirectoryInfo directory = new DirectoryInfo(@".");


// Qeyd olunan qovluğun mövcüdluğunu yoxlayırıq.
if (directory.Exists)
{
    // Kataloq haqqında məlumatı ekranda əks elətdiririk.                
    Console.WriteLine("FullName    : {0}", directory.FullName);
    Console.WriteLine("Name        : {0}", directory.Name);
    Console.WriteLine("Parent      : {0}", directory.Parent);
    Console.WriteLine("CreationTime: {0}", directory.CreationTime);
    Console.WriteLine("Attributes  : {0}", directory.Attributes.ToString());
    Console.WriteLine("Root        : {0}", directory.Root);
    Console.Write("\n");

    // .txt genişlənməsi ilə olan bütün faylları əldə edirik.
    FileInfo[] files = directory.GetFiles("*.txt");

    // Cari qovluqda .txt genişlənməsində neçə fayl vardır..
    Console.WriteLine("{0} sayda *.txt fayl aşkar edilmişdir\n", files.Length);

    // Hər bir fayl haqqında məlumatı ekranda əks elətdirik.
    foreach (FileInfo file in files)
    {
        Console.WriteLine("File name : {0}", file.Name);
        Console.WriteLine("File size : {0}", file.Length);
        Console.WriteLine("Creation  : {0}", file.CreationTime);
        Console.WriteLine("Attributes: {0}", file.Attributes.ToString());
        Console.Write("\n");
    }
}
else
{
    Console.WriteLine("{0} adlı direktoriya mövcüd deyil.", directory.FullName);
}

// Delay.
Console.ReadKey();