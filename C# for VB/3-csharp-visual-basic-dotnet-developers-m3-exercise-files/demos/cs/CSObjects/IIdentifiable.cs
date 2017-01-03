namespace CSObjects
{
    public interface IIdentifiable
    {
        string Identify();
    }

    public interface IIdentifiable2 : IIdentifiable
    {
        int Id { get; set; }
    }

    public interface IIdentifiable3
    {
        string Identify();
    }

    public interface IIdentifiable4
    {
        void Identify();
    }
}
