using System.Configuration;

namespace NETConverter
{
    public class Config
    {
        private string _sourceFolderPath = null;
        private string _destinationFolderPath = null;

        public bool HasPaths
        {
            get
            {
                return !string.IsNullOrEmpty(this.SourceFolderPath) &&
                    !string.IsNullOrEmpty(this.DestinationFolderPath);
            }
        }

        public string SourceFolderPath
        {
            get 
            {
                if (string.IsNullOrEmpty(this._sourceFolderPath))
                {
                    this._sourceFolderPath = 
                        ConfigurationManager.AppSettings["sourceFolderPath"].ToString();
                }
                return this._sourceFolderPath;
            }
        }

        public string DestinationFolderPath
        {
            get
            {
                if (string.IsNullOrEmpty(this._destinationFolderPath))
                {
                    this._destinationFolderPath = 
                        ConfigurationManager.AppSettings["destinationFolderPath"].ToString();
                }
                return this._destinationFolderPath;
            }
        }

        public void Initalize(string[] args)
        {
            if (args.Length >= 2)
            {
                this._sourceFolderPath = args[0];
                this._destinationFolderPath = args[1];
            }
        }
    }
}
