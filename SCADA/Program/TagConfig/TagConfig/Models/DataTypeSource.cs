namespace TagConfig
{
    public class DataTypeSource
    {
        public byte DataType { get; set; }

        public string Name { get; set; }

        public DataTypeSource(byte type, string name)
        {
            DataType = type;
            Name = name;
        }
    }
}