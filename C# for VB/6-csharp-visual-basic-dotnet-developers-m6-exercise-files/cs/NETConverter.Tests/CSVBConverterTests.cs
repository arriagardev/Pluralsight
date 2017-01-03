using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using NETConverter.Domain;
using NETConverter.Tests.Fakes;

namespace NETConverter.Tests
{
    [TestClass]
    public class CSVBNETConverterTests
    {
        [TestMethod]
        public void ConvertAndSave_saves_converted_code_to_new_file()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = currentDirectory + @"\Code.cs";
            IConversionService service = new ConversionServiceFake();
            CSVBConverter converter = new CSVBConverter(service);
            converter.ConvertAndSave(path, currentDirectory);

            path = path.Replace(".cs", ".vb");

            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual(File.ReadAllText(path), "VB");
        }
    }
}
