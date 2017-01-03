using System;

namespace CSObjects
{
    public abstract class ShapeBase : IIdentifiable, IIdentifiable2
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

        public ShapeBase()
            : this(new DefaultRenderingProvider())
        {

        }

        public ShapeBase(IRenderingProvider provider)
        {
            Console.WriteLine(string.Format("Constructor " +
                              "(provider = {0}) [ShapeBase]",
                              provider.GetType().Name));

            this.RenderingProvider = provider;
        }

        static ShapeBase()
        {
            Console.WriteLine();
            Console.WriteLine("Constructor - Static [ShapeBase]");
            Console.WriteLine();
        }

        ~ShapeBase()
        {

        }

        public abstract void Fill(string colorName);

        public virtual void Draw()
        {
            this.RenderingProvider.Render();
        }

        public string Identify()
        {
            return "Identify [ShapeBase]";
        }
    }
}
