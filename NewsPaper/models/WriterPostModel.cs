namespace ManagingANewspaper.models
{
    public class WriterPostModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public TypeWriter TWriter { get; set; } = TypeWriter.CHILDREN;
    }
}
