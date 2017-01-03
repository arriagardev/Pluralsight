using System;
using NETConverter.Domain;

namespace NETConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVBConverter converter;
            Config config = new Config();
            config.Initalize(args);

            if (config.HasPaths)
            {
                converter = new CSVBConverter(new ConversionWebService());

                converter.Start += NETConverter_Start;
                converter.FileConverted += NETConverter_FileConverted;
                converter.Done += NETConverter_Done;

                converter.ConvertFolder(
                            config.SourceFolderPath,
                            config.DestinationFolderPath);
            }
            else
            {
                Console.WriteLine("No source or destination paths are detected.");
            }

            Console.ReadLine();
        }

        static void NETConverter_Done(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        static void NETConverter_Start(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine();
            Console.WriteLine("Converting...");
        }

        static void NETConverter_FileConverted(object sender, MessageEventArgs e)
        {
            Console.WriteLine(string.Format("\t - {0}", e.Message));
        }
    }
}
