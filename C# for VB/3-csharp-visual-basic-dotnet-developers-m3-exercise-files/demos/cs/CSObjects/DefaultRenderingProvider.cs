using System;

namespace CSObjects
{
    public class DefaultRenderingProvider : IRenderingProvider
    {
        public void Render()
        {
            Console.WriteLine("Using default rendering provider...");
        }
    }
}
