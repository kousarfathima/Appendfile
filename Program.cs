using System;
using System.IO;

class FileIOExample
{
    static void Main()
    {
        string fileName = "example.txt";

        // Creating and writing to a file
        CreateAndWriteToFile(fileName);

        // Opening and reading the file
        ReadFile(fileName);

        // Appending a line to the file
        AppendLineToFile(fileName, "This is a new line.");

        // Reading the file again to see the appended line
        ReadFile(fileName);
    }

    static void CreateAndWriteToFile(string fileName)
    {
        string content = "Hello, World!";

        // Create a new file and write the content to it
        File.WriteAllText(fileName, content);

        Console.WriteLine("File created and written successfully.");
    }

    static void ReadFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(fileName);

            Console.WriteLine("File content:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    static void AppendLineToFile(string fileName, string line)
    {
        // Append the line to the file
        File.AppendAllText(fileName, Environment.NewLine + line);

        Console.WriteLine("Line appended to the file.");
    }
}
