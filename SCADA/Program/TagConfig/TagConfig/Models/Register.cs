namespace TagConfig
{
    public class RegisterModule
    {
        public bool Enable { get; set; }

        public string AssemblyPath { get; set; }

        public string ClassName { get; set; }

        public string ClassFullName { get; set; }

        public string Description { get; set; }

        public RegisterModule(string assembly, string className, string classFull, string description)
        {
            AssemblyPath = assembly;
            ClassName = className;
            ClassFullName = classFull;
            Description = description;
        }
    }
}