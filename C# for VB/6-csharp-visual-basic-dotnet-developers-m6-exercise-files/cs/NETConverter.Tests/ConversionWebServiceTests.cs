using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using NETConverter.Domain;

namespace NETConverter.Tests
{
    [TestClass]
    public class ConversionWebServiceTests
    {
        [TestMethod]
        public void ConvertFile_returns_converted_result()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\User.cs");

            ConversionWebService service = new ConversionWebService();

            var result = service.ConvertFile(info).Result;

            Assert.IsTrue(result.Body.ConvertedCode.Contains("Imports"));
        }
    }
}
