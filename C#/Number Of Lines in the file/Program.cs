using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
         FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate);
        StreamReader sr = new StreamReader(fs);
        string line = "";
        int countLines = 0;
        while ((line = sr.ReadLine()) != null)
        {
            countLines++;
        }
        Console.WriteLine($"The file has {countLines} lines");
        sr.Close();
        fs.Close();
    }
}