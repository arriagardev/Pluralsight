using System;

namespace CSObjects
{
    public class Square : ShapeBase, 
                          IIdentifiable, 
                          IIdentifiable3,
                          IIdentifiable4
    {
        public Square() : this(new DefaultRenderingProvider()) { }

        public Square(IRenderingProvider provider) : base(provider) { }

        public override void Draw()
        {
            Console.WriteLine("[]");
            base.Draw();
        }

        public override void Fill(string colorName)
        {
            Console.WriteLine("Filling square: " + colorName);
        }

        new public string Identify()
        {
            return "Identify [Square:IIdentifiable]";
        }

        string IIdentifiable3.Identify()
        {
            return "Identify [Square:IIdentifiable3]";
        }

        void IIdentifiable4.Identify()
        {
            Console.WriteLine("Identify [Square:IIdentifiable4]");
        }
    }
}
