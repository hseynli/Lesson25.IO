// Disklərin kolleksiyasının yaradılması.
DriveInfo[] drives = DriveInfo.GetDrives();

// Kopyuterin diskləri haqqında məlumatın ekranda əks elətdirilməsi.
foreach (DriveInfo drive in drives)
{
    Console.WriteLine("Drive: {0} Type: {1} TotalSize {2}", drive.Name, drive.DriveType, drive.TotalSize);
}

// Delay.
Console.ReadKey();