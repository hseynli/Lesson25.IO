string[] fileContent =  File.ReadAllLines("..\\..\\..\\..\\file.txt");

foreach (string line in fileContent)
{
    Console.WriteLine(line);
}