namespace TagConfig
{
    public class Argument
    {
        public short DriverID;
        public string PropertyName;
        public string PropertyValue;

        public Argument(short id, string name, string value)
        {
            DriverID = id;
            PropertyName = name;
            PropertyValue = value;
        }
        public Argument()
        {
            
        }
    }
}