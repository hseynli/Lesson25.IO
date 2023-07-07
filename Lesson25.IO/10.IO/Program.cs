using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Fayl yaradırıq.
FileStream file = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

StreamWriter writer = new StreamWriter(file, Encoding.UTF8);

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

// StreamReader klasının köməklii ilə fayladakı məlumatları ekranda əks elətdiririk. 
Console.WriteLine("Text.txt faylının tərkibi:\n");

StreamReader reader = File.OpenText("Text.txt");
string input;

// Faylın tərkibini ekranda əks elətdiririk.
while ((input = reader.ReadLine()) != null)
{
    Console.WriteLine(input);
}

reader.Close();

// Delay.
Console.ReadKey();