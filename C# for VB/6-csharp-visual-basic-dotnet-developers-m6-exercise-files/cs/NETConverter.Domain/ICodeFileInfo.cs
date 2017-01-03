namespace NETConverter.Domain
{
    public interface ICodeFileInfo
    {
        string FileName { get; set; }

        string OriginalExtension { get; set; }
        string OriginalContents { get; set; }

        string ConvertedExtension { get; set; }
        string ConvertedContents { get; set; }

        CodeConversionTypes TypeOfConversion { get; set; }

        void Fill(string filePathAndName);
        void Save(string destinationFolder);
    }
}
