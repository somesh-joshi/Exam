using System;
using System.Text.RegularExpressions;
using  System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the file name");
        string fileName=Console.ReadLine();
        Console.WriteLine("Enter the character to be counted");
        string patern = Console.ReadLine();
        Regex regex = new Regex(patern,RegexOptions.IgnoreCase);
        FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
        StreamReader sr = new StreamReader(fs);
        string line = "";
        int count = 0;
        while ((line = sr.ReadLine()) != null)
        {
            count+=regex.Matches(line).Count;
        }
        Console.WriteLine($"File '{fileName}' has {count} instances of letter '{patern}'.");
        sr.Close();
        fs.Close();
    }
}