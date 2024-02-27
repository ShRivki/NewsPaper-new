using System.Diagnostics.Metrics;

namespace ManagingANewspaper
{
    public enum TypeEditor { CONTENT,LITERARY,TORANY,GENERAL}
    public class Editor : Worker
    {

        static int num = 0;
        public int Id { get; set; }
        public TypeEditor TEditor {  get; set; }=TypeEditor.CONTENT;
        //public int WorkerId { get; set; }
        //public Worker Worker { get; set; }
        
    }
}
