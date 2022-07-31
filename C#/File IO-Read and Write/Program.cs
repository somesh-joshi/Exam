using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("input.csv", FileMode.OpenOrCreate);
        StreamReader sr = new StreamReader(fs);
        FileStream f = new FileStream("output.txt", FileMode.Create);
        StreamWriter streamWriter = new StreamWriter(f);
        string line = "";
        //while ((line = sr.ReadToEnd()) != null)
        //{
        //    streamWriter.WriteLine(line);
        //}
        line= sr.ReadToEnd();
        streamWriter.Write(line);
        
        
        streamWriter.Close();
        sr.Close();
        f.Close();
        fs.Close();
    }
}