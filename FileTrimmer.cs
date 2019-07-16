using System;
using System.Linq;
using System.IO;

namespace FileTrimmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the target file: ");
            string path = Console.ReadLine();
            byte[] content = File.ReadAllBytes(path);
            Console.WriteLine("Please enter the number of bytes you want to keep:");
            string length = Console.ReadLine();
            File.WriteAllBytes(path, content.Take(int.Parse(length)).ToArray());
        }
    }
}
