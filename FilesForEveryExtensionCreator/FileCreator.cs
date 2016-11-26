using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FilesForEveryExtensionCreator
{
    public class FileCreator
    {
        private static List<string> alphabet1 = new List<string> { "a", "B", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static List<string> alphabet2 = new List<string> { "a", "B", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static List<string> alphabet3 = new List<string> { "a", "B", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        private static List<string> alphabet4 = new List<string> { "X" };
        private const string fileName = "GitIgnore";
        private static string parentPath;
        private static string parentPathLetterFolder;
        private const string subPath = @"FilesForEverySuffixTemplate\Files";
        private static string targetPath;

        public static void ArchiveAndCreateFiles()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            parentPath = assemblyPath.Replace(@"FilesForEveryExtensionCreator\bin\Debug", string.Empty);

            ArchiveExistingFolder();

            CreateFiles(true);
            Console.WriteLine();
            Console.WriteLine("Starting phase 2");
            Console.WriteLine();
            CreateFiles(false);
        }

        /// <summary>
        /// Creates the following:
        ///    Files\A\GitIgnore.AAA, Files\A\GitIgnore.AAB thru Files\A\GitIgnore.AZZ
        ///    Files\B\GitIgnore.BAA thru Files\B\GitIgnore.BZZ
        ///    etc terminating with Files\Z\GitIgnore.ZAA thru Files\Z\GitIgnore.ZZZ
        /// Additionally creates a folder containing the same 35k files (GitIgnore.AAA thru GitIgnore.ZZZ) withou0t sub-folders per letter
        /// </summary>
        private static void CreateFiles(bool subFoldersPerLetter)
        {
            alphabet1 = alphabet1.ConvertAll(x => x.ToUpper());
            alphabet2 = alphabet2.ConvertAll(x => x.ToUpper());
            alphabet3 = alphabet3.ConvertAll(x => x.ToUpper());
            alphabet4 = alphabet4.ConvertAll(x => x.ToUpper());

            foreach (var letter1 in alphabet1)
            {
                var fileSuffixChar1 = letter1;
                Console.WriteLine("Creating files beginning with letter " + fileSuffixChar1);

                string subSubPath = subFoldersPerLetter ? @"ByLetter\" : @"All35K\";
                parentPathLetterFolder = parentPath + subPath + @"\" + subSubPath + fileSuffixChar1;

                //Create the A thru Z sub-folders, but not when in 35k mode
                if (subFoldersPerLetter)
                {
                    Directory.CreateDirectory(parentPathLetterFolder);
                }
                else
                {
                    Directory.CreateDirectory(parentPath + subPath + @"\" + subSubPath);
                }

                foreach (var letter2 in alphabet2)
                {
                    var fileSuffixChar2 = letter2;

                    foreach (var letter3 in alphabet3)
                    {
                        var fileSuffixChar3 = letter3;
                        var fullFileSuffix = fileSuffixChar1 + fileSuffixChar2 + fileSuffixChar3;
                        var fileFullPath = parentPath + targetPath + subSubPath;
                        if (subFoldersPerLetter)
                        {
                            fileFullPath += fileSuffixChar1 + @"\";
                        }
                        fileFullPath += fileName + "." + fullFileSuffix;

                        CreateFile(fullFileSuffix, fileSuffixChar1, fileFullPath);
                    }
                }
            }
        }

        /// <summary>
        /// Moves (as opposed to copies) the files from the previous run to C:\Temp, with a unique folder name within C:\Temp
        /// </summary>
        private static void ArchiveExistingFolder()
        {
            targetPath = subPath + @"\";            
            var archivePath = @"C:\Temp\" + subPath;

            Directory.CreateDirectory(archivePath);
            archivePath += DateTime.UtcNow.Ticks.ToString();

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            Console.WriteLine("Archiving ");
            Console.WriteLine("   " + targetPath);
            Console.WriteLine("To");
            Console.WriteLine("   " + archivePath);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Directory.Move(targetPath, archivePath);
            Directory.CreateDirectory(targetPath);
        }

        /// <summary>
        /// Creates the .XXX files themselves on disk, creating any necessary folders at the same time
        /// </summary>
        /// <param name="fileSuffix"></param>
        /// <param name="fileSuffixChar1"></param>
        private static void CreateFile(string fullFileSuffix, string fileSuffixChar1, string fileFullPath)
        {
            var contentStart = "Foo bar ";

            //Create the file, and populate its contents with the 3-letter file suffix (for good measure)
            File.WriteAllText(fileFullPath, contentStart + fullFileSuffix);

            //This creates, for example, a .docX file (also also .abcX file)
            foreach (var letter4 in alphabet4)
            {
                //Treat EDMX files differently, as subsequent inclusion in .Net solutin will fail to compile without this
                var path4 = fileFullPath + letter4;

                var ending = fullFileSuffix + letter4;
                switch (ending)
                {
                    case "EDMX":
                        File.WriteAllText(path4, edmx);
                        File.Create(fileFullPath.Replace("GitIgnore.EDM", "") + @"GitIgnore.Designer.cs"); 
                        break;
                    case "LICX":
                        File.WriteAllText(path4, licx);
                        break;
                    case "RESX":
                        File.WriteAllText(path4, resx);
                        break;
                    default:
                        File.WriteAllText(path4, contentStart + ending);
                        break;
                }
            }
        }

        private const string edmx = 
            @"<?xml version=""1.0"" encoding=""utf-8""?>
                <EntityType Name=""Title"">
                </EntityType>
                <Titles>
                    <Title>  
                        <title>Any</title>
                    </Title> 
                </Titles>";

        private static string licx = string.Empty;

        private const string resx =
           @"<root>
              <resheader name=""resmimetype"">
                <value>text/microsoft-resx</value>
              </resheader>
              <resheader name=""version"">
                <value>2.0</value>
              </resheader>
              <resheader name=""reader"">
                <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
              </resheader>
              <resheader name=""writer"">
                <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
              </resheader>
              <foo>
                bar RESX
              </foo>
            </root>";
    }
}
