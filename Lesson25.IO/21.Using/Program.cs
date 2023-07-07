FileStream fstream = null;
try
{
    fstream = new FileStream("someFile.txt", FileMode.OpenOrCreate);
}
catch
{ }
finally
{
    fstream.Close();
}