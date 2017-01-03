using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using NETConverter.Domain;

namespace NETConverter.Tests
{
    [TestClass]
    public class CodeFileInfoTests
    {
        [TestMethod]
        public void Fill_sets_file_name_to_extensionless_file_name()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.vb");

            Assert.AreEqual(info.FileName, "Code");
        }

        [TestMethod]
        public void Fill_using_VB_file_sets_TypeOfConversion_to_vbnet2cs()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.vb");

            Assert.IsTrue(info.TypeOfConversion == CodeConversionTypes.vbnet2cs);
        }

        [TestMethod]
        public void Fill_using_VB_file_sets_ConvertedExtension_to_dot_cs()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.vb");

            Assert.AreEqual(info.ConvertedExtension, ".cs");
        }

        [TestMethod]
        public void Fill_using_VB_file_sets_OriginalExtension_to_dot_vb()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.vb");

            Assert.AreEqual(info.OriginalExtension, ".vb");
        }

        [TestMethod]
        public void Fill_sets_OriginalContents_correctly()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.cs");

            Assert.AreEqual(info.OriginalContents, "cs code");
        }

        [TestMethod]
        public void Fill_using_CS_file_sets_TypeOfConversion_to_cs2vbnet()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.cs");

            Assert.IsTrue(info.TypeOfConversion == CodeConversionTypes.cs2vbnet);
        }

        [TestMethod]
        public void Fill_using_CS_file_sets_ConvertedExtension_to_dot_vb()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.cs");

            Assert.AreEqual(info.ConvertedExtension, ".vb");
        }

        [TestMethod]
        public void Fill_using_CS_file_sets_OriginalExtension_to_dot_cs()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.cs");

            Assert.AreEqual(info.OriginalExtension, ".cs");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Fill_using_nonexistant_file_throws_an_exception()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\fake-fake-file.cs");
        }

        [TestMethod]
        public void Save_writes_converted_content_to_disk()
        {
            string contents = "vb converted code";
            string currentDirectory = Directory.GetCurrentDirectory();
            CodeFileInfo info = new CodeFileInfo();
            info.Fill(currentDirectory + @"\Code.cs");
            info.ConvertedContents = contents;

            info.Save(currentDirectory);

            string path = currentDirectory + @"\" + info.FileName + info.ConvertedExtension;

            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual(File.ReadAllText(path), contents);
        }
    }
}
