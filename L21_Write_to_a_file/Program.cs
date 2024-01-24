// read from a file
using System;
using System.IO;

class FileWriter
{
    static void Main()
    {
        string fileName = "test.txt";
        string content = "Some content more";

        using (StreamWriter sw = new StreamWriter(fileName, true))
        // the true boolean value use to append the existed file
        {
            sw.WriteLine(content);
            sw.Close();
        }
    }
}