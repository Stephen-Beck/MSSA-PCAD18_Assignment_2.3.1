// Write a console application to create a text file and save your basic details like name, age, address (use dummy data).
// Read the details from the same file and print on console.

using System.IO;

namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\TextFile.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter writer = new(path))
                {
                    writer.WriteLine("Name: Billy Windows");
                    writer.WriteLine("Age: 70");
                    writer.WriteLine("Address: 1 Microsoft Way, Redmond, WA 98052");
                }
            }

            try
            {
                using (StreamReader reader = new(path))
                {
                    string text = reader.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
