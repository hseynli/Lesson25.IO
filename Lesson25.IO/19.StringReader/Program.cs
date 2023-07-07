string s = "Hello all!" + Environment.NewLine + "This is a multi-line \n\r text string.";

StringReader reader = new StringReader(s);

while (reader.Peek() != -1)
{
    string line = reader.ReadLine();
    Console.WriteLine(line);
}

// Delay.
Console.ReadKey();