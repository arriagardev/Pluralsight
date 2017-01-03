using System;
using System.IO;

namespace NETConverter.Domain
{
    public class CodeFileInfo : ICodeFileInfo
    {
        public string FileName { get; set; }
        public string OriginalExtension { get; set; }
        public string ConvertedExtension { get; set; }
        public CodeConversionTypes TypeOfConversion { get; set; }
        public string OriginalContents { get; set; }
        public string ConvertedContents { get; set; }

        public void Fill(string filePathAndName)
        {
            FileInfo file = new FileInfo(filePathAndName);

            if (file.Exists)
            {
                this.OriginalExtension = file.Extension.ToLower();
                this.FileName = 
                    file.Name
                        .TrimEnd(".vb".ToCharArray())
                        .TrimEnd(".cs".ToCharArray());

                if (this.OriginalExtension == ".cs")
                {
                    this.ConvertedExtension = ".vb";
                    this.TypeOfConversion = CodeConversionTypes.cs2vbnet;
                }
                else
                {
                    this.ConvertedExtension = ".cs";
                    this.TypeOfConversion = CodeConversionTypes.vbnet2cs;
                }


                this.OriginalContents = File.ReadAllText(filePathAndName);
            }
            else
            {
                throw new Exception(string.Format("{0} does not exist", filePathAndName));
            }
        }

        public void Save(string destinationFolder)
        {
            string path = string.Format(@"{0}\{1}{2}", 
                            destinationFolder, this.FileName, this.ConvertedExtension);
            File.WriteAllText(path, this.ConvertedContents);
        }
    }
}
