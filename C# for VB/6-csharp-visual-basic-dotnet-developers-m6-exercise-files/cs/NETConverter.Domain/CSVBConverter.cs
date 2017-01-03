using System;
using System.IO;

namespace NETConverter.Domain
{
    public class CSVBConverter
    {
        public event EventHandler<MessageEventArgs> Start;
        public event EventHandler<MessageEventArgs> FileConverted;
        public event EventHandler<MessageEventArgs> Done;

        private IConversionService _conversionService;
        
        private CSVBConverter() { }

        public CSVBConverter(IConversionService conversionService)
        {
            this._conversionService = conversionService;
        }

        private void OnStart()
        {
            if (this.Start != null)
            {
                this.Start(this,
                    new MessageEventArgs("Starting conversion."));
            }
        }

        private void OnFileConverted(string fileName)
        {
            if (this.FileConverted != null)
            {
                this.FileConverted(this,
                    new MessageEventArgs(fileName));
            }
        }

        private void OnDone(string message = "Conversion complete.")
        {
            if (this.Done != null)
            {
                this.Done(this, 
                    new MessageEventArgs(message));
            }
        }

        public void ConvertFolder(string sourceFolderPath, 
                                  string destinationFolerPath)
        {
            DirectoryInfo directory = new DirectoryInfo(sourceFolderPath);

            FileInfo[] files = directory.GetFiles("*.cs");

            if (files.Length == 0)
            {
                files = directory.GetFiles("*.vb");
            }

            if (files.Length > 0)
            {
                this.OnStart();

                foreach (FileInfo file in files)
                {
                    this.ConvertAndSave(file.FullName, destinationFolerPath);
                }

                this.OnDone();    
            }
            else
            {
                this.OnDone("There are no files to convert.");
            }

            
        }

        public void ConvertAndSave(string sourceFilePathAndName, 
                                     string destinationFolderPath, 
                                     bool raiseStartAndEndEvents = false)
        {
            if (raiseStartAndEndEvents)
            {
                this.OnStart();
            }

            ICodeFileInfo info = new CodeFileInfo();
            info.Fill(sourceFilePathAndName);

            var result = this._conversionService.ConvertFile(info).Result;

            info.ConvertedContents = result.Body.ConvertedCode;
            info.Save(destinationFolderPath);

            this.OnFileConverted(info.FileName);

            if (raiseStartAndEndEvents)
            {
                this.OnDone();
            }

        }
    }
}
