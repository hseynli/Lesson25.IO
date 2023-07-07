StringWriter writer = new StringWriter();
writer.WriteLine("Hello all ");
writer.Write("This is a multi-line ");
writer.WriteLine("text string.");

Console.WriteLine(writer.ToString());

// Delay.
Console.ReadKey();