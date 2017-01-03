using System;

namespace CSObjects
{
    public class Shape
    {
        public int Id { get; set; }

        public bool IsDirty 
        { 
            get; 
            private set; 
        }

        public IRenderingProvider RenderingProvider 
        { 
            private get; 
            set; 
        }

        public Shape() : this(new DefaultRenderingProvider())
        {
            
        }

        public Shape(IRenderingProvider provider)
        {
            Console.WriteLine(string.Format("Constructor " +
                              "(provider = {0}) [Shape]",
                              provider.GetType().Name));

            this.RenderingProvider = provider;
        }

        static Shape()
        {
            Console.WriteLine();
            Console.WriteLine("Constructor - Static [Shape]");
            Console.WriteLine();
        }

        ~Shape()
        {

        }

        public void Fill(string colorName)
        {
            Console.WriteLine("Filling shape: " + colorName);
        }

        public void Draw()
        {
            Console.WriteLine("[]");
        }

        public string Identify()
        {
            return "Identify [Shape]";
        }
    }
}
