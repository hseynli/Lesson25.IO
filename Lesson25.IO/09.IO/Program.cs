Console.OutputEncoding = System.Text.Encoding.UTF8;

// Fayl yaradırıq.
FileInfo file = new FileInfo("Text.txt");

// StreamWriter klasının instansı vasitəsilə fayla bir neçə sətir məlumat yazırıq. 
StreamWriter writer = file.CreateText();

writer.WriteLine("Mətnin birinci sətri...");
writer.WriteLine("Mətnin ikinci sətri...");

// Yeni sətrin başlanmasını daxil edirik.
writer.Write(writer.NewLine);

writer.WriteLine("Üçüncü sətrdə ədədlər olacaqdır:");

for (int i = 0; i < 10; i++)
{
    writer.Write(i + " ");
}

// Yeni sətrin başlanmasını daxil edirik.
writer.Write(writer.NewLine);

// Close() metou avtomatik olaraq bütün buferi təmizləyir!
writer.Close();

Console.WriteLine("Fayl Text.txt yaradıldı və onun daxilinə məlumat yazıldı.");

// Delay.
Console.ReadKey();