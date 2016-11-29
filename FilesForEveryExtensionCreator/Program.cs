using System;

namespace FilesForEveryExtensionCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting creation of approx 70,000 files.");
                Console.WriteLine();
                Console.WriteLine("This will take a few minutes to complete.");
                Console.WriteLine();
                FileCreator.ArchiveAndCreateFiles();
                Console.WriteLine("Files created successfully");
                Console.WriteLine();
                Console.WriteLine(@"Look in C:\temp\FilesForEveryExtensionCreator\Files folder.");
                Console.WriteLine();
                Console.WriteLine("        ENJOY :-)     !");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("********");
                Console.WriteLine("********");
                Console.WriteLine("********");
                Console.WriteLine("Forking hell - something went wrong" + Environment.NewLine + ex);
                Console.WriteLine("********");
                Console.WriteLine("********");
                Console.WriteLine("********");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
            }
        }
    }
}
