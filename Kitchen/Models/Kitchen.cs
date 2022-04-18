namespace Kitchen.Models
{
    public class Kitchen : Base
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " кухня";
        }
    }

}
