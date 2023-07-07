using (FileStream fstream = new FileStream("", FileMode.OpenOrCreate))
{
    //ignore
}

//or...

using FileStream fs = new FileStream("", FileMode.Open);