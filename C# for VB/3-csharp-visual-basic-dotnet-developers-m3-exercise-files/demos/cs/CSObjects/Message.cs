using System;
using System.Text;

namespace CSObjects
{
    public class Message
    {
        public string Text { get; set; }

        public bool Save(out string status)
        {
            status = "Success";
            return true;
        }

        public void Concatenate(string delimiter, params string[] words)
        {
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                result.Append(word + delimiter);
            }

            this.Text = result.ToString().TrimEnd(delimiter.ToCharArray());
        }
    }
}
