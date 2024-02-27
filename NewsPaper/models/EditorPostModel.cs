namespace ManagingANewspaper.models
{
    public class EditorPostModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public TypeEditor TEditor { get; set; } = TypeEditor.CONTENT;
    }
}
