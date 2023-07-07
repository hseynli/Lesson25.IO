DirectoryInfo directory = new DirectoryInfo(@"C:\Windows\assembly");

// Kataloq haqqında məlumatı ekranda əks elətdiririk.
if (directory.Exists) // Əgər qeyd edilən direktoriya mövcüddursa, onda onun haqqında məlumatı ekranda əks elətdiririk.
{
    Console.WriteLine("FullName      : {0}", directory.FullName);              // Direktoriyanın tam adı.
    Console.WriteLine("Name          : {0}", directory.Name);                  // Direktoriyanın adı.
    Console.WriteLine("Parent        : {0}", directory.Parent);                // Parent direktoriya 
    Console.WriteLine("CreationTime  : {0}", directory.CreationTime);          // Direktoriyanın yaranma tarixi.
    Console.WriteLine("Attributes    : {0}", directory.Attributes.ToString()); // Attributlar.
    Console.WriteLine("Root          : {0}", directory.Root);                  // Direktoriyanın yerləşdiyi root disk.
    Console.WriteLine("LastAccessTime: {0}", directory.LastAccessTime);        // Direktoriyaya sonuncu müraciət tarixi.
    Console.WriteLine("LastWriteTime : {0}", directory.LastWriteTime);         // Время последнего изменения файлов в директории.                 
}
else
{
    Console.WriteLine("Directory with name {0} doesn't exists.", directory.FullName);
}



// Delay.
Console.ReadKey();