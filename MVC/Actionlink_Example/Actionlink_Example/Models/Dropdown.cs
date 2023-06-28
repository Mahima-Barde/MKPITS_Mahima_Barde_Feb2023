namespace Actionlink_Example.Models
{
    public class Dropdown
    {
        public TeaType selectedTeatype {get;set; }
       
    }

    public enum TeaType
    {
        Tea,Coffee,GreenTea,BlackTea
    }
}
