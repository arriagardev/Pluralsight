using System;

namespace CSObjects
{
    public class CustomRenderingProvider : IRenderingProvider
    {
        public void Render()
        {
            Console.WriteLine("Using custom rendering provider...");
        }
    }
}
