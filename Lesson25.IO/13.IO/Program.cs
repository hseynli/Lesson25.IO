File.AppendAllText("..\\..\\..\\..\\file.txt", "Test Test Test");

string fileContent = File.ReadAllText("..\\..\\..\\..\\file.txt");

Console.WriteLine(fileContent);