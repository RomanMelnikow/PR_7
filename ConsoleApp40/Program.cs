using System;
using System.IO;

var fs = default(FileStream);
try
{
    // Opens a text tile.
    fs = new FileStream(@"C:\1111\data.txt", FileMode.Open);
    var sr = new StreamReader(fs);

    // A value is read from the file and output to the console.
    string? line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"[Data File Missing] {e}");
    throw new FileNotFoundException(@"[data.txt not in c:\1111 directory]", e);
}
finally
{
    if (fs != null)
        fs.Close();
}